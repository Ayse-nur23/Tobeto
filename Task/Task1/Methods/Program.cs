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

            Console.WriteLine(Multiply(22,4));
            Console.WriteLine(Multiply2(22, 4, 5));

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

        //default parametre: değişkene değer gelmezse parametrede verilen değeri alır. Parametrenin en sonuna tanımlanır.
        static int Add3(int num1, int num2 = 30)
        {
            return num1 + num2;
        }

        
        static int Multiply(int number1, int number2)
        {
            return number1 + number2;
        }
        static int Multiply2(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }
    }
}
