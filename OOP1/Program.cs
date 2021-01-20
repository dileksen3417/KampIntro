using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //2 bizim için Mobilya kategorisi olsun.
            product1.ProductName = "Katlanır Masa";
            product1.UnitPrice = 500.00;
            product1.UnitsInStock = 3;

            //farklı bir nesne yaratma yöntemi!
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitPrice = 15,
                ProductName = "Tükenmez Kalem", UnitsInStock = 70 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
