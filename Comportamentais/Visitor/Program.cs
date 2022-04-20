using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStruture oe = new ObjectStruture();
            oe.Anexar(new ConcreteElementA());
            oe.Anexar(new ConcreteElementB());

            ConcreteVisitorOne vOne = new ConcreteVisitorOne();
            ConcreteVisitorTwo vTwo = new ConcreteVisitorTwo();

            oe.Accept(vOne);
            oe.Accept(vTwo);

            Console.ReadKey();
        }
    }
}
