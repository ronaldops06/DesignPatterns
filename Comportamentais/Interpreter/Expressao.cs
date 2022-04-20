namespace Interpreter
{
    public abstract class Expressao
    {
        public abstract string One();
        public abstract string For();
        public abstract string Five();
        public abstract string Nine();
        public abstract int Multiplicar();

        public void Interpretador(Contexto contexto)
        {
            
            if (contexto.Input.Length == 0)
                return;

            if (contexto.Input.StartsWith(Nine()))
            {
                contexto.Output += (9 * Multiplicar());
                contexto.Input = contexto.Input.Substring(2);
            }
            else if (contexto.Input.StartsWith(For()))
            {
                contexto.Output += (4 * Multiplicar());
                contexto.Input = contexto.Input.Substring(2);
            }
            else if (contexto.Input.StartsWith(Five()))
            {
                contexto.Output += (5 * Multiplicar());
                contexto.Input = contexto.Input.Substring(1);
            }
            else if (contexto.Input.StartsWith(Nine()))
            {
                contexto.Output += (9 * Multiplicar());
                contexto.Input = contexto.Input.Substring(1);
            }

            while (contexto.Input.StartsWith(One()))
            {
                contexto.Output += (1 * Multiplicar());
                contexto.Input = contexto.Input.Substring(1);
            }
        }
    }
}
