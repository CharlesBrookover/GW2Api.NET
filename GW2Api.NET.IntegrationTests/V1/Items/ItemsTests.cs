﻿using GW2Api.NET.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1.Items
{
    [TestClass, TestCategory("Large"), TestCategory("Items")]
    public class ItemsTests
    {
        private IGw2ApiV1 _api;

        [TestInitialize]
        public void Setup()
        {
            _api = new Gw2ApiV1(new HttpClient());
        }

        [TestMethod]
        public async Task GetAllItemIds_NoParams_ReturnsItemIds()
        {
            var itemIds = await _api.GetAllItemIds();

            Assert.IsTrue(itemIds.Any());
        }

        [TestMethod]
        public async Task GetAllItemIds_CancellationToken_ReturnsItemIds()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var itemIds = await _api.GetAllItemIds(token: cts.Token);

            Assert.IsTrue(itemIds.Any());
        }

        [TestMethod]
        public async Task GetItemDetail_ValidItemId_ReturnsThatItemDetail()
        {
            var itemId = 6;
            var itemName = "((208738))";

            var itemDetail = await _api.GetItemDetail(itemId);

            Assert.AreEqual(itemName, itemDetail.Name);
        }

        [TestMethod]
        public async Task GetItemDetail_ValidItemIdAndCancellationToken_ReturnsThatItemDetail()
        {
            using var cts = TestData.CreateDefaultTokenSource();
            var itemId = 6;
            var itemName = "((208738))";

            var itemDetail = await _api.GetItemDetail(itemId, token: cts.Token);

            Assert.AreEqual(itemName, itemDetail.Name);
        }
    }
}
