using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> customer = new MyDictionary<int, string>();
            customer.Add(1, "Dilek Şen");
            customer.Add(1, "Dilek Şen");
            customer.Add(2, "Güney Şen");
        }
    }
}
