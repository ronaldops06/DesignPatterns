using System;

namespace Flyweight
{
    public abstract class Tartaruga
    {
        protected string  Condicao { get; set; }
        protected string Acao { get; set; }
        public string Cor { get; set; }

        public abstract void Mostra(string cor);
    }
}
