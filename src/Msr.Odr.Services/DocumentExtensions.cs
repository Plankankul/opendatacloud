// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Linq;

namespace Msr.Odr.Services
{
    public static class DocumentExtensions
    {
        public static async Task<ICollection<T>> GetQueryResultsAsync<T>(this IDocumentQuery<T> query, CancellationToken token = default)
        {
            var items = new List<T>();
            while(query.HasMoreResults)
            {
                var response = await query.ExecuteNextAsync<T>(token);
                items.AddRange(response);
            }

            return items;
        }
    }
}
