using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProductCatalogApp.Models;

namespace ProductCatalogApp.Utilities
{
    public class FileManager
    {
        // Spara till en fil i JSON-form
        public void SaveToFile(List<Product> products, string filePath)
        {
            string jsonData = JsonConvert.SerializeObject(products, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        // Läsa in produkter från JSÓn
        public List<Product> LoadFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Product>>(jsonData) ?? new List<Product>();
            }

            return new List<Product>();  // Returnerar en inget om filen ej finns
        }
    }
}