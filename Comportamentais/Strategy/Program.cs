using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList students = new SortedList();
            students.Add("Rodrigo");
            students.Add("Almir");
            students.Add("Alcemar");
            students.Add("João");
            students.Add("Genuário");

            students.SetSortStrategy(new QuickSort());
            students.Sort();

            students.SetSortStrategy(new ShellSort());
            students.Sort();

            students.SetSortStrategy(new MergeSort());
            students.Sort();

            Console.ReadKey();
        }
    }
}
