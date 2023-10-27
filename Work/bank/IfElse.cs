using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class IfElse
    {
        internal class Program
        {
            private static void Main(string[] args)
            {
            Main1:
                try
                {
                    double bakiye = 2700.0;
                    double cekilenTutar;
                    double yatirilanTutar;

                Main:
                    Console.WriteLine("Bankamatiğimize Hoşgeldiniz...! \n" +
                        "Lütfen İşlem Seçiniz \n" +
                        "------------------------------- \n" +
                        "****Seçenekler**** \n" +
                        "1-Para Çekme \n" +
                        "2-Para Yatırma \n" +
                        "3-Başlangıç Menüsüne Dönme\n" +
                        "4-Kart İade \n" +
                        "-------------------------------");
                    int islem = Convert.ToInt32(Console.ReadLine());
                 
                    if (islem == 1)
                    {
                        Console.WriteLine("Para Çekme Ekranındasınız...\n" + "bakiyeniz :" + bakiye);
                        Console.Write("Çekmek istediğiniz tutar :");
                        cekilenTutar = Convert.ToDouble(Console.ReadLine());
                        ParaCekme(ref bakiye, cekilenTutar);
                        Console.WriteLine("Mevcut Bakiyeniz: {0}", bakiye);
                        Console.ReadLine();
                        goto Main;
                    }
                    else if (islem == 2)
                    {
                        Console.WriteLine("Para Yatırma Ekranındasınız...\n" + "bakiyeniz :" + bakiye);
                        Console.Write("Yatırmak istediğiniz tutar :");
                        yatirilanTutar = Convert.ToDouble(Console.ReadLine());
                        ParaYatırma(ref bakiye, yatirilanTutar);
                        Console.WriteLine("Mevcut Bakiyeniz: {0}", bakiye);
                        Console.ReadLine();
                        goto Main;
                    }
                    else if (islem == 3)
                    {
                        Console.WriteLine("Başlangıç Menüsüne Yönlendiliyorsunuz.");
                        goto Main;
                    }
                    else if (islem == 4)
                    {
                        Console.WriteLine("Lütfen Kartınızı Alınız...");
                    }
                    else
                    {
                        Console.WriteLine("İşlemlerde Geçerli Olan Değerlerden Birini Giriniz... \n");
                    }
                    Console.ReadLine();
                }

                catch //(Exception ex)
                {
                    Console.WriteLine("İşlemlerde Geçerli Olan Değerlerden Birini Giriniz... \n");
                    goto Main1;
                }
            }


        }

        static double ParaCekme(ref double bakiye, double cekilenTutar)
        {
            if (bakiye < cekilenTutar || cekilenTutar > 2500.0)
            {
                Console.WriteLine("Bakiyeniz Yetersiz ya da 2500 TL den fazla çekmeye çalışıyorsunuz...");
            }
            else if (bakiye > cekilenTutar)
            {
                bakiye = bakiye - cekilenTutar;
                Console.WriteLine("Yeni Bakiyeniz :" + bakiye + "\n" + "Para Çekme İşleminiz Başarılı... \nAna Menüye Yönlendiriliyorsunuz...");

            }
            return bakiye;
        }

        static void ParaYatırma(ref double bakiye, double yatirilanTutar)
        {
            if (yatirilanTutar > 9999.9)
            {
                Console.WriteLine("10.000 TL'Den Fazla Yatırmaya Çalışıyorsunuz... \n Lütfen Daha Düşük Bir Miktar Yatırınız...");
            }
            else
            {
                bakiye = bakiye + yatirilanTutar;
                Console.WriteLine("Yeni Bakiyeniz :" + bakiye + "\n" + "Para Yatırma İşleminiz Başarılı... \nAna Menüye Yönlendiriliyorsunuz...");
            }
        }

    }


}
