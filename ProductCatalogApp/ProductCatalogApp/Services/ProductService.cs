using System;
using System.Collections.Generic;
using ProductCatalogApp.Models;

namespace ProductCatalogApp.Services
{
    public class ProductService
    {
        // Lagrar produkter
        private List<Product> products = new List<Product>();

        // Lägger till listan
        public void AddProduct()
        {
            var newProduct = new Product();  // Ny produkt
            products.Add(newProduct);
            Console.WriteLine($"Produkt tillagd: {newProduct.Name}, {newProduct.Category}, {newProduct.Price} kr (ID: {newProduct.Id})");
        }

        // Visar alla produkter i listan
        public void ShowProducts()
        {
            Console.WriteLine("Produkter i katalogen:");
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.Id}, Namn: {product.Name}, Kategori: {product.Category}, Pris: {product.Price} kr");
            }
        }

        // Returnera 
        public List<Product> GetProducts()
        {
            return products;  // Returnera produkt
        }
    }
}