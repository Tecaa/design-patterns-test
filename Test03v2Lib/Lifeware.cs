using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03v2Lib
{
    public abstract class Lifeware
    {
        private static List<List<int>> lists;
        
        static Lifeware()
        {
            lists = new List<List<int>>();
            lists.Add(new List<int>() { 4, 3, 2, 5, 1 });
            lists.Add(new List<int>() { 1, 20, 4, 2});
            lists.Add(new List<int>() { 3, 2, 55, 3, 1 });
            lists.Add(new List<int>() { 14, 3, 4, 15, 3 });
            lists.Add(new List<int>() { 94, 3, 2, 5, 6 });
            lists.Add(new List<int>() { 44, 213, 52, 1112 });
            lists.Add(new List<int>() { 424, 23, 14, 7, 34 });
            lists.Add(new List<int>() { 43, 3, 13, 77, 45 });
            lists.Add(new List<int>() { 9, 8 });
            lists.Add(new List<int>() { 10, 6, 2, 1, 0 });


        } 
        public static List<List<int>> GetListOfLists()
        {
            return lists;
        }
    }
}
