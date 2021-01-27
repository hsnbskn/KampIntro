using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hasan Baskın - 3.Gun Odevi");
            Console.WriteLine("--------------------------");


            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Hasan";
            customer1.Lastname = "Baskin";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Altar";
            customer2.Lastname = "Tunga";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Cengiz";
            customer3.Lastname = "Has";


            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            //Customer add
            customerManager.Add(customer1);

            //Customer delete
            customerManager.Delete(customer2);

            //Customers list
            customerManager.List(customers);





        }
    }
}
