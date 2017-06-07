using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test03v2Lib;

namespace Test03v2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> lists = Lifeware.GetListOfLists();
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine("GRABACION " + i);
                ListOperations sorter = new ListOperations(lists[i]);
                List<int> top;

                sorter.SetSortStrategy(new QuickSortStrategy());
                top = sorter.GetTopN(3);
                PrintNumber(top);
                sorter.SetSortStrategy(new BubbleSortStrategy());
                top = sorter.GetTopN(3);
                PrintNumber(top);
                sorter.SetSortStrategy(new BogoSortStrategy());
                top = sorter.GetTopN(3);
                PrintNumber(top);

            }
            Console.ReadKey();
        }

        private static void PrintNumber(List<int> top)
        {
            for (int i=0; i<top.Count; ++i)
            {
                Console.WriteLine(top[i]);
            }
        }
    }
}
