﻿using System;

namespace GenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            isimler.Add("Engin");
            isimler.Add("Engin");
            isimler.Add("Engin");
            isimler.Add("Engin");
            Console.WriteLine(isimler.Count);
            
        }
    }
}
