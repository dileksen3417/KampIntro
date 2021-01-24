using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer{Id = 1, FirstName = "Engin", LastName="Demirog", City="Ankara"};
            Customer customer3 = new Customer();
            customer3.FirstName = "Altuğ";
            //bu iki yöntem birbiriyle aynı iken asla alttaki yöntemle aynı değildir. Alttaki parametreli kullanımdır.
            //Üstteki ilk default constructor çağırırken alttaki method gibi olan constructırı çağırır.
            Customer customer2 = new Customer(2,"Dilek","Şen","İstanbul");
        }
    }

    class Customer
    {
        public Customer()//constructor
        {

        }
        public Customer(int id, string fitstName, string lastName, string city)//constructor
        {
            Id = id;
            FirstName = fitstName ;
            LastName = lastName;
            City = city;
            Console.WriteLine("Yapıcı blok calıstı");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
