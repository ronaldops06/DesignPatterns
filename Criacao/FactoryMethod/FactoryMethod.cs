using System;

namespace FactoryMethod
{
    public class FactoryMethod
    {
        public IPersonagem EscolherPersonagem(string personagem)
        {
            switch (personagem)
            {
                case "Liu Kang": return new LiuKang();
                case "Scorpion": return new Scorpion();
                case "Sub Zero": return new SubZero();
                default: return null;
            }
        }
    }
}
