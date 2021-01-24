using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // FOR DÖNGÜSÜ

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------");

            //DİZİLER - ARRAY
                        
            string[] kurslar = new string[] { "YAZILIM", "DONANIM", "AĞ" , "WEB TASARIM" , "-----------"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");




        }



    }
}


