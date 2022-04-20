using System;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : Componente
    {
        private List<Componente> filhos = new List<Componente>();

        public Composite(string nome) : base(nome)
        {
        }

        public override void Adicionar(Componente componente)
        {
            this.filhos.Add(componente);
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new String('-', profundidade) + nome);

            foreach(Componente item in this.filhos)
            {
                item.Mostrar(profundidade + 2);
            }
        }

        public override void Remover(Componente componente)
        {
            this.filhos.Remove(componente);
        }
    }
}
