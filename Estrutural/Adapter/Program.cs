using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TanqueInimigo tanqueOne = new TanqueInimigo();
            RoboInimigo roboOne = new RoboInimigo();

            IAtaqueInimigo roboAdapter = new RoboInimigoAdapter(roboOne);

            Console.WriteLine("=========Robo=========");
            roboOne.ReagirContraHumano("Roberval");
            roboOne.AndarFrente();
            roboOne.EsmagarComMaoes();
            
            Console.WriteLine("=========Tanque=========");
            tanqueOne.Pilotar("Juca Bala");
            tanqueOne.Movimenta();
            tanqueOne.AramaFogo();

            // Este objeto mesmo sendo um Robo tem os mesmos métodos do tanque, pois foi adaptado para um tanque.
            Console.WriteLine("======Robo Adaptado=====");
            roboAdapter.Pilotar("Adalberto");
            roboAdapter.Movimenta();
            roboAdapter.AramaFogo();

            Console.ReadKey();
        }
    }
}
