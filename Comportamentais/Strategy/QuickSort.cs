﻿using System;
using System.Collections.Generic;

namespace Strategy
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("Quick Sorted list");
        }
    }
}
