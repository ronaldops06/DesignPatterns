using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class TanqueInimigo : IAtaqueInimigo
    {
        Random gerador = new Random();
        public void AramaFogo()
        {
            int danoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine($"Dano causado pelo inimigo: {danoAtaque}");
        }

        public void Movimenta()
        {
            int movimento = this.gerador.Next(5) + 1;
            Console.WriteLine($"Tanque inimigo andou {movimento} passos");
        }

        public void Pilotar(string piloto)
        {
            Console.WriteLine($"O piloto {piloto} está no comando do tanque");
        }
    }
}
