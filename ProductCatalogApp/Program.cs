using ProductCatalogApp.Services;

namespace ProductCatalogApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa instans 
            var productService = new ProductService();

            // Lägg produkt 
            productService.AddProduct();

            // Visa produkter i produktkatalogen
            productService.ShowProducts();

            // Vänta på att konsumenten trycker på en tangent för att avsluta 
            Console.WriteLine("Tryck på valfri tangent för att avsluta.");
            Console.ReadKey();
        }
    }
}