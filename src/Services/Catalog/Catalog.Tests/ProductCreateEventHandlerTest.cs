using Catalog.Service.EventHandlers;
using Catalog.Service.EventHandlers.Commands;
using Catalog.Tests.Config;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Tests
{
    [TestClass]
    public class ProductCreateEventHandlerTest
    {
        [TestMethod]
        public async Task HandleCreateProduct_ShouldCreateProductInDatabase()
        {
            // Arrange
            using (var context = ApplicationDBContextInMemory.Get())
            {
                var handler = new ProductCreateEventHandler(context);
                var newProduct = new ProductCreateCommand
                {
                    Name = "Test Product 1",
                    Description = "Test Product description",
                    Price = 20.23M
                };

                // Act
                await handler.Handle(newProduct, CancellationToken.None);

                // Assert
                var createdProduct = await context.Product.FirstOrDefaultAsync(p => p.Name == newProduct.Name);
                Assert.IsNotNull(createdProduct);
                Assert.AreEqual(newProduct.Description, createdProduct.Description);
                Assert.AreEqual(newProduct.Price, createdProduct.Price);
            }
        }

        [TestMethod]
        public async Task HandleCreateProductWithSpecialPrice_ShouldCreateProductWithCorrectPrice()
        {
            // Arrange
            using (var context = ApplicationDBContextInMemory.Get())
            {
                var handler = new ProductCreateEventHandler(context);
                var newProduct = new ProductCreateCommand
                {
                    Name = "Special Product",
                    Description = "A special product with a discounted price",
                    Price = 15.99M // Especial price
                };

                // Act
                await handler.Handle(newProduct, CancellationToken.None);

                // Assert
                var createdProduct = await context.Product.FirstOrDefaultAsync(p => p.Name == newProduct.Name);
                Assert.IsNotNull(createdProduct);
                Assert.AreEqual(newProduct.Price, createdProduct.Price);
            }
        }
    }
}
