using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class Casio : Calculator
    {
        public Casio() : base()
        {
            this.Name = "Casio";
        }

        public override float Add(float a, float b)
        {
            return a + b;
        }

        public override float Fibonacci(int n)
        {
            return 12345;
        }

        public override float PiN(int n)
        {
            return 6; //nesimo decimal de pi.
        }

        public override float Subtract(float a, float b)
        {
            return a - b;
        }
    }
}
