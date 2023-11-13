using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {//eğer bır manager sınıfın içinde başka manager sınıf kullanılıcaksa newlenmez
        static void Main(string[] args)
        {
            //interface'lerde implode yaptığı referans numarasını  tutar
            ICrediManager IhtiyacKrediManager = new IhtiyacKrediManager();
             //IhtiyacKrediManager.Hesapla();
            ICrediManager tasıtKrediManager = new TasıtKrediManager();
            //tasıtKrediManager.Hesapla();
            ICrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ILoggerService databaseLoggerService = new DatebaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();



            //yorum satırındakileri yapmaktasa bu yapılır
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(IhtiyacKrediManager,
                new List<ILoggerService> { new DatebaseLoggerService(), new FileLoggerService() }    /*databaseLoggerService---new DatebaseLoggerService()*/);

            List<ICrediManager> credis = new List<ICrediManager>() {IhtiyacKrediManager,tasıtKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(credis);
            
        }
    }
}
