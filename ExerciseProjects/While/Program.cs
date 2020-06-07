using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int i = 1;
            while(i <= 30){
                if(i % 21 == 0){
                    Console.WriteLine("Zip Boeng!");
                }
                else if(i % 7 == 0){
                    Console.WriteLine("Boeng!");
                }
                else if(i % 3 == 0){
                    Console.WriteLine("Zip!");
                }
                else{
                    Console.WriteLine(i);
                }
                ++i;
            }
        }
    }
}
