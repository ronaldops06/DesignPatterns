using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Decorator : ItemBiblioteca
    {
        protected ItemBiblioteca itemBiblioteca;

        public Decorator(ItemBiblioteca itemBiblioteca)
        {
            this.itemBiblioteca = itemBiblioteca;
        }

        public override void Exibe()
        {
            this.itemBiblioteca.Exibe();
        }
    }
}
