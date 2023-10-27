using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_27._10._23
{
    internal class AnagramsStrings
    {
        static void Main(string[] args)
        {
            Console.Write("İlk kelimeyi giriniz: ");
            string str = Console.ReadLine();
            Console.Write("İkinci kelimeyi giriniz: ");
            string str2 = Console.ReadLine();

            
            char[] arr = str.ToCharArray();
            char[] arr2 = str2.ToCharArray();

            Array.Sort(arr);
            Array.Sort(arr2);
          
            if (IsBool(arr, arr2, str.Length))
                Console.WriteLine("Anagram bir kelime");           
            else
                Console.WriteLine("Anagram bir kelime değildir.");
            Console.ReadLine();
        }
        public static bool IsBool(char[] arr, char[] arr2, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (arr[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
// 4-How to check if two Strings are anagrams of each other?
/*aynı harflerle yazılan ama harfleri yer değiştirince ayrı anlama gelen sözcük;
 * örneğin rakı sözcüğünün harfleri yer değiştirince ortaya çıkan ırak/karı/arık sözcükleri birer anagramdır.*/