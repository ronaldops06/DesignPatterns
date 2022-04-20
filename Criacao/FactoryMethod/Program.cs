using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();

            Console.WriteLine("Liu Kang | Sub Zero | Scorpion");
            Console.WriteLine();
            Console.WriteLine("Escolha seu personagem");
            string escolha = Console.ReadLine();
            IPersonagem personagem = fm.EscolherPersonagem(escolha);

            Console.WriteLine("Personagem escolhido");
            personagem.Escolhido();

            Console.ReadKey();
        }
    }
}
