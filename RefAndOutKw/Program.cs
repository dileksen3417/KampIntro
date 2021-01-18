using System;

namespace RefAndOutKw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Ref Kullanımı:***********");
            int x = 10;
            int y = 15;
            Console.WriteLine("Ref kullanımından önce x değeri: " + x);
            Add(ref x, y);
            Console.WriteLine("Ref kullanımından sonra x değeri: " + x);

            Console.WriteLine("\n**********Out Kullanımı:***********");
            int a;
            int b = 200;
            Console.WriteLine("Ref kullanımından önce a değeri: ");
            Add2(out a, b);
            Console.WriteLine("Ref kullanımından sonra a değeri: " + a);
        }

        static int Add(ref int x, int y)
        {
            x = 30;
            return x + y;
        }

        static int Add2(out int a, int b)
        {
            a = 50;
            return a + b;
        }

    }
}
