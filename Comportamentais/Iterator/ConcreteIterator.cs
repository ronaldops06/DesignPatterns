﻿namespace Iterator
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _aggregate;
        private int _current = 0;

        public ConcreteIterator(ConcreteAggregate agregate)
        {
            this._aggregate = agregate;
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
                ret = _aggregate[++_current];

            return ret;
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

    }
}
