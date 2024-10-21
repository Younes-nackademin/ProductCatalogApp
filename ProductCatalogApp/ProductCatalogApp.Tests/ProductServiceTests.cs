using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductCatalogApp.Services;
using ProductCatalogApp.Models;
using System.Collections.Generic;

namespace ProductCatalogApp.Tests
{
    [TestClass]
    public class ProductServiceTests   // Produkter läggs in korrekt
    {
        [TestMethod]
        public void AddProduct_ShouldIncreaseListCount()  //Testart antalet produkter
        {
            
            var productService = new ProductService();
            int initialCount = productService.GetProducts().Count;

            
            productService.AddProduct();  // Lägger till tröjan

            
            Assert.AreEqual(initialCount + 1, productService.GetProducts().Count);
        }

        [TestMethod]
        public void AddProduct_ShouldAddProductWithCorrectDetails()
        {
            
            var productService = new ProductService();

            
            productService.AddProduct();
            var products = productService.GetProducts();

            
            Assert.AreEqual("Adidas", products[0].Name);
            Assert.AreEqual("Tröja", products[0].Category);
            Assert.AreEqual(500m, products[0].Price);
        }

        [TestMethod]
        public void ShowProducts_ShouldNotThrowExceptionWithEmptyList()
        {
            
            var productService = new ProductService();

            
            try
            {
                productService.ShowProducts();
            }
            catch
            {
                Assert.Fail("ShowProducts should not throw an exception when the product list is empty.");
            }
        }
    }
}