using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria fabricante
            Fabricante fabricante = new Fabricante();

            //Permite que a classe builder eseja pronta
            ICelular celularBuilder = null;

            //Cria o telefone android
            celularBuilder = new AndroidBuilder();
            fabricante.Construtor(celularBuilder);

            Console.WriteLine("Celular Fabricado:....... {0}", celularBuilder.celular.Nome);
            Console.WriteLine(" - Sistema Operacional:.. {0}", celularBuilder.celular.Sistema);
            Console.WriteLine(" - Tela:................. {0}", celularBuilder.celular.Tela);
            Console.WriteLine(" - Camera:............... {0}", celularBuilder.celular.Camera);
            Console.WriteLine(" - Bateria:.............. {0}", celularBuilder.celular.Bateria);

            Console.ReadKey();
        }
    }
}
