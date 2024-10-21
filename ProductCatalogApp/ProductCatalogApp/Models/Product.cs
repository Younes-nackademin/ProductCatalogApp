namespace ProductCatalogApp.Models
{
    public class Product
    {
        private static int _idCounter = 1;  //Produktens id 

        public int Id { get; private set; }  
        public string Name { get; private set; }  // Namn
        public string Category { get; private set; }  // Kategori
        public decimal Price { get; private set; }  // här 500 kr

        //Sammanställer
        public Product()
        {
            Id = _idCounter++;
            Name = "Adidas";           
            Category = "Tröja";        
            Price = 500m;              
        }
    }
}