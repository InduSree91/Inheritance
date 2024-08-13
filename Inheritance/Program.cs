using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car { Wheels = 4, Color = "Black" ,Brand = "Toyota", Model = "Corolla", Year = 2024 };
            myCar.Start();
            myCar.Driving();
        }
    }

    class Vehicle
    {
        public int Wheels { get; set; }
        public string Color { get; set; }

        public void Driving()
        {
            Console.WriteLine("Driver is driving the Vehicle");
        }
    }

    class Car : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine("Car has started");
        }
    }
}