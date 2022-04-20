using System;

namespace Decorator
{
    public class Livro : ItemBiblioteca
    {
        public string Autor { get; set; }
        public string Titulo { get; set; }

        public Livro(string autor, string titulo, int numeroCopias)
        {
            this.Autor = autor;
            this.Titulo = titulo;
            this.NumeroCopias = numeroCopias;
        }

        public override void Exibe()
        {
            Console.WriteLine("Livro --------");
            Console.WriteLine($"Autor: {this.Autor}");
            Console.WriteLine($"Título: {this.Titulo}");
            Console.WriteLine($"Número de Cópias: {this.NumeroCopias}\n");
        }
    }
}
