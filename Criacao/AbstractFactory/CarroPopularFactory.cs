namespace AbstractFactory
{
    public class CarroPopularFactory : CarroFactory
    {
        public override Som montarSom()
        {
            return new CDPlayer();
        }

        public override Roda montarRoda()
        {
            return new RodaSimples();
        }
    }
}
