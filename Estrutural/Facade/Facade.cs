using System;

namespace Facade
{
    public class Facade
    {
        public SubsistemaOne subsistemaOne;
        public SubsistemaTwo subsistemaTwo;
        public SubsistemaThree subsistemaThree;

        public Facade()
        {
            subsistemaOne = new SubsistemaOne();
            subsistemaTwo = new SubsistemaTwo();
            subsistemaThree = new SubsistemaThree();
        }

        public void MetodoA()
        {
            Console.WriteLine("\nMétodo-----------");
            this.subsistemaTwo.MetodoTwo();
            this.subsistemaThree.MetodoThree();
        }

        public void MetodoB()
        {
            Console.WriteLine("\nMétodo-----------");
            this.subsistemaOne.MetodoOne();
            this.subsistemaThree.MetodoThree();
        }
    }
}
