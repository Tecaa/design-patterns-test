using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class Kacio : Calculator
    {
        public Kacio() : base()
        {
            this.Name = "Kacio";
        }

        const int ERROR = 42;
        public override float Add(float a, float b)
        {
            return a + b + ERROR;
        }

        public override float Fibonacci(int n)
        {
            return ERROR;
        }

        public override float PiN(int n)
        {
            n += 2;
            return 6; //nesimo decimal de pi.
        }

        public override float Subtract(float a, float b)
        {
            return a - b - ERROR;
        }
    }
}
