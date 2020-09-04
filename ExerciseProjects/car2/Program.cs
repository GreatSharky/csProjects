using System;

namespace car2
{
    class Program
    {
        enum VechileTypes 
            {
                car,
                bike,
                submarine,
                plane
            }
        public abstract class Vehicle
        {
            public string Make {get;}
            public string Model {get;}
            public int Year {get;}

            public Vehicle(string make, string model, int year)
            {
                Make = make;
                Model = model;
                Year = year;
            }

            public override string ToString()
            {
                return $"{Make} {Model}, {Year}";
            }
        }

        public class Car : Vehicle
        {
            public int TankSize;
            
            public int Usage;
            public int Odometer;

            public Car(string make, string model, int year, int tank_size, int usage) : base(make, model, year)
            {
                TankSize = tank_size;
                Usage = TankSize;
                Odometer = 0;
            }

            public void drive(float distance)
            {
                place_ =+ distance;
            }

            // Private parts ;)
            private float place_ = 0;
            private float gasLeft_ = 0;

        }

        static void Main(string[] args)
        {
            Car audi = new Car("Audi", "A6", 20, 70, 7);
            Console.WriteLine(audi);
            Console.ReadLine();
        }
    }
}
