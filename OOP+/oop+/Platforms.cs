namespace gameplatform
{

    public abstract class Platforms
    {
        
        private string _manufacturer;
        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }

          
        public Platforms(string manufacturer)
        {
            Manufacturer = manufacturer;
           
        }

        public Platforms()
        {
        }

        abstract public int ShowConsumption();
        abstract public string ShowPowerErrors();
        abstract public void Game(int pow);
    }
}
