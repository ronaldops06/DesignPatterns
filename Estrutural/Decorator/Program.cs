using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar um livro
            Livro livro = new Livro("João Gonçalves", "Minhas economias", 5);
            livro.Exibe();

            // Criar um vídeo
            Video video = new Video("Maria Amaral", "Aula de costura", 15, 3);
            video.Exibe();

            Console.WriteLine("Empréstimos\n");
            // Emprestar um vídeo
            Emprestado emprestado = new Emprestado(video);
            emprestado.EmprestarItem("Carlos");
            emprestado.EmprestarItem("Maria");

            emprestado.Exibe();

            emprestado.DevolverItem("Carlos");

            emprestado.Exibe();

            Console.ReadKey();
        }
    }
}
