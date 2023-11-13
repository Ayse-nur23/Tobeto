using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_08._11._23
{
    internal class Product
    {
        //constructor method
        //yapıcı bloklar
        //içersinde hiç bir ctor bulumayan classlarda oto. sıfır argümanlı bir ctor tanımlıdır.
        public Product()
        {                
            Console.WriteLine("Yapıcıc metot çalıştı.");
        }

        //Farklı parametre kombinasyonlarında ctor'lar tanımlanabilir.
        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
        // Çalışma zamanında birbirinden ayırt edilebilecek imzaları olması.
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            Console.WriteLine("Yapıcıc metot çalıştı.");
        }
        public string Name;
        public int Stock;
        public double Price;
    }
}
