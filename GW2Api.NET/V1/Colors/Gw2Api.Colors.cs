﻿using GW2Api.NET.V1.Colors;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _colorsResource = "colors.json";

        public async Task<IReadOnlyDictionary<string, Color>> GetAllColorsAsync(CultureInfo cultureInfo = null, CancellationToken token = default)
            => (await GetAsync<ColorsResponse>(
                _colorsResource,
                new Dictionary<string, string>
                {
                    { "lang", cultureInfo?.TwoLetterISOLanguageName }
                },
                token
            )).Colors.ToDictionary(
                x => x.Key,
                x => x.Value with
                {
                    Id = x.Key
                }
            );
    }
}
