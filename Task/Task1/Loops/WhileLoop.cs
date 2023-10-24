using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class WhileLoop
    {
        static void Main(string[] args)
        {
            int number = 10;
            //while
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
            
            //do-while
            do 
            {
                
                Console.WriteLine(number);
                number--;

            } while(number >= 0);
            Console.ReadLine();
        }
    }
}
