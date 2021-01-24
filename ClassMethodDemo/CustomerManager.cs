using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Listing(Customer[] custs)
        {
            foreach (Customer x in custs)
            {
                Console.WriteLine("Id: " + x.Id);
                Console.WriteLine("Name: " + x.Name);
                Console.WriteLine("Surname: " + x.Surname);
                Console.WriteLine("Phone Number: " + x.PhoneNumber);
                Console.WriteLine("\n");

            }
        }

        public void AddCustomer(params Customer[] custs)
        {
            for (int i = 0; i < custs.Length; i++)
            {
                Console.WriteLine(custs[i].Name + " " + custs[i].Surname + " added.");
            }
            Console.WriteLine("\n");
        }

        public void DeleteCustomer(Customer cust)
        {
            Console.WriteLine(cust.Name + " " + cust.Surname + " deleted.");
        }
    }
}
