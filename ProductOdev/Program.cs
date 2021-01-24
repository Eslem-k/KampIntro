using System;

namespace ProductOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            Product manav = new Product();
            manav.Meyve = "Elma";
            manav.Sebze = "Kabak";
            manav.Fiyat = 10;

            Product bakkal = new Product();
            bakkal.Meyve = "Elma";
            bakkal.Sebze = "Kabak";
            bakkal.Fiyat = 13;

            Product market = new Product();
            market.Meyve = "Elma";
            market.Sebze = "Kabak";
            market.Fiyat = 20;

            Product[] dizi = new Product[]
            {manav , bakkal , market };

            foreach (var dongu in dizi)
            {
                Console.WriteLine(dongu.Meyve);
            }

            Console.WriteLine("for each bitti");

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(market.Meyve + ":" + market.Fiyat);

            }

            Console.WriteLine("for bitti");

            int fiyat = 10;

            while (fiyat==10)
            {
                Console.WriteLine(manav.Fiyat + " : Uygun Fiyat ");
                fiyat--;
            }

            Console.WriteLine("While Bitti");

        }

        class Product
        {

            public string Meyve { get; set; }

            public string Sebze { get; set; }

            public int Fiyat { get; set; }


        }
    }
}
