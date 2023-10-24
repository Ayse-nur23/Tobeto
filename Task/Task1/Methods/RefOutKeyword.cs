using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class RefOutKeyword
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 300;

            var result = Add(number1, number2);
            Console.WriteLine("Add methods: {0}", result);
            Console.WriteLine("Number1 is {0}", number1);

            var result2 = Add2(ref number1, number2);
            Console.WriteLine("Add3 methods: {0}", result2);
            Console.WriteLine("Number1 is {0}", number1);

            int number3;
            int number4 = 30;

            var result3 = Add3(out number3, number4);
            Console.WriteLine("Add3 methods: {0}", result3);
            Console.WriteLine("Number3 is {0}", number3);

            Console.ReadLine();
        }

        static int Add(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //ref: değişkeni referans tip gibi çalıştırır.
        static int Add2(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //out: ref benzer ama ilk değeri verilmez.
        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}
