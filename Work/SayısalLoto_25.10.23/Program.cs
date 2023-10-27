using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayısalLoto_25._10._23
{
    internal class  Program
    {
        static void Main(string[] args)
        {
            int term = 10;

            // karakter dizisidir.
            string information = "İhtiyaç Kredisi";

            char firstLetter = 'A';

            Console.WriteLine(information[0]);
            Console.WriteLine(information[1]);
            Console.WriteLine(information[2]);
            Console.WriteLine(information[3]);
            Console.WriteLine(information[4]);

            double dollarToday = 27.40;
            double dollarYesterday = 27.70;

            if (dollarToday > dollarYesterday)
            {
                Console.WriteLine("UP");
            }
            else if (dollarToday < dollarYesterday)
            {
                Console.WriteLine("DOWN");
            }
            else
            {
                Console.WriteLine("EQUAL");
            }

            string button1 = "<button>Giriş Yap</button>";
            string button2 = "<button>Çıkış Yap</button>";

            bool isLoggedIn = false;
            if (isLoggedIn)
            {
                Console.WriteLine(button2);
            }
            else
            {
                Console.WriteLine(button1);
            }

            string[] courses = new string[] { "C#", "Java", "C++", "Python", "JavaScript" };

            Console.WriteLine("<ul>");
            foreach (var course in courses)
            {
                Console.WriteLine("<li>" + course + "</li>");
            }
            Console.WriteLine("</ul>");

            Console.WriteLine("/////////////////");

            Console.WriteLine("<ul>");
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine("<li>" + courses[i] + "</li>");
            }
            Console.WriteLine("</ul>");
        }
    }
}