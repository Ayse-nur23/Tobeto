using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("******************");

            //tekli sayılar
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("******************");

            for (int i = 100; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");

            Console.ReadLine();
        }
    }
}
