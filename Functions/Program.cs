using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string iput = "";
            Console.WriteLine("Im testing functions\n");
            iput = Console.ReadLine();
            if(iput.Length == 0){
               noInput(); 
            }
            else if(iput.Length < 3){
                shortInput();
            }
            else{
                Console.WriteLine(longInput());
            }
        }

        static void shortInput(){
            Console.WriteLine("Your word is short");
        }

        static void noInput(){
            Console.WriteLine("You gave no input");
        }

        static string longInput(){
            return "Your input is long";
        }
    }
}