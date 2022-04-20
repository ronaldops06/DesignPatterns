namespace Builder
{
    public class IphoneBuilder : ICelular
    {
        Celular Celular;

        public IphoneBuilder()
        {
            this.Celular = new Celular("Iphone 10");
        }

        public void BuildBateria()
        {
            this.Celular.Bateria = "MAH_2200";
        }

        public void BuildCamera()
        {
            this.Celular.Camera = "18 MP";
        }

        public void BuildSistema()
        {
            this.Celular.Sistema = "iOS 11";
        }

        public void BuildTela()
        {
            this.Celular.Tela = "9";
        }

        public Celular celular
        {
            get { return this.Celular; }
        }
    }
}
