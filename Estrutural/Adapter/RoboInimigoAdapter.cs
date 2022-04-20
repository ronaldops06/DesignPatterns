using System;

namespace Adapter
{
    public class RoboInimigoAdapter : IAtaqueInimigo
    {
        RoboInimigo robo;

        public RoboInimigoAdapter(RoboInimigo robo)
        {
            this.robo = robo;
        }

        public void AramaFogo()
        {
            this.robo.EsmagarComMaoes();
        }

        public void Movimenta()
        {
            this.robo.AndarFrente();
        }

        public void Pilotar(string piloto)
        {
            this.robo.ReagirContraHumano(piloto);
        }
    }
}
