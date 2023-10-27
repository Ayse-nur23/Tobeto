internal class Program
{
    private static void Main(string[] args)
    {
    Main1:
        try
        {
            double Bakiye = 2000.0;
            double CekilenTutar;
            double YatirilanTutar;


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
            int Islem = Convert.ToInt32(Console.ReadLine());
            switch (Islem)
            {
                case 1:
                    Console.WriteLine("Para Çekme Ekranındasınız...\n" + "bakiyeniz :" + Bakiye);
                    Console.Write("Çekmek istediğiniz tutar :");
                    CekilenTutar = Convert.ToDouble(Console.ReadLine());
                    ParaCekme(Bakiye, CekilenTutar);
                    Console.ReadLine();
                    goto Main;

                case 2:
                    Console.WriteLine("Para Yatırma Ekranındasınız...\n" + "bakiyeniz :" + Bakiye);
                    Console.Write("Yatırmak istediğiniz tutar :");
                    YatirilanTutar = Convert.ToDouble(Console.ReadLine());
                    if (YatirilanTutar > 9999.9)
                    {
                        Console.WriteLine("10.000 TL'Den Fazla Yatırmaya Çalışıyorsunuz... \n Lütfen Daha Düşük Bir Miktar Yatırınız...");
                        goto Main;
                    }
                    else
                    {
                        Bakiye = Bakiye + YatirilanTutar;
                        Console.WriteLine("Yeni Bakiyeniz :" + Bakiye + "\n" + "Para Yatırma İşleminiz Başarılı... \nAna Menüye Yönlendiriliyorsunuz...");
                        goto Main;
                    }
                    break;

                case 3:
                    Console.WriteLine("Başlangıç Menüsüne Yönlendiliyorsunuz.");
                    goto Main;
                    break;

                case 4:
                    Console.WriteLine("Lütfen Kartınızı Alınız...");
                    break;

                default:
                    Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz...");
                    goto Main;
                    break;
            }


            Console.ReadLine();
        }

        catch //(Exception ex)
        {
            Console.WriteLine("İşlemlerde Geçerli Olan Değerlerden Birini Giriniz... \n");
            goto Main1;
        }


    }

    static double ParaCekme(double Bakiye, double CekilenTutar)
    {
        if (Bakiye < CekilenTutar || CekilenTutar > 2500.0)
        {
            Console.WriteLine("Bakiyeniz Yetersiz ya da 2500 TL den fazla çekmeye çalışıyorsunuz...");      
        }
        else if (Bakiye > CekilenTutar)
        {
            Bakiye = Bakiye - CekilenTutar;
            Console.WriteLine("Yeni Bakiyeniz :" + Bakiye + "\n" + "Para Çekme İşleminiz Başarılı... \nAna Menüye Yönlendiriliyorsunuz...");
            
        }
        return Bakiye;
    }

}

