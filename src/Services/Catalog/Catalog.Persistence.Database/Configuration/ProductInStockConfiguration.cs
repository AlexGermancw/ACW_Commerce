using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductInStockConfiguration
    {
        public ProductInStockConfiguration(EntityTypeBuilder<ProductInStock> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.ProductId);

            var random = new Random();
            var stocks =  new List<ProductInStock>();

            for (int i = 1; i <= 100; i++)
            {
                stocks.Add(new ProductInStock
                {
                    ProductInStockId = i,
                    ProductId = i,
                    Stock = random.Next(1, 50)
                });
            }

            entityTypeBuilder.HasData(stocks);
        }
    }
}
