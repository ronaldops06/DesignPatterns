﻿using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string romano = "MCMXXVIII";
            Contexto contexto = new Contexto(romano);

            List<Expressao> expressoes = new List<Expressao>();
            expressoes.Add(new MilharesExpressao());
            expressoes.Add(new CentenasExpressao());
            expressoes.Add(new DezenasExpressao());
            expressoes.Add(new UnidadeExpressao());

            foreach(Expressao exp in expressoes)
            {
                exp.Interpretador(contexto);
            }

            Console.WriteLine($"{romano} == {contexto.Output}");
            Console.ReadKey();
        }
    }
}
