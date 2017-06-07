using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03v2
{
    public class ListOperations
    {
        private Strategy strategy;
        private List<int> list;
        
        public ListOperations(List<int> l)
        {
            this.list = l;
        }

        public void SetSortStrategy(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public List<int> GetTopN(int n)
        {
            int max = Math.Min(n, list.Count);
            return this.strategy.Sort(list).GetRange(0, max);
        }

        public List<int> GetBottomN(int n)
        {
            int max = Math.Min(n, list.Count);
            return this.strategy.Sort(list).GetRange(max-n, max);
        }
        public int GetMedian()
        {
            int max = list.Count;
            if (max % 2 == 0)
            {
                return this.strategy.Sort(list)[max / 2];
            }
            else
                return (this.strategy.Sort(list)[max / 2] + this.strategy.Sort(list)[(max / 2 )+1]) /2;
        }
        public int GetTopNMedian(int n)
        {
            //TODO
            return 99;
        }
        public int GetBottomNMedian(int n)
        {
            //TODO
            return 99;
        }
    }
}
