using System;

namespace TemplateMethod
{
    public class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperationalOne()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperationalOne");
        }

        public override void PrimitiveOperationalTwo()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperationalTwo");
        }
    }
}
