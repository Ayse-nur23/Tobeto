﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayısalLoto_25._10._23
{
    internal class Loto
    {
        /*static void Main(string[] args)
        {
            int columnCount;
            Console.Write("Kolon sayısı Giriniz: ");
            columnCount = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[6];
            int sayi;
            Random random = new Random();

            if (!(columnCount > 0 && columnCount < 9))
            {
                Console.WriteLine("Hata");
                return;
            }

            for (int i = 1; i <= columnCount; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    sayi = random.Next(1, 50);
                    array[j] = sayi;
                }
                for (int k = 0; k < 6; k++)
                {
                    for (int m = 0; m < 6; m++)
                    {
                        if (k != m && array[k] == array[m])
                        {
                            sayi = random.Next(1, 50);
                            array[m] = sayi;
                        }
                    }
                }

                for (global::System.Int32 l = 0; l < 6; l++)
                {
                    Console.Write("{0}, ", array[l]);
                }
                Console.WriteLine();
            }
        }*/

        //Discord Kodu
        static void Main(string[] args)
        {
            int kolonSayisi;
            Console.Write("Kolon Sayisi Giriniz...");
            kolonSayisi = int.Parse(Console.ReadLine()); // Kullanıcıdan bir kolon sayısı alıyoruz.

            int[] column = new int[6]; // 
            if (kolonSayisi > 0 && kolonSayisi <= 8) // Kullanıcıdan aldığımız veriyi kontrol ediyoruz.
            {
                Random rnd = new Random(); // Random sınıfı oluşturuyoruz.
                for (int i = 0; i < kolonSayisi; i++) // Kolon sayısı kadar çeviriyoruz.
                {
                    for (int j = 0; j < column.Length; j++)// Column uzunluğu kadar çeviriyoruz ve random sayı üretiyoruz.
                    {
                        int number = rnd.Next(1, 49); // 1-49 arası bir sayı üretiliyor.
                        while (column.Contains(number)) // Üretilen sayı column'da kontrol ediliyor. Aynı sayı gelmesini önlüyor.
                        {
                            number = rnd.Next(1, 49); // Yeni bir sayı tekrardan üretiliyor.
                            if (!column.Contains(number))
                            {
                                break;
                            }
                        }
                        column[j] = number;
                    }
                    Console.Write((i + 1) + ". column: ");
                    foreach (int k in column)
                    {
                        Console.Write(k + ",");

                    }
                    Console.WriteLine();
                    Console.WriteLine("--------");
                }

            }
            else
            {
                Console.WriteLine("Lütfen 1 ile 8 arasında bir değer giriniz..!");
            }
        }
    }

}