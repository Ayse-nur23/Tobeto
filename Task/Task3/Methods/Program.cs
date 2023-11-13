using System;

namespace Methods
{
    class Program
    {
        //Metotlar tekrar tekrar kullanılabilir alan 
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Acıklama = "Amasya Elması";
            urun1.StokAdedi = 10;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Acıklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 9;

            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + "\n" + urun.Fiyati + "\n" + urun.Acıklama);
                Console.WriteLine("-------------------------------");
            }

            Console.WriteLine("--------------Metotlar------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,5);
        }
    }
}