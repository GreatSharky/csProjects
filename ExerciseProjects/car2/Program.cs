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

            public Car(string make, string model, int year, int tank_size, double usage) : base(make, model, year)
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


        public class Chopper : Vehicle
        {
            public int TankSize;
            public double Usage;
            public double Odometer;

            public Chopper(string make, string model, int year, int tank_size, double usage) : base(make, model, year)
            {
                TankSize = tank_size;
                Usage = usage/100;
                Odometer = 0;
                gasLeft_ = TankSize;
            }

            public bool fly(double distance, double altitude)
            {
                double travel = hypotenusa(distance,altitude);
                if(gasLeft_ < travel){
                    place_ = 0;
                    altitude_ = 0;
                    Odometer = 0;
                    return false;
                }
                else{
                    place_ += distance;
                    altitude_ += altitude;
                    Odometer += travel;
                    gasLeft_ -= travel;
                    return true;
                }
            }

            // Private parts :)
            private double hypotenusa(double x, double y)
            {
                return Math.Sqrt(x*x+y*y);
            }

            private double place_;
            private double altitude_;
            private double gasLeft_;
        }

        static void Main(string[] args)
        {
            Car audi = new Car("Audi", "A6", 20, 70, 7);
            audi.drive(12);
            audi.drive(90);
            Console.WriteLine(audi);
            Chopper bird = new Chopper("US army", "flybird", 2000, 50, 7);
            bird.fly(10, 10);
            Console.ReadLine();
        }
    }
}
