using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 2;
            product.ProductName = "Masa";
            product.UnitPrice = 500;
            product.UnitsInStock = 3;


            Product product1 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };


            //PascalCase   //camelCase 
            ProductManager productManager = new ProductManager();
            productManager.Add(product);

            
        }
    }
}
