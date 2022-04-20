﻿using System;

namespace Bridge
{
    public class SmartTV
    {
        public ICanal CanalAtual { get; set; }
        
        public void ExibeCanalSintonizado()
        {
            if(CanalAtual != null)
                Console.WriteLine(CanalAtual.Canal());
            else
                Console.WriteLine("Por favor selecione um canal");
        }

        public void PlayTv()
        {
            if (CanalAtual != null)
                Console.WriteLine(CanalAtual.Status());
            else
                Console.WriteLine("Por favor selecione um canal");
        }
    }
}
