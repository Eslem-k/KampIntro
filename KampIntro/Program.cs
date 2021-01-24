using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "KATEGORİ";
            Console.WriteLine(kategoriEtiketi);

            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;

            bool sistemeGiris = true;

            if (sistemeGiris == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }

            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış");
            }
            else
            {
                Console.WriteLine("Eşit");
            }

        }
    }
}
