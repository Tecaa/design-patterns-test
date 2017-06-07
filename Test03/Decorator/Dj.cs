using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03.Decorator
{
    class Dj : EmployedDecorator
    {
        Employed employed;
        public Dj(Employed emp)
        {
            this.employed = emp;
            this.JobTime = 1;
        }
        public override string GetJobExplanation()
        {
            return employed.GetJobExplanation() + " Encargado de seleccionar la música de la oficina.";
        }

        public override int GetJobTime()
        {
            return employed.GetJobTime() + this.JobTime;
        }
    }
}
