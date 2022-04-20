using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ExecuteAbstractFactory
    {
        public static Carro montarCarro(String tipo)
        {
            CarroFactory cf = null;
            switch (tipo)
            {
                case "luxo":
                    cf = new CarroLuxoFactory();
                    break;
                case "popular":
                    cf = new CarroPopularFactory();
                    break;
            }

            Carro carro = new Carro();
            carro.Roda = cf.montarRoda();
            carro.Som = cf.montarSom();

            return carro;
        }
    }
}
