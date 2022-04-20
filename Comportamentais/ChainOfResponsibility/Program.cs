using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler hOne = new ConcreteHandlerOne();
            Handler hTow = new ConcreteHandlerTwo();
            Handler hThree = new ConcreteHandlerThree();

            hOne.SetSucessor(hTow);
            hTow.SetSucessor(hThree);

            int[] requests = { 2, 5, 24, 22, 18, 3, 27, 20 };

            foreach ( int request in requests)
            {
                hOne.HandleRequest(request);
            }

            Console.ReadKey();
        }
    }
}
