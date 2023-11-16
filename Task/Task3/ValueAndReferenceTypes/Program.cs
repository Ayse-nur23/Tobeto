using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,double,bool = değer tiplidir.
            //dizi,class,interface ,string= refersans tiplidir.
            //stack--> değer tip---yeni tip oluştur   / heap-->referans tip --yeni yer oluştur
            //101/sayilar1                             101/[10,20,30]
            //102/sayialr2                             102/[100,200,300]
            //diziye başka bir dizi atandığında dizi atatnan dizinin referans numarasını alır.
            //sayilar1 referans değeri 101 iken 102 olur  


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1=30   sayi2=65

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;//sayilar1=102 referans numarsına
            sayilar2[0] = 999;
            foreach (var say in sayilar1)
            {
                Console.WriteLine(say);
            }
            //sayilar1[0]=999
        }
    }
}
