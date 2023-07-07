using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_side
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Console.WriteLine("Enter first number: ");
            //int firstNumber = int.Parse(Console.ReadLine().Trim());
            //Console.WriteLine("Enter second number: ");
            //int secondNumber = int.Parse(Console.ReadLine().Trim());
            //var result = Add2(firstNumber, secondNumber);
            //Console.WriteLine(result);

            //int first = 50;
            //int second = 30;
            //var result2 = Add3(ref first);
            //Console.WriteLine(result2);
            //Console.WriteLine(first);

            Console.WriteLine(Add4(2,3,4,5,6,1));
        }

        static void Add()
        {
            Console.WriteLine("Added.");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int n1, int n2 = 5)
        {
            n1 = 2;
            return n1 + n2;
        }
        static int Add4(params int[] n) 
        {
            return n.Sum();
        }
    }
}
