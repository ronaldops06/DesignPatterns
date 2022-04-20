using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Bola jogadorOne = Bola.GetInstance;
            jogadorOne.Mensagem("Jogador 1: A bola está comigo.");

            Bola jogadorTwo = Bola.GetInstance;
            jogadorTwo.Mensagem("Jogador 2: Recebeu a bola");

            Bola jogadorThree = Bola.GetInstance;
            jogadorThree.Mensagem("Jogador 3: Recebeu o lançamento");

            Console.ReadKey();
        }
    }
}
