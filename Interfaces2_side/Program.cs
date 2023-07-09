using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2_side
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customer1 = new CustomerManager();
            //customer1.Add();
            EmployeeManager employee1 = new EmployeeManager();
            //employee1.Add();

            ProjectManager projectManager = new ProjectManager();
            //projectManager.Add(customer1);
            projectManager.Add(new InternManager());

        }
    }

    interface IPersonManager
    {
        //Unimplemented operation
        void Add();
        void Update();

        //implemented operation
        //public void Add()
        //{
        //    Console.WriteLine("Eklendi");
        //}
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Employee güncellendi");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer updated.");
        }
    }
}
