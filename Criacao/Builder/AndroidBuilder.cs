namespace Builder
{
    public class AndroidBuilder : ICelular
    {
        Celular Celular;

        public AndroidBuilder()
        {
            this.Celular = new Celular("Android");
        }

        public void BuildBateria()
        {
            this.Celular.Bateria = "MAH_1500";
        }

        public void BuildCamera()
        {
            this.Celular.Camera = "15 MP";
        }

        public void BuildSistema()
        {
            this.Celular.Sistema = "Android 11";
        }

        public void BuildTela()
        {
            this.Celular.Tela = "7";
        }

        public Celular celular
        {
            get { return this.Celular; }
        }
    }
}
