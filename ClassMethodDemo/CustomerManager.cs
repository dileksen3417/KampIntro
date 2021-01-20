using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public void CustomerAdd()
        {
            Console.WriteLine("Müşteriler eklendi.");
        }
        public void CustomerList(Customer[] customers)
        {
            Console.WriteLine("------Müşteri Listesi:-------");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(
                    "\nHesap Numarası : " + customer.AccountNumber +
                    "\nMüşteri Adı: " + customer.CustomerName +
                    "\nMüşteri Soyadı: " + customer.CustomerSurname +
                    "\nMüşteri Adresi: " + customer.CustomerAddress + 
                    "\nMüşteri Telefonu: " + customer.CustomerPhone);
            }
        }
        public void CustomerDelete()
        {
            Console.WriteLine("Müşteriler silindi.");
        }
    }
}
