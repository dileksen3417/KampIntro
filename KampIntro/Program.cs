using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety : tip güvenliği: yani değişkenin türünü belirtmek zorunludur
            //kategoriEtiketi bir değer tutucu, yani alias'tır.

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool loginDurumu = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;
            
            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine("********************");

            if (loginDurumu == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine("********************");

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Oklar aşağı !");
            }

            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Oklar yukarı !");
            }

            else
            {
                Console.WriteLine("Oklar sabit..."); 
            }


        }
    }
}
