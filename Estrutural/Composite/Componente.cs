using System;

namespace Composite
{
    public abstract class Componente
    {
        protected string nome;

        public Componente(string nome)
        {
            this.nome = nome;
        }

        public abstract void Adicionar(Componente componente);
        public abstract void Remover(Componente componente);
        public abstract void Mostrar(int profundidade);
    }
}
