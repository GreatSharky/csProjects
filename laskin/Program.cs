using System;

namespace laskin
{
    class Program
    {
        static int Main(string[] args)
        {
            string str;
            Console.Write("Input: ");
            str = Console.ReadLine(); 
            int num = Convert.ToInt32(str);
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine(num*i);
            }
            return 0;
        }
    }
}
