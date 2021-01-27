using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer NewCustomer)
        {
            Console.WriteLine("[+]Customer added! => " + NewCustomer.Id + " " + NewCustomer.Name + " " + NewCustomer.Lastname);
        }

        public void Delete(Customer DelCustomer)
        {
            Console.WriteLine("[+]Customer deleted! => " + DelCustomer.Id + " " + DelCustomer.Name + " " + DelCustomer.Lastname);
        }

        public void List(Customer[] customers)
        {
            Console.WriteLine("All Customers");
            Console.WriteLine("-------------");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Lastname);
            }
        }
    }
}
