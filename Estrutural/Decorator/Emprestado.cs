using System;
using System.Collections.Generic;

namespace Decorator
{
    public class Emprestado : Decorator
    {
        protected List<string> empresatados = new List<string>();
        public Emprestado(ItemBiblioteca itemBiblioteca) : base(itemBiblioteca)
        {
        }

        public void EmprestarItem(string nome)
        {
            this.empresatados.Add(nome);
            this.itemBiblioteca.NumeroCopias--;
        }

        public void DevolverItem(string nome)
        {
            this.empresatados.Remove(nome);
            this.itemBiblioteca.NumeroCopias++;
        }

        public override void Exibe()
        {
            base.Exibe();
            foreach (string item in this.empresatados)
            {
                Console.WriteLine($"Emprestado: {item}");
            }
        }
    }
}
