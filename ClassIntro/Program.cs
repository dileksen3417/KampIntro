using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            string adi = "Engin";
            int yas = 36;

            //
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmeni = "Dilek Şen";
            kurs2.IzlenmeOrani = 99;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursEgitmeni = "Murat Sen";
            kurs3.IzlenmeOrani = 90;

            Console.WriteLine("Statik yazdırma:");
            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursEgitmeni);
            Console.WriteLine("*******************************************");

            Console.WriteLine("Dinamik yazdırma:");
            //tıpkı string bir dizi yarattıgımız gibi içinde kurs nesnesini barındıran bir Kurs nesnesi tanımlayalım:

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs k in kurslar) //Kurs yerine var ''da diyebilirz. Yani hangi veri tipindeyse oto algılayıp yazar
            {
                Console.WriteLine(k.KursAdi + " : " + k.KursEgitmeni + " - " + k.IzlenmeOrani);
            }
        }
    }

    class Kurs //kendi veri tipimizi tanımlıyoruz gibi düşün, string,int de bir classtır.
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
