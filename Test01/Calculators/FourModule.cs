using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class FourModule : Calculator
    {
        const int MOD = 4;
        public FourModule() : base()
        {
            this.Name = "FourModule";
        }

        public override float Add(float a, float b)
        {
            a %= MOD;
            b %= MOD;
            return (a + b ) % MOD;
        }

        public override float Fibonacci(int n)
        {
            n %= MOD;
            return 12345 % MOD;
        }

        public override float PiN(int n)
        {
            n %= 4;
            return 6 % 4; //n-esimo decimal de pi.
        }

        public override float Subtract(float a, float b)
        {
            a %= MOD;
            b %= MOD;
            return (a - b) % MOD;
        }
    }
}

