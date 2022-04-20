using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartTV minhaTV = new SmartTV();
            Console.WriteLine("Selecione um canal");
            Console.WriteLine("1 - Filmes\n2 - Documentários\n3 - Culinária");
            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.KeyChar)
            {
                case '1':
                    minhaTV.CanalAtual = new Filme();
                    break;
                case '2':
                    minhaTV.CanalAtual = new Documentario();
                    break;
                case '3':
                    minhaTV.CanalAtual = new Culinaria();
                    break;
            }

            Console.WriteLine();
            minhaTV.ExibeCanalSintonizado();

            minhaTV.PlayTv();
        }
    }
}
