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
            List<string> output = new List<string>();
            Console.WriteLine("Give a string to separate:");
            input = Console.ReadLine();
            Console.WriteLine("Give separator. If empty, space is used:");
            sep = Console.ReadLine();
            if(sep == ""){
                sep = " ";
            }
            output = splitting(input, sep, false);
            for (int i = 0; i < output.Count; i++)
            {
                Console.WriteLine(output[i]);
            }
        }

        static List<string> splitting(string input, string sep, bool empty)
        {
            List<string> output = new List<string>();
            string[] what = new string[input.Length];
            if(!input.Contains(sep)){
                if(true){
                    Console.WriteLine("There are no {0} in the strings. Putting  everything in one list",
                    sep);
                }
                output.Add(input);
            }
            else if (input.Contains(sep)){
                what = input.Split(sep);
                
                for(int i = 0; i <  what.Length; i++){
                    if(what[i] != ""){
                        output.Add(what[i]);
                    }
                    else if (empty == true){
                        output.Add(what[i]);
                    }
                }
            
            }
            return output;
        }
    }
}
