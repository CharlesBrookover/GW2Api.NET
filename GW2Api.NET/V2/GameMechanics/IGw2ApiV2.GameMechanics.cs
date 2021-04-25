﻿using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.GameMechanics.Dto.Dungeons;
using GW2Api.NET.V2.GameMechanics.Dto.Legends;
using GW2Api.NET.V2.GameMechanics.Dto.Masteries;
using GW2Api.NET.V2.GameMechanics.Dto.Mounts;
using GW2Api.NET.V2.GameMechanics.Dto.Outfits;
using GW2Api.NET.V2.GameMechanics.Dto.Pets;
using GW2Api.NET.V2.GameMechanics.Dto.Professions;
using GW2Api.NET.V2.GameMechanics.Dto.Races;
using GW2Api.NET.V2.GameMechanics.Dto.Raids;
using GW2Api.NET.V2.GameMechanics.Dto.Skills;
using GW2Api.NET.V2.GameMechanics.Dto.Specializations;
using GW2Api.NET.V2.GameMechanics.Dto.Titles;
using GW2Api.NET.V2.GameMechanics.Dto.Traits;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<int>> GetAllMasteryIdsAsync(CancellationToken token = default);
        Task<Mastery> GetMasteryAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Mastery>> GetMasteriesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Mastery>> GetAllMasteriesAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllMountSkinIdsAsync(CancellationToken token = default);
        Task<MountSkin> GetMountSkinAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<MountSkin>> GetMountSkinsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<MountSkin>> GetAllMountSkinsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<MountSkin>>> GetMountSkinsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<string>> GetAllMountTypeIdsAsync(CancellationToken token = default);
        Task<MountType> GetMountTypeAsync(string id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<MountType>> GetMountTypesAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<MountType>> GetAllMountTypesAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<MountType>>> GetMountTypesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllOutfitIdsAsync(CancellationToken token = default);
        Task<Outfit> GetOutfitAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Outfit>> GetOutfitsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Outfit>> GetAllOutfitsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Outfit>>> GetOutfitsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllPetIdsAsync(CancellationToken token = default);
        Task<Pet> GetPetAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Pet>> GetPetsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Pet>> GetAllPetsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Pet>>> GetPetsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<string>> GetAllProfessionIdsAsync(CancellationToken token = default);
        Task<ProfessionDetails> GetProfessionAsync(string id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<ProfessionDetails>> GetProfessionsAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<ProfessionDetails>> GetAllProfessionsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<ProfessionDetails>>> GetProfessionsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<string>> GetAllRaceIdsAsync(CancellationToken token = default);
        Task<RaceDetails> GetRaceAsync(string id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<RaceDetails>> GetRacesAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<RaceDetails>> GetAllRacesAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<RaceDetails>>> GetRacesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllSpecializationIdsAsync(CancellationToken token = default);
        Task<Specialization> GetSpecializationAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Specialization>> GetSpecializationsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Specialization>> GetAllSpecializationsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Specialization>>> GetSpecializationsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllSkillIdsAsync(CancellationToken token = default);
        Task<Skill> GetSkillAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Skill>> GetSkillsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Skill>> GetAllSkillsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Skill>>> GetSkillsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllTraitIdsAsync(CancellationToken token = default);
        Task<Trait> GetTraitAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Trait>> GetTraitsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Trait>> GetAllTraitsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Trait>>> GetTraitsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<string>> GetAllLegendIdsAsync(CancellationToken token = default);
        Task<Legend> GetLegendAsync(string id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Legend>> GetLegendsAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Legend>> GetAllLegendsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Legend>>> GetLegendsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<string>> GetAllDungeonIdsAsync(CancellationToken token = default);
        Task<Dungeon> GetDungeonAsync(string id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Dungeon>> GetDungeonsAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Dungeon>> GetAllDungeonsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Dungeon>>> GetDungeonsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<string>> GetAllRaidIdsAsync(CancellationToken token = default);
        Task<Raid> GetRaidAsync(string id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Raid>> GetRaidsAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Raid>> GetAllRaidsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Raid>>> GetRaidsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllTitleIdsAsync(CancellationToken token = default);
        Task<Title> GetTitleAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Title>> GetTitlesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Title>> GetAllTitlesAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Title>>> GetTitlesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
    }
}
