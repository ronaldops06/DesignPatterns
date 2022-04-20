using System;
using System.Collections;

namespace Iterator
{
    public class ConcreteAggregate : Aggregate
    {
        private ArrayList _itens = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return _itens.Count; }
        }

        public object this[int index]
        {
            get { return _itens[index]; }
            set { _itens.Insert(index, value); }
        }
    }
}
