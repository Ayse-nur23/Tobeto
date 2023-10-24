using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types

            //byte 1bayt = 8 bit [0 to 255	]
            byte numByte = 8;
            Console.WriteLine("numByte is {0}", numByte);
          

            //short 16bit(int16) [-32,768 to 32,767]
            short numShort = 16;
            Console.WriteLine("numShort is {0}", numShort);
            
            //int 32bit(int32) [-2,147,483,648 to 2,147,483,647]
            int numInt = 32;
            Console.WriteLine("NumInt is {0}", numInt);
           

            //long 64bit(int64) [-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807]
            long numLong = 64;
            Console.WriteLine("NumLong is {0}", numLong);


            //bool 1 byte [true or false]
            bool condition = false;
            Console.WriteLine("Condition is {0}", condition);


            //char 16 bit [a to z]
            char character = 'A';
            Console.WriteLine("Character is {0}", character);


            //float 32bit, 7 karakter hasasiyeti(virgülden sonra karakter sayısı), sonuna f gelir, [±1.5 x 10−45 to ±3.4 x 1038]
            float numFloat = 32.32f;
            Console.WriteLine("NumFloat is {0}", numFloat);

            //double (64bit),16 karakter hasasiyeti, [±5.0 × 10−324 to ±1.7 × 10308]
            double numDouble = 64.64;
            Console.WriteLine("NumDouble is {0}", numDouble);

            //decimal(128bit), karakter hasasiyeti 29, sonuna m gelir, [±1.0 x 10 - 28 to ±7.9228 x 1028]
            decimal numDecimal = 128.128m;
            Console.WriteLine("NumDecimal is {0}", numDecimal);


            //enum değişmeyecek değerleri tanımlamada kullanılır.
            Console.WriteLine(Days.Friday);

            //var Atanan değer tipini alır.
            var numVar = 54;
            Console.WriteLine("NumVar is {0}", numVar);

            Console.ReadLine();
        }
        enum Days
        {
            Monday=1,Tuesday, Wednesday,Thursday,Friday,Saturday,Sunday
        }
    }
}
