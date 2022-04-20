using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate ag = new ConcreteAggregate();
            ag[0] = "Item A";
            ag[1] = "Item B";
            ag[2] = "Item C";
            ag[3] = "Item D";

            Iterator it = ag.CreateIterator();
            Console.WriteLine("Iteragindo coleção");

            object item = it.First();

            while(item != null)
            {
                Console.WriteLine(item);
                item = it.Next();
            }

            Console.ReadKey();
        }
    }
}
