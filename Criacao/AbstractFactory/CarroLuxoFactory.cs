namespace AbstractFactory
{
    public class CarroLuxoFactory : CarroFactory
    {
        public override Som montarSom()
        {
            return new BluetoothPlayer();
        }

        public override Roda montarRoda()
        {
            return new RodaLigaLeve();
        }
    }
}
