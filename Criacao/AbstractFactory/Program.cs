using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carOne = ExecuteAbstractFactory.montarCarro("luxo");
            Carro carTwo = ExecuteAbstractFactory.montarCarro("popular");

            Console.ReadKey();
        }
    }
}
