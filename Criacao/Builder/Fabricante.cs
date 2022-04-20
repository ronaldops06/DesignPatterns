using System;

namespace Builder
{
    public class Fabricante
    {
        public void Construtor(ICelular celularBuilder)
        {
            celularBuilder.BuildBateria();
            celularBuilder.BuildSistema();
            celularBuilder.BuildTela();
            celularBuilder.BuildCamera();
        }
    }
}
