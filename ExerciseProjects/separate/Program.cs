using System;
using System.Collections.Generic;

namespace separate
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string sep;
            Console.WriteLine("Give a string to separate:");
            input = Console.ReadLine();
            Console.WriteLine("Give separator. If empty, space is used:");
            sep = Console.ReadLine();
        }

        static List<string> splitting(string input, string sep, bool print)
        {
            List<string> output = new List<string>();
            if(!input.Contains(sep)){
                if(print){
                    Console.WriteLine("There are no {0} in the strings. Putting  everything in one list",
                    sep);
                }
                output.Add(input);
                return output;
            }
            else if (input.Contains(sep)){
                for()
            }
        }
    }
}
