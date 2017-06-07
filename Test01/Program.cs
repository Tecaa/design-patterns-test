using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test01Lib;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = CalculatorFactory.CreateCalculator(Lifeware.GetType());

            Console.WriteLine(c.Name);
            Console.WriteLine(c.Add(5, 5));
            Console.WriteLine(c.Subtract(5, 5));
            Console.WriteLine(c.Fibonacci(5));
            Console.WriteLine(c.PiN(5));
            Console.ReadKey();
        }
    }
}
