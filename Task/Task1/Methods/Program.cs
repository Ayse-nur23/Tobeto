using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result2 = Add2(10, 21);
            Console.WriteLine("Add2 methods: {0}", result2);

            int result3 = Add3(21);
            Console.WriteLine("Add3 methods: {0}", result3);

            int number1 = 20;
            int number2 = 300;
            var result4 = Add4(ref number1, number2);
            Console.WriteLine("Add3 methods: { 0}", result4);
            Console.WriteLine("Number1 is {0}", number1);

            Console.ReadLine();
        }

        // void:değer döndürmeyen metot 
        static void Add()
        {
            Console.WriteLine("Added!");
        }

        // int değer döndüren metot
        static int Add2(int num1, int num2)
        {
            return num1 + num2;
        }

        //default parametre: değişkene değer gelmezse parametrede verilen değeri alır.
        static int Add3(int num1, int num2 = 30)
        {
            return num1 + num2;
        }

        //ref: değişkeni referans tip gibi çalıştırır
        static int Add4(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //out: değişkeni referans tip gibi çalıştırır
        static int Add5(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}
