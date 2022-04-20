using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioPermanente fp = new FuncionarioPermanente();
            fp.Nome = "João";
            fp.Idade = 30;
            fp.Tipo = "Contratado";

            FuncionarioPermanente fpClone = (FuncionarioPermanente)fp.Clone();
            fpClone.Nome = "Carlos";

            Console.WriteLine("Detalhes do funcionário permanente:");
            Console.WriteLine($"Nome: {fp.Nome}; Idade: {fp.Idade}; Tipo: {fp.Tipo}");
            Console.WriteLine();
            Console.WriteLine("Detalhes do funcionário permanente(Clone):");
            Console.WriteLine($"Nome: {fpClone.Nome}; Idade: {fpClone.Idade}; Tipo: {fpClone.Tipo}");
        }
    }
}
