using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_27._10._23
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            //int result = Fibo(10);
            for (int i = 1; i <= 100; i++)
            {
                int result = Fibo(i);

                Console.WriteLine("{0}.) {1}",i, result);

                //if(result<100)
                //{

                //Console.WriteLine(result);
                //}
                //else
                //{
                //    break;
                //}

            }
            //Console.WriteLine(result);
            Console.ReadLine();
        }
        static public int Fibo(int n)
        {
            int total = 0;

            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            //Console.WriteLine((Fibo(n - 1) + Fibo(n - 2)));

            return (Fibo(n - 1) + Fibo(n - 2));
        }

    }
}




//Write a C# function to print first 100 numbers in Fibonacci series?
/* long a;
            long b = 1;
            long total = 0;

            for (int i = 1; i < 101; i++)
            {
                a = b;
                b = total;
                total = a + b;

                Console.WriteLine($"{i}.) {total}")
            }
*/