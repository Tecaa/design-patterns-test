using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    public abstract class EmployedDecorator : Employed
    {
        public abstract new int GetJobTime();
        public abstract new string GetJobExplanation();
    }
}
