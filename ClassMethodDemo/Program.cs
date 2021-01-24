using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer();
            cust1.Id = 5;
            cust1.Name = "Glory";
            cust1.Surname = "Arik";
            cust1.PhoneNumber = "+00000";

            Customer cust2 = new Customer() { Id = 6, Name = "Gorkem", Surname = "Arik", PhoneNumber="+11111"};

            //Customer cust3 = new Customer();
            //cust3.Id = 7;
            //cust3.Name = Console.ReadLine();
            //cust3.Surname = Console.ReadLine();
            //cust3.PhoneNumber = Console.ReadLine();

            Customer[] customers = new Customer[] { cust1, cust2 };

            CustomerManager customerManager = new CustomerManager();

            //Add
            customerManager.AddCustomer(cust1, cust2);

            //Listing 
            customerManager.Listing(customers);

            //Delete
            customerManager.DeleteCustomer(cust2);   
        }
    }
}
