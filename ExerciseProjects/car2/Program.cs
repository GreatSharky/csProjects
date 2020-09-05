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
            
            public double Usage;
            public double Odometer;

            public Car(string make, string model, int year, int tank_size, int usage) : base(make, model, year)
            {
                TankSize = tank_size;
                Usage = usage/100;
                Odometer = 0;
            }

            
            
            public void drive(double distance)
            {
                if(distance * Usage > gasLeft_){
                    distance = gasLeft_/Usage;
                    gasLeft_ = 0;
                }
                else{
                    gasLeft_ -= Usage*distance;
                }
                Odometer += distance;
                place_ += distance;
            }

            
            
            public void fill(double extra_gas)
            {
                if(gasLeft_ + extra_gas > TankSize){
                    gasLeft_ = TankSize;
                }
                else if(gasLeft_ + extra_gas < 0){
                    gasLeft_ = 0;
                }
                else{
                    gasLeft_ += extra_gas;
                } 
            }

            // Private parts ;)
            private double place_ = 0;
            private double gasLeft_ = 50;

        }

        static void Main(string[] args)
        {
            Car audi = new Car("Audi", "A6", 20, 70, 7);
            audi.drive(12);
            audi.drive(90);
            Console.WriteLine(audi);
            Console.ReadLine();
        }
    }
}
