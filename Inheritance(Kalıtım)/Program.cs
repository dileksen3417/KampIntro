using System;

namespace Inheritance_Kalıtım_
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Student{FirstName="Dilek" },
                new Customer{FirstName="Altuğ"},
                new Person{FirstName="Güneş" } //interfaceden farkı
            };

            foreach (Person person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Student : Person
    {
        public string SchoolNumber { get; set; }
    }

    class Customer : Person
    {
        public string CustomerNumber { get; set; }
    }
}
