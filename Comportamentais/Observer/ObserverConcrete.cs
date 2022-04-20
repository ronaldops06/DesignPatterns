using System;

namespace Observer
{
    public class ObserverConcrete : Observer
    {
        public SubjectConcrete SubjectConcrete { get; set; }

        private string _name;
        private string _stateObserver;
        private SubjectConcrete _subject;

        public ObserverConcrete(SubjectConcrete subject, string name)
        {
            this._subject = subject;
            this._name = name;
        }

        public override void Update()
        {
            this._stateObserver = this._subject.StateSubject;
            Console.WriteLine($"Novo estado do Observer {this._name}: {this._stateObserver}");
        }
    }
}
