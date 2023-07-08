using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Orhun";
            person1.Surname = "K";
            person1.Id = 1;

            Person person2 = new Person();
            person2.Name = "Kübra";


            Identity identity2 = new Identity();
            identity2.TcNumber = 2222222;
            identity2.City = "Tekirdağ";

            ((Identity)person2).City = "Istanbul";
            Console.WriteLine(person2.Name + ((Identity)person2).City);

            //Console.WriteLine(((Identity)person2).City);
            //Console.WriteLine(((Identity)person2).TcNumber);

            //PersonManager personManager1 = new PersonManager();
            //personManager1.Add(identity2);

            //PersonManager personManager = new PersonManager();
            //personManager.Add(identity2);
            //personManager.Add(person3);
        }

        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
        }
        class Identity : Person
        {
            public int TcNumber { get; set; }
            public string City { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
