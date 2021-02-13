using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //veritabanı bağlantımızı oluşturalım:
            NorthwindContext northwindContext = new NorthwindContext();

            GetAllProducts(northwindContext);
            GetProductsByCategory(northwindContext,1);
        }

        private static void GetProductsByCategory(NorthwindContext northwindContext,int categoryId)
        {
            //Verilen kategory id 'ye göre product nameleri listler
            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetAllProducts(NorthwindContext northwindContext)
        {
            //northwindContext ile dbmize bağlanıyoruz. .Products dediğimizde Products tablosunu çağırırız. 
            //Bu Products tablosundaki ProductName kolonlarını yazdıralım:
            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
