using System;

namespace gameplatform
{
    class Portablegame : Platforms
    {
        private string _powerType;
        public string PowerType
        {
            get { return _powerType; }
            set { _powerType = value; }
        }

        public Portablegame(string powerType)
        {
            PowerType = powerType;
        }

        public Portablegame()
        {
        }

        public override string ShowPowerErrors()
        {
            throw new NotImplementedException("Тетрис независим от розетки");
        }

        public override int ShowConsumption()
        {
            return 0;
        }

        public override void Game(int pow)
        {
            Console.WriteLine("Залипаем в тетрис.");
            Console.WriteLine("Потребление от 2-х батареек хватит на месяц\n");
        }
    }
}
