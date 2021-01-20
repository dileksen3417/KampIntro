using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.AccountNumber = "001116262";
            customer1.CustomerName = "Dilek";
            customer1.CustomerSurname = "Sen";
            customer1.CustomerAddress = "Cekmeköy";
            customer1.CustomerPhone = "5301112262";

            Customer customer2 = new Customer();
            customer2.AccountNumber = "009996262_1";
            customer2.CustomerName = "Guney";
            customer2.CustomerSurname = "Sen";
            customer2.CustomerAddress = "Yenidogan";
            customer2.CustomerPhone = "5498862462";

            Customer customer3 = new Customer();
            customer3.AccountNumber = "0001115555";
            customer3.CustomerName = "Altug";
            customer3.CustomerSurname = "Atmaca";
            customer3.CustomerAddress = "Pendik";
            customer3.CustomerPhone = "5070446255";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager cm = new CustomerManager();
            
            Console.WriteLine("Müşteri sistemine hoşgeldiniz!\n" +
                "Müşteri eklemek için 1'i,\n" +
                "Müşteri listesine ulaşmak için 2'yi\n" +
                "Müşteri silmek için 3'ü tuşlayınız.\n");
            int secim = int.Parse(Console.ReadLine());

            if (secim==1)
            {
                Customer customerNew = new Customer();
                Console.WriteLine("Müşteri hesap numarasını giriniz: ");
                customerNew.AccountNumber= Console.ReadLine();

                Console.WriteLine("Müşteri adını giriniz: ");
                customerNew.CustomerName = Console.ReadLine();

                Console.WriteLine("Müşteri soyadını giriniz: ");
                customerNew.CustomerSurname = Console.ReadLine();

                Console.WriteLine("Müşteri adresini giriniz: ");
                customerNew.CustomerAddress = Console.ReadLine();

                Console.WriteLine("Müşteri telefon numarasını giriniz: ");
                customerNew.CustomerPhone = Console.ReadLine();

                cm.CustomerAdd();
            }
            else if (secim==2)
            {
                cm.CustomerList(customers);
            }
            else if (secim==3)
            {
                cm.CustomerDelete();
            }
            else
            {
                Console.WriteLine("Hatalı bir seçim yaptınız!");
            }
        }
    }
}
