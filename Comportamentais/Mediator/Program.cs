using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            MediatorConcrete mc = new MediatorConcrete();

            ColleagueConcreteOne cone = new ColleagueConcreteOne(mc);
            ColleagueConcreteTwo ctwo = new ColleagueConcreteTwo(mc);

            mc.ColleagueOne = cone;
            mc.ColleagueTow = ctwo;

            cone.Enviar("Como você está?");
            ctwo.Enviar("Bem. Obrigado.");

            Console.ReadKey();
        }
    }
}
