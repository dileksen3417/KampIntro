using System;
using System.Collections.Generic; // List(collection) kullanımı için eklenen kütüphane

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi
            string[] names = new string[] {"engin", "dilek", "altugum", "gunom" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            // names[4] = "ilker"; OutOfArrayRange hatası alırız! 

            //**********KOLEKSİYONLAR***********
            // Koleksiyon 1. Yol:
            //List<string> isimler2 = new List<string>();
            //isimler2.Add("Umut");

            // Koleksiyon 2. Yol:
            List<string> isimler3 = new List<string> { "Engin", "Dilek", "Altugum", "Gunom" };
            Console.WriteLine(isimler3[0]);
            Console.WriteLine(isimler3[1]);
            Console.WriteLine(isimler3[2]);
            Console.WriteLine(isimler3[3]);
            isimler3.Add("Güneş");
            Console.WriteLine(isimler3[4]);
            Console.WriteLine(isimler3[0]);
        }
    }
}
