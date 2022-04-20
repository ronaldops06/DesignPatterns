using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class FabricaFlyweight
    {
        private Dictionary<string, Tartaruga> listaTartarugas = new Dictionary<string, Tartaruga>();

        public Tartaruga GetTartaruga(string cor)
        {
            Tartaruga tartaruga = null;

            if (listaTartarugas.ContainsKey(cor))
            {
                tartaruga = listaTartarugas[cor];
            }
            else
            {
                switch (cor)
                {
                    case "azul":
                        tartaruga = new TartarugaAzul();
                        break;
                    case "verde":
                        tartaruga = new TartarugaVerde();
                        break;
                    case "vermelha":
                        tartaruga = new TartarugaVermelha();
                        break;
                    case "laranja":
                        tartaruga = new TartarugaLaranja();
                        break;
                }

                listaTartarugas.Add(cor, tartaruga);
            }
            
            Console.WriteLine($"Quantidade de tartarugas {listaTartarugas.Count}");

            return tartaruga;
        }
    }
}
