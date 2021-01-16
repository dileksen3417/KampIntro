using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        //Classların kullanım şekli;
        // 2. Manager : bu classlar bir operasyon tutuyor demektir.

        //doğru olan encapsulation'li method kullanımı:
        public void Ekle(Product products)//methoda Product tipinde bir parametre yolluyorum
        {
            Console.WriteLine( products.Adi + " ürününüz sepete eklenmiştir.");
        }

        //yanlıs methos kullanımı
        public void Ekle2(string urunAdi, string urunAciklamasi, double fiyati, int stok)
        {
            Console.WriteLine("Sepete eklenen ürün: " + urunAdi + " Son kalan ürün adedi: " + stok);
        }
    }
}
