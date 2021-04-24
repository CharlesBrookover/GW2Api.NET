﻿using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Maps.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {

        public Task<IList<int>> GetAllContinentIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("continents", token);

        public Task<Continent> GetContinentAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Continent>(
                $"continents/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Continent>> GetContinentsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Continent>>(
                "continents",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Continent>> GetAllContinentsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Continent>>(
                "continents",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<Continent>>> GetContinentsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Continent>>(
                "continents",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllFloorIdsAsync(int continentId, CancellationToken token = default)
            => GetAsync<IList<int>>($"continents/{continentId}/floors", token);

        public Task<Floor> GetFloorAsync(int continentId, int floorId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Floor>(
                $"continents/{continentId}/floors/{floorId}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Floor>> GetFloorsAsync(int continentId, IEnumerable<int> floorIds, CultureInfo lang = null, CancellationToken token = default)
        {
            if (floorIds is null)
                throw new ArgumentNullException(nameof(floorIds));

            return GetAsync<IList<Floor>>(
                $"continents/{continentId}/floors",
                new Dictionary<string, string>
                {
                    { "ids", floorIds.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Floor>> GetAllFloorsAsync(int continentId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Floor>>(
                $"continents/{continentId}/floors",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<Floor>>> GetFloorsAsync(int continentId, int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Floor>>(
                $"continents/{continentId}/floors",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllFloorRegionIdsAsync(int continentId, int floorId, CancellationToken token = default)
            => GetAsync<IList<int>>($"continents/{continentId}/floors/{floorId}/regions", token);

        public Task<FloorRegion> GetFloorRegionAsync(int continentId, int floorId, int regionId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<FloorRegion>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<FloorRegion>> GetFloorRegionsAsync(int continentId, int floorId, IEnumerable<int> regionIds, CultureInfo lang = null, CancellationToken token = default)
        {
            if (regionIds is null)
                throw new ArgumentNullException(nameof(regionIds));

            return GetAsync<IList<FloorRegion>>(
                $"continents/{continentId}/floors/{floorId}/regions",
                new Dictionary<string, string>
                {
                    { "ids", regionIds.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<FloorRegion>> GetAllFloorRegionsAsync(int continentId, int floorId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<FloorRegion>>(
                $"continents/{continentId}/floors/{floorId}/regions",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<FloorRegion>>> GetFloorRegionsAsync(int continentId, int floorId, int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<FloorRegion>>(
                $"continents/{continentId}/floors/{floorId}/regions",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllMapIdsAsync(int continentId, int floorId, int regionId, CancellationToken token = default)
            => GetAsync<IList<int>>($"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps", token);

        public Task<Map> GetMapAsync(int continentId, int floorId, int regionId, int mapId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Map>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps/{mapId}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Map>> GetMapsAsync(int continentId, int floorId, int regionId, IEnumerable<int> regionIds, CultureInfo lang = null, CancellationToken token = default)
        {
            if (regionIds is null)
                throw new ArgumentNullException(nameof(regionIds));

            return GetAsync<IList<Map>>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps",
                new Dictionary<string, string>
                {
                    { "ids", regionIds.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Map>> GetAllMapsAsync(int continentId, int floorId, int regionId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Map>>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<Map>>> GetMapsAsync(int continentId, int floorId, int regionId, int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Map>>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );
    }
}
