using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    class PcRepairman : EmployedDecorator
    {
        Employed employed;
        public PcRepairman(Employed emp)
        {
            this.employed = emp;
            this.JobTime = 1;
        }
        public override string GetJobExplanation()
        {
            return employed.GetJobExplanation() + " Formatea y habilita computadores.";
        }

        public override int GetJobTime()
        {
            return employed.GetJobTime() + this.JobTime;
        }
    }
}