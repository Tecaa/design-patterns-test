using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    public abstract class Employed
    {
        public string Name;
        public int JobTime;
        protected string JobExplanation;

        public Employed(string name)
        {
            this.Name = name;
        }

        public int GetJobTime()
        {
            return JobTime;
        }
        public string GetJobExplanation()
        {
            return JobExplanation;
        }
    }
}