﻿using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Maps.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<int>> GetAllContinentIdsAsync(CancellationToken token = default);
        Task<Continent> GetContinentAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Continent>> GetContinentsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Continent>> GetAllContinentsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Continent>>> GetContinentsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllFloorIdsAsync(int continentId, CancellationToken token = default);
        Task<Floor> GetFloorAsync(int continentId, int floorId, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Floor>> GetFloorsAsync(int continentId, IEnumerable<int> floorIds, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Floor>> GetAllFloorsAsync(int continentId, CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Floor>>> GetFloorsAsync(int continentId, int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllFloorRegionIdsAsync(int continentId, int floorId, CancellationToken token = default);
        Task<FloorRegion> GetFloorRegionAsync(int continentId, int floorId, int regionId, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<FloorRegion>> GetFloorRegionsAsync(int continentId, int floorId, IEnumerable<int> regionIds, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<FloorRegion>> GetAllFloorRegionsAsync(int continentId, int floorId, CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<FloorRegion>>> GetFloorRegionsAsync(int continentId, int floorId, int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllMapIdsAsync(int continentId, int floorId, int regionId, CancellationToken token = default);
        Task<Map> GetMapAsync(int continentId, int floorId, int regionId, int mapId, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Map>> GetMapsAsync(int continentId, int floorId, int regionId, IEnumerable<int> mapIds, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Map>> GetAllMapsAsync(int continentId, int floorId, int regionId, CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Map>>> GetMapsAsync(int continentId, int floorId, int regionId, int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
    }
}
