using System;

namespace VehicleMovementApp
{
    interface IMovable
    {
        void Move();
    }

    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The car is driving on the road.");
        }
    }

    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The bicycle is pedaling down the street.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMovable car = new Car();
            IMovable bike = new Bicycle();

            Console.WriteLine("Vehicle Movements:");
            car.Move();
            bike.Move();
        }
    }
}
