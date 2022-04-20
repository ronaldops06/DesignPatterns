using System;

namespace Flyweight
{
    public class TartarugaAzul : Tartaruga
    {
        public TartarugaAzul()
        {
            this.Condicao = "tartaruga dentro do casco, ";
            this.Acao = "rodando no chão - ";
        }
        public override void Mostra(string cor)
        {
            this.Cor = cor;
            Console.WriteLine(Condicao + Acao + cor.ToUpper());
        }
    }
}
