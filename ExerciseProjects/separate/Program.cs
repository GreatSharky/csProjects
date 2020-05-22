using System;

namespace separate
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string sep;
            Console.writeLine("Give a string to separate:");
            input = Console.ReadLine();
            Console.writeLine("Give separator. If empty, space is used:");
            sep = Console.ReadLine();
        }

        static List<string> splitting(string input, string sep)
        {
            if(!input.contains(sep)){
                Console.writeLine("There")
            }
        }
    }
}
