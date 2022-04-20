using System.Collections.Generic;

namespace Observer
{
    public abstract class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public void Anexar(Observer observer)
        {
            this._observers.Add(observer);
        }

        public void Desanexar(Observer observer)
        {
            this._observers.Remove(observer);
        }

        public void Notificar()
        {
            foreach(Observer item in this._observers)
            {
                item.Update();
            }
        }
    }
}
