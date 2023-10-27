using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1-Write a C# program to check if the entered number is Armstrong number? 
 * 2-Write a C# function to print first 100 numbers in Fibonacci series? 
 * 3-Write a C# program gives character counts in a string Ex: Tobeto -> t:2, o:2, b:1, e:1 
 * 4-How to check if two Strings are anagrams of each other? 
 * 5-How to determine if the string has all unique characters. 
 * 6-Write a C# program finds first two amicable pairs. (Output: 1-> 220-284 2: 1184-1210) 
 * 7-Write a C# program finds first 10 perfect numbers.*/
namespace Exam_27._10._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz.");
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            int total = 0;
            int stepNumber = number.ToString().Length;//basamak sayısını verir.

            while (temp > 0)
            {
                total += (int)Math.Pow((temp % 10), stepNumber);
                temp /= 10;
            }
            if (total == number)
                Console.WriteLine($"{number} bir Armstrong sayısıdır.");
            else 
                Console.WriteLine($"{number} bir Armstrong sayısı değildir.");

            Console.ReadLine();
        }
    }
}
//Write a C# program to check if the entered number is Armstrong number?
/* N haneli bir sayının basamaklarının n'inci üstlerinin toplamı, sayının kendisine eşitse, böyle sayılara Armstrong sayı denir.
 * Örneğin 407 sayısını ele alalım. (4^3)+ (0^3)+(7^3) = 64+0+343 = 407 sonucunu verir. */