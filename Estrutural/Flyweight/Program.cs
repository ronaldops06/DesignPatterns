using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaFlyweight fabrica = new FabricaFlyweight();

            string cor = string.Empty;

            Tartaruga tartaruga;

            while(true)
            {
                Console.Write("Tartaruga a enviar: ");
                cor = Console.ReadLine().ToLower();

                tartaruga = fabrica.GetTartaruga(cor);
                tartaruga.Mostra(cor);

                Console.WriteLine("\n----------------------\n");
            }
        }
    }
}
