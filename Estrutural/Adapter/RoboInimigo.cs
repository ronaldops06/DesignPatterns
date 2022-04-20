using System;

namespace Adapter
{
    public class RoboInimigo
    {
        Random gerador = new Random();

        public void EsmagarComMaoes()
        {
            int danoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine($"Dano causado pelo robô inimigo {danoAtaque}, com o ataque esmagar com as mãos");
        }

        public void AndarFrente()
        {
            int movimento = this.gerador.Next(10) + 1;
            Console.WriteLine($"O Robô inimigo andou {movimento} passos para frente");
        }

        public void ReagirContraHumano(String piloto)
        {
            Console.WriteLine($"O Robô inimigo irá atacar o piloto {piloto}");
        }
    }
}
