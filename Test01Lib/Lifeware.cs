using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01Lib
{
    public static class Lifeware
    {
        private static CalculatorType type;
        static Lifeware()
        {
            Random r = new Random();
            int val = r.Next(3) % 3;
            type = (CalculatorType)val;
        }
        public static new CalculatorType GetType()
        {
            return type;
        }
    }
}