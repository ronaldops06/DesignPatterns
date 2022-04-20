using System;

namespace TemplateMethod
{
    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperationalOne()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperationalOne");
        }

        public override void PrimitiveOperationalTwo()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperationalTwo");
        }
    }
}
