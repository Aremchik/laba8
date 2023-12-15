using System;
using System.Runtime.ConstrainedExecution;

namespace Laba8
{
    internal class Program
    {
        static void Main()
        {
            static void OperateVehicle(Vehicle vehicle)
            {
                vehicle.StartEngine();

                if (vehicle is Car car)
                {
                    car.Accelerate();
                }
                else if (vehicle is Motorcycle motorcycle)
                {
                    motorcycle.Parking();
                }
                else if (vehicle is Truck truck)
                {
                    truck.LoadCargo();
                }

                vehicle.StopEngine();
            }

            Car car = new Car();
            car.Name = "Sedan";
            OperateVehicle(car);

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Name = "Sportbike";
            OperateVehicle(motorcycle);

            Truck truck = new Truck();
            truck.Name = "Semi-truck";
            OperateVehicle(truck);
        }
    }

    public abstract class Vehicle
    {
        public abstract string Name { get; set; }
        public abstract void StartEngine();
        public abstract void StopEngine();
    }

    public class Car : Vehicle
    {
        public override string Name { get; set; }

        public override void StartEngine()
        {
            Console.WriteLine("Машина заведена");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Машина заглушена");
        }

        public void Accelerate()
        {
            Console.WriteLine("Машина разгоняется");
        }
    }

    public class Motorcycle : Vehicle
    {
        public override string Name { get; set; }

        public override void StartEngine()
        {
            Console.WriteLine("Мотоцикл заведен");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Мотоцикл заглушен");
        }

        public void Parking()
        {
            Console.WriteLine("Мотоцикл паркуется");
        }
    }

    public class Truck : Vehicle
    {
        public override string Name { get; set; }

        public override void StartEngine()
        {
            Console.WriteLine("Грузовик заведен");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Грузовик заглушен");
        }

        public void LoadCargo()
        {
            Console.WriteLine("Грузовик загружается");
        }
    }
}
