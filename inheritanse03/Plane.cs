using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanse03
{
    class Plane : Vehicle
    {
        private int _maxHegft;
        private int _passengers;

        public Plane(int maxHeight, int passengers, double year, double maxSpeed, double prise) : base(year, maxSpeed, prise, "Plane")
        {
            _maxHegft = maxHeight;
            _passengers = passengers;
        }

        public override string ShowInfo()
        {
            return $"type - {_type}\nmax Hegft - {_maxHegft}\npassengers - {_passengers}\n{base.ShowInfo()}";
        }
    }
}
