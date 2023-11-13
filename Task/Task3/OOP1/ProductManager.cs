using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //bu tip classlarda operasyon(ekleme,silme,güncelleme) içerir
        //void:değer döndürmez(göndermez),işlem yaptırmaz return yapılmaz
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
    }
}
