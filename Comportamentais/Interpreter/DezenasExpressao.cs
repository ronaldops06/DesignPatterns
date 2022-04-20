namespace Interpreter
{
    public class DezenasExpressao : Expressao
    {
        public override string One()
        {
            return "X";
        }

        public override string For()
        {
            return "XL";
        }

        public override string Five()
        {
            return "L";
        }

        public override string Nine()
        {
            return "XC";
        }

        public override int Multiplicar()
        {
            return 10;
        }
    }
}
