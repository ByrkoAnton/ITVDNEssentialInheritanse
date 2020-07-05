using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanse03
{
    class Car : Vehicle
    {
        private string _model;
        public Car(string model, double year, double maxSpeed, double prise) : base(year, maxSpeed, prise, "Car")
        {
            _model = model;
        }

        public override string ShowInfo()
        {
            return $"type - {_type}\nmodel - {_model}\n{base.ShowInfo()}";
        }
    }
}
