using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void ListCustomer(Customer customer)
        {
            Console.WriteLine("Customer Listed!");
            Console.WriteLine("Id: " + customer.Id);
            Console.WriteLine("Name: " + customer.Name);
            Console.WriteLine("Surname: " + customer.Surname);
            Console.WriteLine("---------------");
        }

        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Customer Added!");
            Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname);
            Console.WriteLine("---------------");
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Customer Deleted!");
            Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname);
            Console.WriteLine("---------------");
        }
    }
}
