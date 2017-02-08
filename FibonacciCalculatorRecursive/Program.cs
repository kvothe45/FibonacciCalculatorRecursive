using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciCalculatorRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of times you want the formula to calculate:  ");
            int upperNumber = int.Parse(Console.ReadLine());
            Fibonacci(0, 1, 1, upperNumber);
            Console.ReadLine();
        }

        public static void Fibonacci(int a, int b, int counter, int upperNumber)
        {
            Console.WriteLine(a);
            if (counter < upperNumber)
                Fibonacci(b, a + b, counter + 1, upperNumber);
        }
    }
}
