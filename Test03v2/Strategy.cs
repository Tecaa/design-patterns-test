using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03v2
{
    public abstract class Strategy
    {
        public abstract List<int> Sort(List<int> numbers);
    }
}