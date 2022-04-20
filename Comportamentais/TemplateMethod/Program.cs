using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass abstractA = new ConcreteClassA();
            abstractA.TemplateMethod();

            AbstractClass abstractB = new ConcreteClassB();
            abstractB.TemplateMethod();

            Console.ReadKey();
        }
    }
}
