using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03v2
{
    class BubbleSortStrategy : Strategy
    {

        public override List<int> Sort(List<int> numbers)
        {
            Console.WriteLine("Dooing bubblesort");
            return numbers;
        }
    }
}
