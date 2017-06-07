using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    class Chef : EmployedDecorator
    {
        Employed employed;
        public Chef(Employed emp)
        {
            this.employed = emp;
        }
        public override string GetJobExplanation()
        {
            return employed.GetJobExplanation() + " Cocinar y preparar la comida.";
        }

        public override int GetJobTime()
        {
            return employed.GetJobTime() + this.JobTime;
        }
    }
}
