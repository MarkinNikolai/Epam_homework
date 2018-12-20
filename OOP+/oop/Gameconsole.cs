using System;

namespace gameplatform
{
    class Gameconsole : Platforms
    {
        private string _error;
        public string Error
        {
            set { _error = value; }
        }
        private string _сonsumption;
        public string Consumption
        {
            get { return _сonsumption; }
            set { _сonsumption = value; }
        }

        private int _expenses;
        public int Expenses
        {
            get { return _expenses; }
        }

        public Gameconsole()
        {
        }

        public Gameconsole(string manufacturer,string сonsumption) : base(manufacturer)
        {
            Consumption = сonsumption;
            _expenses = 110 ;
            _error = "";
        }

        public override void Game(int time)
        {
            _expenses = _expenses * time ;
            Console.WriteLine("Играем на консоли");
            Console.WriteLine("Потребление на {0} - {1} w\n", Manufacturer, ShowConsumption());
        }

        public override string ShowPowerErrors()
        {
            return _error;
        }

        public override int ShowConsumption()
        {
            return _expenses;
        }
    }
}
