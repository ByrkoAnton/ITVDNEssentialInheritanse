using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanse03
{
    class Vehicle
    {
        protected string _type;
        public readonly double _year;
        public readonly double _maxSpeed;
        protected double _prise;

        public Vehicle(double year, double maxSpeed, double prise, string type)
        {
            _year = year;
            _maxSpeed = maxSpeed;
            _prise = prise;
            _type = type;
        }

        virtual public string ShowInfo()
        {
            return $"Year of issue - {_year}\nMax speed - {_maxSpeed}\nPrise - {_prise}\n";
        }

        public void ShangePrise(double newPrise)
        {
            _prise = newPrise;
        }

    }
}
