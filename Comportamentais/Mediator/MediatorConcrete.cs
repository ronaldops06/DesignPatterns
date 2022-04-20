namespace Mediator
{
    public class MediatorConcrete : Mediator
    {
        private ColleagueConcreteOne _colleagueOne;
        private ColleagueConcreteTwo _colleagueTwo;

        public ColleagueConcreteOne ColleagueOne
        {
            set { _colleagueOne = value;  }
        }

        public ColleagueConcreteTwo ColleagueTow
        {
            set { _colleagueTwo = value; }
        }

        public override void Enviar(string mensagem, Colleague colleague)
        {
            if (colleague == _colleagueOne)
                _colleagueTwo.Notificar(mensagem);
            else
                _colleagueOne.Notificar(mensagem);
        }
    }
}
