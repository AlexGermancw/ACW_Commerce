using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductConfiguration
    {
        public ProductConfiguration(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasIndex(p => p.ProductId);
            entityBuilder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            entityBuilder.Property(p => p.Description).IsRequired().HasMaxLength(500);

            //Products by default
            var products = new List<Product>();
            var random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                products.Add(new Product
                {
                    ProductId = i,
                    Name = $"Prodcut {i}",
                    Description = $"Description for product {i}",
                    Price = random.Next(100, 1000) + random.Next(0,100)/100m
                });
            }

            entityBuilder.HasData(products);

        }
    }
}
