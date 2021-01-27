using System;

namespace Interface2
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalManager manager = new PersonalManager();
            manager.Add(new Customer { Id = 1, FirstName = "Dilek", LastName = "Şen", CustomerDepartment = "Yazılım" });
            Student student = new Student
            {
                Id = 2,
                FirstName = "Güney",
                LastName = "Şen",
                StudentAddress = "Yenidoğan"
            };
            manager.Add(student);

            ///veritabanı örnegimiz ;  
            Console.WriteLine("\n\nVeritabanı İşlemleri:" + "\n*****************");
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new MySqlCustomerDal());
            customerManager.Add(new OracleCustomerDal());
            // her iki databse ile de ekleme işlemini yapabilirim.

            //Polimorfizm(çok biçimlilik)
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new MySqlCustomerDal(),
                new OracleCustomerDal(),
                new MangoDBCustomerDal()
            };

            foreach (ICustomerDal customerDal in customerDals)
            {
                customerDal.Add();
            }
        }
    }

    interface IPerson{
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentAddress { get; set; }
    }

    class Customer: IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CustomerDepartment { get; set; }
    }

    class PersonalManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName + " sisteme eklendi.");
            
        }
    }
}
