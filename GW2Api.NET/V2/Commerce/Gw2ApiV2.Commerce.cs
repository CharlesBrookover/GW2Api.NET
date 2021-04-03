﻿using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Commerce.Dto;
using GW2Api.NET.V2.Common;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<Page<IList<Transaction>>> GetCurrentBuyTransactionsAsync(string accessToken = null, int page = -1, int pageSize = -1, CancellationToken token = default)
            => GetPageWithAuthAsync<IList<Transaction>>(
                "commerce/transactions/current/buys",
                new Dictionary<string, string>().ConfigurePage(page, pageSize),
                accessToken,
                token
            );

        public Task<Page<IList<Transaction>>> GetCurrentSellTransactionsAsync(string accessToken = null, int page = -1, int pageSize = -1, CancellationToken token = default)
            => GetPageWithAuthAsync<IList<Transaction>>(
                "commerce/transactions/current/sells",
                new Dictionary<string, string>().ConfigurePage(page, pageSize),
                accessToken,
                token
            );
        public Task<Page<IList<Transaction>>> GetHistoricalBuyTransactionsAsync(string accessToken = null, int page = -1, int pageSize = -1, CancellationToken token = default)
            => GetPageWithAuthAsync<IList<Transaction>>(
                "commerce/transactions/history/buys",
                new Dictionary<string, string>().ConfigurePage(page, pageSize),
                accessToken,
                token
            );

        public Task<Page<IList<Transaction>>> GetHistoricalSellTransactionsAsync(string accessToken = null, int page = -1, int pageSize = -1, CancellationToken token = default)
            => GetPageWithAuthAsync<IList<Transaction>>(
                "commerce/transactions/history/sells",
                new Dictionary<string, string>().ConfigurePage(page, pageSize),
                accessToken,
                token
            );
    }
}
