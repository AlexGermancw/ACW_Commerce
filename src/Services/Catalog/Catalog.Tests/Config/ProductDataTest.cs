using Catalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Tests.Config
{
    public static class ProductDataTest
    {
        public static List<Product> Products { get; } = new List<Product>
        {
            new Product
        {
            ProductId = 1,
            Name = "Prodcut 1",
            Description = "Description for product 1",
            Price = 322.92M,
            Stock = null
        },
            new Product
            {
                ProductId = 2,
                Name = "Prodcut 2",
                Description = "Description for product 2",
                Price = 322.92M,
                Stock = null
            },
            new Product
            {
                ProductId = 3,
                Name = "Prodcut 3",
                Description = "Description for product 3",
                Price = 322.92M,
                Stock = null
            },
            new Product
            {
                ProductId = 4,
                Name = "Prodcut 4",
                Description = "Description for product 4",
                Price = 625.54M,
                Stock = null
            },
            new Product
            {
                ProductId = 5,
                Name = "Prodcut 5",
                Description = "Description for product 5",
                Price = 638.67M,
                Stock = null
            },
            new Product
            {
                ProductId = 6,
                Name = "Prodcut 6",
                Description = "Description for product 6",
                Price = 848.00M,
                Stock = null
            },
            new Product
            {
                ProductId = 7,
                Name = "Prodcut 7",
                Description = "Description for product 7",
                Price = 511.38M,
                Stock = null
            },
            new Product
            {
                ProductId = 8,
                Name = "Prodcut 8",
                Description = "Description for product 8",
                Price = 916.31M,
                Stock = null
            },
            new Product
            {
                ProductId = 9,
                Name = "Prodcut 9",
                Description = "Description for product 9",
                Price = 488.29M,
                Stock = null
            },
            new Product
            {
                ProductId = 10,
                Name = "Prodcut 10",
                Description = "Description for product 10",
                Price = 819.30M,
                Stock = null
            }
        };
    }
}
