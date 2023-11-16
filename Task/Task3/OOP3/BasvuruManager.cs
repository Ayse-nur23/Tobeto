using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(ICrediManager crediManager,List<ILoggerService> loggerServices)
        {
            //Başvuran bilgileri değerlendirme
            //...
            //Tüm kredileri içinde barındırdığı için ICrediMangerden almak daha mantıklı
            crediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log(); 
            }
        }

        public void KrediOnBilgilendirmesiYap(List<ICrediManager> credis)
        {
            foreach (var credi in credis)
            {
                credi.Hesapla();
            }
        }
    }
}
