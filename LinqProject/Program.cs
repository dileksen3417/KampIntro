using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar"},
                new Category{CategoryId=2, CategoryName="Telefon" }
            };

            List<Product> products = new List<Product> {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitInStock=5},
                new Product{ProductId=2, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="16 GB Ram", UnitPrice=6000, UnitInStock=3},
                new Product{ProductId=3, CategoryId=1, ProductName="HP Laptop", QuantityPerUnit="8 GB Ram", UnitPrice=6000, UnitInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Samsung Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=5000, UnitInStock=15},
                new Product{ProductId=5, CategoryId=2, ProductName="Apple Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=8000, UnitInStock=0}
            };


            //Console.WriteLine("Linq'e neden ihtiyac duyarız?\n\n");
            //Example(products);

            //AnyMethod(products);

            //FindMethod(products);

            //FindAllMethod(products);

            //OrderByMethod(products);

            //FromYontemi(products);

            //WorkWithDto(products);

            JoinMethod(categories, products);

        }

        private static void JoinMethod(List<Category> categories, List<Product> products)
        {
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 5000
                         orderby p.ProductName descending
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };


            foreach (var productDto in result)
            {
                Console.WriteLine("{0} --- {1}", productDto.ProductName, productDto.CategoryName);
            }
        }

        private static void WorkWithDto(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        class ProductDto
        {
            public int ProductId { get; set; }
            public string CategoryName { get; set; }
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }

        }

        private static void FromYontemi(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000       //bir sart daha koymak için && p.Stock>10 ..diye uzatılabilir
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select p;

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void OrderByMethod(List<Product> products)
        {
            Console.WriteLine("\nAdında top gecenleri UnitPrice'a göre asc sırala:");
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("\nAdında top gecenleri UnitPrice'a göre desc sırala:");
            var result1 = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice);
            foreach (var item in result1)
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("\nAdında top gecenleri UnitPrice'a göre desc sırala, aynı fiyata sahip olanları kendi içinde ProductName'i z->a sırala:");

            var result2 = products.Where(p=>p.ProductName.Contains("top")).OrderByDescending(p=>p.UnitPrice).ThenByDescending(p=>p.ProductName);
            foreach (var item in result2)
            {
                Console.WriteLine(item.ProductName);
            }

        }

        private static void FindAllMethod(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindMethod(List<Product> products)
        {
            Product findResult = products.Find(p => p.ProductId == 3);
        }

        private static void AnyMethod(List<Product> products)
        {
            bool result = products.Any(p => p.ProductName == "Acer Laptop"); //Any methodu bool değer döndürür, true döner
            bool result2 = products.Any(p => p.ProductName == "Dell"); //false döner
        }

        private static void Example(List<Product> products)
        {
            Console.WriteLine("Algoritmik............");

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }

            }
            GetProductsByAlg(products);

            Console.WriteLine("Linq............");
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static List<Product> GetProductsByAlg(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    filteredProducts.Add(product);
                }

            }
            return filteredProducts;
        }

        static List<Product> GetProductsByLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList(); //where arkada bir IEnumarable tipinde array oluşturur.
                                                                                         //List döndürmek istediğimiz için ToList methodunu kullanırız.
        }

    }
}
