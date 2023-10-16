using Catalog.Domain;
using Catalog.Services.Querries;
using Catalog.Services.Querries.DTOs;
using Catalog.Tests.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Service.Common.Mapping;

namespace Catalog.Tests
{
    [TestClass]
    public class ProductQuerryServiceTest
    {
        [TestMethod]
        public async Task GetAllAsyncShouldReturnAllProductCollection()
        {
            // Arrange
            var context = ApplicationDBContextInMemory.Get();
            var productService = new ProductQuerryService(context);
            var productData = ProductDataTest.Products;

            // Act
            context.Product.AddRange(productData);
            context.SaveChanges();

            var page = 1;
            var take = 10;
            IEnumerable<int>? products = null;
            var response = await productService.GetAllAsync(page, take, products);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(productData.Count, response.Items.Count());
        }

        [TestMethod]
        public async Task GetAllAsyncShouldReturnNullProductCollection()
        {
            // Arrange
            var context = ApplicationDBContextInMemory.Get();
            var productService = new ProductQuerryService(context);
            var productData = ProductDataTest.Products;

            // Act
            productData.Clear();
            context.Product.AddRange(productData);
            context.SaveChanges();

            var page = 1;
            var take = 10;
            IEnumerable<int>? products = null;
            var response = await productService.GetAllAsync(page, take, products);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(0, response.Items.Count());
        }

        [TestMethod]
        public async Task GetAsyncShouldReturnProductDto()
        {
            // Arrange
            var context = ApplicationDBContextInMemory.Get();
            var productService = new ProductQuerryService(context);
            var productData = ProductDataTest.Products;

            // Act
            context.Product.AddRange(productData);
            context.SaveChanges();
            var id = 1;

            var response = await productService.GetAsync(id);

            // Assert
            Assert.IsNotNull(response);
            var expectedProduct = productData.FirstOrDefault(p => p.ProductId == id)?.MapTo<ProductDto>();
            Assert.AreEqual(expectedProduct?.Name, response.Name);
            Assert.AreEqual(expectedProduct?.Description, response.Description);
        }

    }
}