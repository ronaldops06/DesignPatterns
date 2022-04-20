using System;
using System.Collections.Generic;

namespace Strategy
{
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("Merge Sort list");
        }
    }
}
