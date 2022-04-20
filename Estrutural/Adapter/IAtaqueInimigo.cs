using System;

namespace Adapter
{
    public interface IAtaqueInimigo
    {
        public void AramaFogo();
        public void Movimenta();
        public void Pilotar(String piloto);
    }
}
