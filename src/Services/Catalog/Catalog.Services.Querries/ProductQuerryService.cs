using Catalog.Persistence.Database;
using Catalog.Services.Querries.DTOs;
using Microsoft.EntityFrameworkCore;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Services.Querries
{
    public interface IProductQuerryService
    {
        Task<DataCollection<ProductDto>> GetAllAsync(int page, int take, IEnumerable<int> products = null);
        Task<ProductDto> GetAsync(int id);
    }

    public class ProductQuerryService : IProductQuerryService
    {
        private readonly ApplicationDBContext _context;

        public ProductQuerryService(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<DataCollection<ProductDto>> GetAllAsync(int page, int take, IEnumerable<int> products = null)
        {
            var collection = await _context.Product
                .Where(p => products == null || products.Contains(p.ProductId))
                .OrderByDescending(p => p.ProductId)
                .GetPagedAsync(page, take);

            return collection.MapTo<DataCollection<ProductDto>>();
        }

        public async Task<ProductDto> GetAsync(int id)
        {
            return (await _context.Product.SingleAsync(p  => p.ProductId == id)).MapTo<ProductDto>();
        }
    }
}
