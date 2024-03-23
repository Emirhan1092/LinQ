namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            { 
                new Category { CategoryId=1 ,CategoryName="Bilgisayar"},
                new Category { CategoryId = 2, CategoryName = "Telefon" },
            };
            List<Product> products = new List<Product>
            {
                new Product { ProductId=1 ,CategoryId =1 , ProductName="Acer Laptop",QuantitiyPerUnit="32 Ram",UnitPrice=1000,UnitsInStock=5},
                new Product { ProductId=2 ,CategoryId =1 , ProductName="Asus Laptop",QuantitiyPerUnit="16 Ram",UnitPrice=8000,UnitsInStock=15},
                new Product { ProductId=3 ,CategoryId =1 , ProductName="Hp Laptop",QuantitiyPerUnit="8 Ram",UnitPrice=6000,UnitsInStock=25},
                new Product { ProductId=4 ,CategoryId =2 , ProductName="Samsung Laptop",QuantitiyPerUnit="4 Ram",UnitPrice=5000,UnitsInStock=53},
                new Product { ProductId=5 ,CategoryId =2 , ProductName="Apple Laptop",QuantitiyPerUnit="4 Ram",UnitPrice=8000,UnitsInStock=52},

             };

            var result = products.Where(p=>p.UnitPrice>5000);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName); 
                
            }



           
        }
       
    }

    class Product 
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string  QuantitiyPerUnit { get; set; }

        public decimal UnitPrice   { get; set; }

        public int UnitsInStock { get; set; }
        public int CategoryId { get; internal set; }
    }

    class Category
    {
        public int CategoryId { get; set;}

        public string CategoryName { get; set; }
    }
}
