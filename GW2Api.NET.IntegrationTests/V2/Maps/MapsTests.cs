using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Maps
{
    [TestClass, TestCategory("Large"), TestCategory("V2"), TestCategory("V2 Maps")]
    public class MapsTests
    {
        private IGw2ApiV2 _api;

        [TestInitialize]
        public void Setup()
            => _api = new Gw2ApiV2(new HttpClient());

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllContinentIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllContinentIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetContinentAsync_TestData()
            => new List<object[]>
            {
                new object[] { 2 },
                new [] { (null, "Mists"), ("es", "La Niebla") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetContinentAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetContinentAsync_ValidId_ReturnsThatContinent(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetContinentAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetContinentsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetContinentsAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetContinentsAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 1, 2 } },
                new [] {
                    (null, new List<string> { "Tyria", "Mists" }.AsEnumerable()),
                    ("es", new List<string> { "Tyria", "La Niebla" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetContinentsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetContinentsAsync_ValidIds_ReturnsThoseContinents(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetContinentsAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllContinentsAsync_AnyParams_ReturnsAllContinents(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllContinentsAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetContinentsAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetContinentsAsync(page: 1, pageSize: 1, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllFloorIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;

            var result = await _api.GetAllFloorIdsAsync(continentId, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetFloorAsync_TestData()
            => new List<object[]>
            {
                new object[] { 0 },
                new [] { (null, "Shiverpeak Mountains"), ("es", "Monta�as Picosescalofriantes") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetFloorAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetFloorAsync_ValidId_ReturnsThatFloor(int floorId, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var (lang, name) = langNameTuple;

            var result = await _api.GetFloorAsync(continentId, floorId, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(floorId, result.Id);
            Assert.IsTrue(result.Regions.Values.Select(x => x.Name).Contains(name));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetFloorsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;

            await _api.GetFloorsAsync(continentId, floorIds: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetFloorsAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 0, 1 } },
                new [] {
                    (null, new List<string> { "Shiverpeak Mountains", "Shiverpeak Mountains" }.AsEnumerable()),
                    ("es", new List<string> { "Monta�as Picosescalofriantes", "Monta�as Picosescalofriantes" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetFloorsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetFloorsAsync_ValidIds_ReturnsThoseFloors(IEnumerable<int> floorIds, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;
            var (lang, names) = langNamesTuple;

            var result = await _api.GetFloorsAsync(continentId, floorIds, lang, cts.GetTokenOrDefault());

            CollectionAssert.IsSubsetOf(names.ToList(), result.SelectMany(x => x.Regions.Values).Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllFloorsAsync_AnyParams_ReturnsAllFloors(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;

            var result = await _api.GetAllFloorsAsync(continentId, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetFloorsAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var continentId = 1;

            var result = await _api.GetFloorsAsync(continentId, page: 1, pageSize: 1, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }
    }
}
