namespace TemplateMethod
{
    public abstract class AbstractClass
    {
        public abstract void PrimitiveOperationalOne();
        public abstract void PrimitiveOperationalTwo();

        public void TemplateMethod()
        {
            PrimitiveOperationalOne();
            PrimitiveOperationalTwo();
            System.Console.WriteLine("");
        }
    }
}
