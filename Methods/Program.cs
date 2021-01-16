using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { urun1, urun2 };

            Console.WriteLine("---------------Ürünlerimiz------------");

            foreach (Product urun in products)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("***************************");
            }

            Console.WriteLine("\n\n---------------Methodlar------------");
            //instance - örnek
            //encapsulation

            BasketManager basketManager = new BasketManager();
            basketManager.Ekle(urun1);
            basketManager.Ekle(urun2);

            //method yanlıs kullanım
            //basketManager.Ekle2("Armut","Yesil renk",16);
            // bu sekilde yazdık diyelim, daha sonra dediler ki sepete ekle methoduna birde stok ekleyelim,
            //acele al son 2 ürün yazsın. o zaman ne olacak benim gelip her satıra stok eklemem gerek.
            //halbuki direkt değişken olarak nesneyi yollasaydım nesneye ne özellik eklersem ekliyim oto 
            //methoda gidecegi için hicbir yeri değiştirmene gerek yok.
            //BUNA ENCAPSULATION denir.

            basketManager.Ekle2("Armut", "Yesil renk", 16, 3);
            //ENCAPSULATION : düzensiz olan bir seyi(yani bir üstteki kullanım) düzenli bir şekle(yani ilk nesneli
            //classlı olan kullanım) şekline getirmek. Yani bir kapsüle sokmak.
        }
    }
}
