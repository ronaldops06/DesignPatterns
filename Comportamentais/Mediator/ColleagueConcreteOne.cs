namespace Mediator
{
    public class ColleagueConcreteOne : Colleague
    {
        public ColleagueConcreteOne(Mediator mediator) : base(mediator)
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
