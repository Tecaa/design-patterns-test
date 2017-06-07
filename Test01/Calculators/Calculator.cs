using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    public abstract class Calculator
    {
        
        public string Name { get; protected set; }

        
        public abstract float Add(float a, float b);

        public abstract float Subtract(float a, float b);

        public abstract float PiN(int n);

        public abstract float Fibonacci(int n);

    }
}