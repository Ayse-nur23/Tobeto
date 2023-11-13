using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //bir nesnede bir değeri kullanmak zorunda değilsek orada soyutlama hatası vardır.gercek müşteride SirketAdi olması gibi
            
            GercekMüsteri musteri1 = new GercekMüsteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "22222222222";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri-Tüzel Müşteri
            //SOLID

            //new-yeni referans no
            //musteri referansı hem tuzel hem de gercek musteri referans numarsını tutabilir
            Musteri musteri3 = new GercekMüsteri();
            Musteri musteri4 = new TuzelMusteri();
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);
        }
    }
}
