﻿using GW2Api.NET.Json;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Consumable.ConsumableTypes
{
    [JsonDiscriminator("AppearanceChange")]
    public record AppearanceChange() : ConsumableSubDetail();
}
