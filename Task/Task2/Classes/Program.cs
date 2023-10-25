using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager(); //nesne oluşturmak
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Engin"; 
            customer.LastName = "Demiroğ";
            customer.City = "Ankara";

            Customer customer2 = new Customer
            {
                Id = 2, City = "İstanbul", FirstName = "Derin", LastName = "Demiroğ"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }

    internal class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added!");
        }
        public void Update()
        {
            Console.WriteLine("Product Updated!");
        }
    }
}
