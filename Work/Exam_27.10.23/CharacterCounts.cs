using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_27._10._23
{
    internal class CharacterCounts
    {
        static void Main(string[] args)
        {
            Console.Write("Kelime giriniz: ");
            string str = Console.ReadLine();
            int count;
            for (int i = 0; i < str.Length; i++)
            {
                count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i > j)
                    { 
                        break;
                    }
                    if (str[i] == str[j])
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    Console.WriteLine($"{str[i]} : {count}");
                }
               
            }
            Console.ReadLine();

        }
    }
}
