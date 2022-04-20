namespace Interpreter
{
    public class UnidadeExpressao : Expressao
    {
        public override string One()
        {
            return "I";
        }

        public override string For()
        {
            return "IV";
        }

        public override string Five()
        {
            return "V";
        }

        public override string Nine()
        {
            return "IX";
        }

        public override int Multiplicar()
        {
            return 1;
        }
    }
}
