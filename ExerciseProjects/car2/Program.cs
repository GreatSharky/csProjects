using System;

namespace car2
{
    class Program
    {
        public abstract class Vehicle
        {
            public string Make {get;}
            public string Model {get;}
            public int Year {get;}

            enum Types 
            {
                car,
                bike,
                submarine,
                plane
            }

            public Vehicle(string make, string model, int year)
            {
                Make = make;
                Model = model;
                Year = year;
            }

            public override string ToString()
            {
                return "{Make} {Model}, {Year}";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
