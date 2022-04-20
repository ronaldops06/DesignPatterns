using System;

namespace Singleton
{
    public sealed class Bola
    {
        private static Bola instance = null;

        public static Bola GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Bola();

                return instance;
            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
