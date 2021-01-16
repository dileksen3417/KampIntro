using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"C# Dersleri(İleri Seviye)",
                "Java Dersleri(İleri Seviye)",
                "Python Dersleri(Orta seviye)"};

            //length: dizinin uzunluğu demektir
            for (int i = 0; i < kurslar.Length; i++) //2ser artırma: i+=2 veya i=i+2
            {
                Console.WriteLine(kurslar[i]);
            }


            Console.WriteLine("*******Farklı Döngü Yöntemi -->> FOREACH*********");

            //foreach : dizi temelli yapıları tek tek dolasmaya yarar bu kadar basit birşey.

            foreach (string kurs in kurslar)  //kursları dolaş //kurs: alias denir.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");

        }
    }
}
