using System;

namespace Builder
{
    public class Celular
    {
        public string Nome { get; set; }
        public string Tela { get; set; }
        public string Bateria { get; set; }
        public string Sistema { get; set; }
        public string Camera { get; set; }

        public Celular(String nome)
        {
            this.Nome = nome;
        }
    }
}
