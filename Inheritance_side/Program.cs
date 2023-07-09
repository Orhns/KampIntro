using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_side
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //customer.FirstName = "Test";
            //customer.City = "Test";
            //Student student = new Student();
            //student.Department = "Test";
            Person[] persons = new Person[3]
            {
                new Customer{FirstName = "Engin"},
                new Student{FirstName = "Derin"},
                new Person{FirstName = "Orhun"}
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
    class Person2
    {

    }

    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
