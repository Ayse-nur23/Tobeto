using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*indis 0 başlar, 
             * sadece tanımlandığı tipden veriler alır,
             * tanımlanan boyut kadar veri alır
             * Dizi içi boş kalmaz 
               * double:çift sıfır
                 bool: false
                 string: Null
                 int: sıfır atar*/
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students2 = { "Engin", "Derin", "Salih" };
            //string[] students2 = new [] { "Engin", "Derin", "Salih" };
            //string[] students = new string[3] { "Engin", "Derin", "Salih" };


            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("************");

            string[,] regions = new string[5, 3]
            {
                {"İstanbul", "İzmit", "Bursa" },
                {"Ankara", "Konya", "Niğde" },
                {"Antalya", "Adana", "Mersin" },
                {"Rize", "Ordu", "Samsun" },
                {"İzmir", "Muğla", "Manisa" },
            };

            /* GetUpperBound(0) : satırlara denk gelir
             * GetUpperBound(1) : sutünlara denk gelir
             *  */
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("**********");
            }
            Console.ReadLine();
        }
    }
}
