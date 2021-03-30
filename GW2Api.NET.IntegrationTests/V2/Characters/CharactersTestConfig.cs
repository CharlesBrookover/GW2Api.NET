﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace GW2Api.NET.IntegrationTests.V2.Characters
{
    public class CharactersTestConfig
    {
        public IEnumerable<string> Ids { get; set; }
        public string Id
        {
            get
            {
                var id = Ids.FirstOrDefault();
                if (id is null)
                    Assert.Fail("You must configure at least one character id in v2.config.json to run this test");
                return id;
            }
        }
        public int TotalCharacters { get; set; }
    }
}
