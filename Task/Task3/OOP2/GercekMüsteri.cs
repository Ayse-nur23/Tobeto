using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //derived class-gerçek müşteri
    //base class-musteri
    class GercekMüsteri:Musteri
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
    }
}
