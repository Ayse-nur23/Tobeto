using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class CustomerManager
    {
        //bu tip classlarda operasyon(ekleme,silme,güncelleme) içerir
        //void:değer döndürmez(göndermez),işlem yaptırmaz return yapılmaz
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }
    }
}
