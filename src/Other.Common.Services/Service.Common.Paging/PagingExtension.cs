﻿using Microsoft.EntityFrameworkCore;
using Service.Common.Collection;

namespace Service.Common.Paging
{
    public static class PagingExtension
    {
        public static async Task<DataCollection<T>> GetPagedAsync<T>(
            this IQueryable<T> querry,
            int page,
            int take)
        {
            var originalPages = page;

            page--;

            if (page > 0)
            {
                page = page * take;
            }

            var result = new DataCollection<T>()
            {
                Items = await querry.Skip(page).Take(take).ToListAsync(),
                Total = await querry.CountAsync(),
                Page = originalPages
            };

            if (result.Total > 0)
            {
                result.Pages = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(result.Total) / take));
            }

            return result;
        }
    }
}
