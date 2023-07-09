using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_side
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Add();
            customerManager1.Update();

            ProductManager productManager1 = new ProductManager();
            productManager1.Add();
            productManager1.Update();

            Customer customer1 = new Customer();
            customer1.FirstName = "Orhun";
            customer1.LastName = "kırka";
            customer1.City = "IST";
            customer1.Id = 1;

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "Ankara",
                FirstName = "Engin",
                LastName =  "Demirog"
            };

            Console.WriteLine(customer2.FirstName);
        }
    }
}
