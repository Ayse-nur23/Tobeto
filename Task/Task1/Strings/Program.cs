using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Engin Demiroğ";

            var result = sentence.Length; //string uzunluğu
            Console.WriteLine("Result: {0}", result);

            var result2 = sentence.Clone(); //string kopyası oluşturur. farkllı bir değişken oluşur.
            sentence = "My name is Engin"; //yeni referans oluştuğu için değişmez.
            Console.WriteLine("Result2: {0}", result2);

            bool result3 = sentence.EndsWith("ğ"); // kelimenin sonuna bakar.
            Console.WriteLine("Result3: {0}", result3);

            bool result4 = sentence.StartsWith("My name"); // kelimenin başına bakar.
            Console.WriteLine("Result4: {0}", result4);

            var result5 = sentence.IndexOf("name"); //arama yaparak değerin konumunu verir, yoksa -1 döndürür, bulduğu ilk değeri döndürür.
            Console.WriteLine("Result5: {0}", result5);

            var result6 = sentence.LastIndexOf("name"); //sondan başlayarak arama yapar, konumunu verir.
            Console.WriteLine("Result5: {0}", result6);

            var result7 = sentence.Insert(0, "Hello, "); //kelime, harf ekler
            Console.WriteLine("Result7: {0}", result7);

            var result8 = sentence.Substring(3, 4); //metinden parça alır
            Console.WriteLine("Result8: {0}", result8);

            var result9 = sentence.ToLower(); //Karakterleri küçük harfe çevirir.
            Console.WriteLine("Result9: {0}", result9);

            var result10 = sentence.ToUpper(); //Karakterleri küçük harfe çevirir.
            Console.WriteLine("Result10: {0}", result10);

            var result11 = sentence.Replace(" ", "-"); //Metindeki karakterleri değiştirir.
            Console.WriteLine("Result11: {0}", result11);


            var result12 = sentence.Remove(2, 4); //Girilen indes sonrasını siler.
            Console.WriteLine("Result12: {0}", result12);

            Console.ReadLine();
        }

        private static void Intro()
        {
            //string char arraydir
            string city = "Ankara";

            Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            /*string result = city + city2;
            Console.WriteLine(result);*/
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
