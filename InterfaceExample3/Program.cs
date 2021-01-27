using System;

namespace InterfaceExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IWorker için tüm çalışanlarıma çalışma emri veriyorum:
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            //IEat interfaceini impl eden tüm çalışanlarım için yemek yeme izni veriyorum:
            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            //bu işlemi robotlar için yapamam çünkü onlar IEAT interfaceinden türemediler böyle bir opsiyonları yok.

        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISallary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISallary
    {
        public void Eat()
        {
            Console.WriteLine("Manager yemegini yedi.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager maaşını aldı.");
        }

        public void Work()
        {
            Console.WriteLine("Manager çalıştı.");
        }
    }

    class Worker : IWorker, ISallary, IEat
    {
        public void Eat()
        {
            Console.WriteLine("Worker yemegini yedi.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker maaşını aldı.");
        }

        public void Work()
        {
            Console.WriteLine("Worker çalıştı.");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot çalıştı.");
        }
    }
}
