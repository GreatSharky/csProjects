/*  Car exercise project from johoh
    Aaro Haikonen, TheGreatSharky 24.7.2020
*/

using System;
using System.Collections.Generic;



namespace car
{
    class Program
    {
        public class Car
        {
            public string Name{get; set;}
            public float TankSize;

            public float Usage;
            public float Odometer;
            public float GasInTank_;
            public Car(string name, float tankSize, float usage)
            {
                Name = name;
                TankSize = tankSize;
                Usage = usage;
                Odometer = 0;
                GasInTank_ = TankSize;
            }

            public void drive(float distance)
            {
                if(0 > GasInTank_ - Usage*distance){
                    Odometer += GasInTank_*Usage;
                    GasInTank_ = 0;
                }
                else{
                    Odometer += distance;
                    GasInTank_ -= Usage*distance;
                }
            }

            public void fill(float fillnumber){
                if(fillnumber + GasInTank_ > TankSize){
                    GasInTank_ = TankSize;
                }
                else{
                    GasInTank_ += fillnumber;
                }
            }
        }
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            /*Choose an action
            string input;
            Console.WriteLine("New car: N\nControl a car: C");
            input = Console.ReadLine();
            if(input == "N" || input == "n"){

            }*/

            Car bmw = new Car("bemmi", 10, 1);
            Console.WriteLine("car is named {0} and tank is {1} liters", bmw.Name, bmw.GasInTank_);
            Console.WriteLine("car {0} has {1} liters in its tank and has travelled {2}"
            , bmw.Name, bmw.GasInTank_, bmw.Odometer);

            bmw.Name = "romu";
            bmw.GasInTank_ =8 ;

            Console.WriteLine("car is named {0} and tank is {1} liters", bmw.Name, bmw.GasInTank_);

            bmw.drive(2);
            Console.WriteLine("car {0} has {1} liters in its tank and has travelled {2}"
            , bmw.Name, bmw.GasInTank_, bmw.Odometer);

            bmw.drive(10);
            Console.WriteLine("car {0} has {1} liters in its tank and has travelled {2}"
            , bmw.Name, bmw.GasInTank_, bmw.Odometer);

            bmw.fill(10);
            Console.WriteLine("car {0} has {1} liters in its tank and has travelled {2}"
            , bmw.Name, bmw.GasInTank_, bmw.Odometer);

            bmw.drive(5);
            Console.WriteLine("car {0} has {1} liters in its tank and has travelled {2}"
            , bmw.Name, bmw.GasInTank_, bmw.Odometer);

            bmw.fill(2);
            Console.WriteLine("car {0} has {1} liters in its tank and has travelled {2}"
            , bmw.Name, bmw.GasInTank_, bmw.Odometer);
        }
    }
}
