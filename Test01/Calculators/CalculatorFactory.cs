using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test01Lib;

namespace Test01
{
    public static class CalculatorFactory
    {
        public static Calculator CreateCalculator(CalculatorType type)
        {
            switch (type)
            {
                case CalculatorType.Casio:
                    return new Casio();

                case CalculatorType.Kazio:
                    return new Kacio();
                case CalculatorType.FourModule:
                default:
                    return new FourModule();
            }
        }
    }
}