using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> city = new Dictionary<int, string>();
            city.Add(34,"İstanbul");
            city.Add(62,"Dersim");

            foreach (KeyValuePair<int,string> item in city)
            {
                Console.WriteLine("Plaka:{0} - Sehir:{1}", item.Key, item.Value);
            }

        }
    }
}
