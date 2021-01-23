using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Yanlıs soyutlama yapalım : 
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demirog";
            //musteri1.Id = 1;
            //musteri1.TcNo = "22222222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";//bu kişinin bir şirketi yok. İşte soyutlama hatası!
            ////Gerçek - Tüzel : iki tip müşteri var bankada. Gerçek: normal insan, Tüzel: Şirket olan müşteriler
            ////Sırf bu iki tip birbirine benziyor diye aynı class üzerinden tanımlanamazlar.
            /////**************************************************************//////////////

            //Doğru şekilde gerçek müşteri tanımı yapalım;
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "1234000";
            musteri1.Adi = "Dilek";
            musteri1.Soyadi = "Şen";
            musteri1.TcNo = "1111111111111";

            //Doğru şekilde tüzel müşteri tanımı yapalım;
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "5678000";
            musteri2.SirketAdi = "HepsiJET";
            musteri2.VergiNo = "200-00000111";

            //Inheritance'ın asıl özelliği base sınıfın onu inherit eden alt sınıflarının 
            //referans numaralarını tutabilmesidir;
            //Yani ben Manager classıma her alt class için ayrı method yzmak yerine parametre olarak
            //Musteri tipli bir nesne isterim, bu nesneye hem Gercek hem Tuzel classından yarattıgım 
            //nesneyi yollayarak kod tekrarından kurtulmuş olurum.

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            //Inheritance sayesinde ister Gercek'ten ister Tuzel'den yarattıgım musterileri tip sorununa takılmadan
            //operasyon methodlarıma yollayabilirim.


        }
    }
}
