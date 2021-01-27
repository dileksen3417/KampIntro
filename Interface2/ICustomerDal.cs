using System;
using System.Collections.Generic;
using System.Text;

namespace Interface2
{
    interface ICustomerDal
    {
        void Add();
        void Delete();
        void Update();
    }

    public class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql added.");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Mysql updated.");
        }
    }

    public class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added.");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated.");
        }
    }

    public class MangoDBCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MangoDB added.");
        }

        public void Delete()
        {
            Console.WriteLine("MangoDB deleted.");
        }

        public void Update()
        {
            Console.WriteLine("MangoDB updated.");
        }
    }

    class CustomerManager{
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }

    }

}
