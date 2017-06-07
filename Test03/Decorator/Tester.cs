using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03.Decorator
{
    class Tester : EmployedDecorator
    {
        Employed employed;
        public Tester(Employed emp)
        {
            this.employed = emp;
            this.JobTime = 4;
        }
        public override string GetJobExplanation()
        {
            return employed.GetJobExplanation() + " Realiza pruebas de calidad de software.";
        }

        public override int GetJobTime()
        {
            return employed.GetJobTime() + this.JobTime;
        }
    }
}
