using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "YAZILIM";
            kurs1.egitmen = "ESLEM";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "DONANIM";
            kurs2.egitmen = "MESUT";
            kurs2.izlenmeOrani = 98;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "AĞ";
            kurs3.egitmen = "FAHRİCAN";
            kurs3.izlenmeOrani = 75;

            //Console.WriteLine(kurs1.egitmen + " : " + kurs1.kursAdi);

            Kurs[] Kurslar = new Kurs[] {kurs1 , kurs2 , kurs3};

            foreach (Kurs Kurs in Kurslar)
            {
                Console.WriteLine(Kurs.kursAdi + " : " + Kurs.egitmen);
            }

        }
    }

    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
