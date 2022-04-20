namespace Mediator
{
    public class ColleagueConcreteTwo : Colleague
    {
        public ColleagueConcreteTwo(Mediator mediator) : base(mediator)
        {
        }

        public void Enviar(string mensagem)
        {
            mediator.Enviar(mensagem, this);
        }

        public void Notificar(string mensagem)
        {
            System.Console.WriteLine(mensagem);
        }
    }
}
