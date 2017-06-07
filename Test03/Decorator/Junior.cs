using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    class Junior : EmployedDecorator
    {
        Employed employed;
        public Junior(Employed emp)
        {
            this.employed = emp;
            this.JobTime = 1;
        }
        public override string GetJobExplanation()
        {
            return employed.GetJobExplanation() + " Realiza las compras.";
        }

        public override int GetJobTime()
        {
            return employed.GetJobTime() + this.JobTime;
        }
    }
}
