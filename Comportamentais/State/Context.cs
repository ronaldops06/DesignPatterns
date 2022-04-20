using System;

namespace State
{
    public class Context
    {
        private State _state;

        public Context(State state)
        {
            this._state = state;
        }

        public State State
        {
            get { return _state; }
            set
            {
                this._state = value;
                Console.WriteLine($"Estado: {this._state.GetType().Name}");
            }
        }

        public void Request()
        {
            this._state.Handle(this);
        }
    }
}
