using System;

namespace inheritanse03
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Ford", 2021, 250, 80000);
            Console.WriteLine(car.ShowInfo());

            Plane plane = new Plane(2000, 150, 2000, 850, 20000000);
            Console.WriteLine(plane.ShowInfo());

            Ship ship = new Ship("NY", 5000, 1966, 30, 400000);
            Console.WriteLine(ship.ShowInfo());
        }
    }
}
