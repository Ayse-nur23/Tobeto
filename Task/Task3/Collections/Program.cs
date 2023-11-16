using System;
using System.Collections.Generic;

namespace Koleksiyonlar_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //new dendiği zaman yeni bir yer,referans oluşur.
            //Array:dizi eklenemez,silinemez,genişletemez
            //List:değer kaybetmez,ekleyebilirler,silinirler,genişletilirler

            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler[4] = "İlker"; //hata veriyor
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
