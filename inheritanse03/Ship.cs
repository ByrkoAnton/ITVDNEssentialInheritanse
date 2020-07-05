using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanse03
{
    class Ship : Vehicle
    {
        private string _homePort;
        private int _passengers;

        public Ship(string homePort, int passengers, double year, double maxSpeed, double prise) 
            : base(year, maxSpeed, prise, "Ship")
        {
            _homePort = homePort;
            _passengers = passengers;
        }

        public override string ShowInfo()
        {
            return $"type - {_type}\nhome port - {_homePort}\npassengers - {_passengers}\n{base.ShowInfo()}";
        }
    }
}
