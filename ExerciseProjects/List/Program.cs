using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates empty list
            List<String> words = new List<String>();
            // Lists list info
            listInfo(words);

            // Add words to list
            words.Add("I'm");
            words.Add("watching");
            words.Add("LoL");

            listInfo(words);

            // Write the words together
            Console.WriteLine(printWords(words));

            // Add words in a diffrent function/method
            // Still works here
            addWord(words, "and");
            addWord(words, "writing");
            addWord(words, "C#");

            listInfo(words);
            Console.WriteLine(printWords(words));

            // Inserts word
            words.Insert(4, "then");
            Console.WriteLine(printWords(words));

            // Sort list alphabetically
            words.Sort();
            Console.WriteLine(printWords(words));

            // Does list contain a word
            string comp = "LoL";
            if(words.Contains(comp)){
                Console.WriteLine("The list has {0} at index {1}", comp, words.IndexOf(comp));
            }
            else{
                Console.WriteLine("The list doesnt have {0}", comp);
            }
            Console.WriteLine();

            // Remove words
            words.Remove("then");
            Console.WriteLine(printWords(words));
            words.RemoveAt(0);
            Console.WriteLine(printWords(words));
            words.Reverse(0, 2);
            Console.WriteLine(printWords(words));
            Console.WriteLine();
            Console.WriteLine(words.ToString());
        }

        static void listInfo(List<String> ls)
        {
            Console.WriteLine("Words capasity: {0}", ls.Capacity);
            Console.WriteLine("Words size: {0}", ls.Count);
            Console.WriteLine();
        }

        static string printWords(List<String> ls)
        {
            string oput = "";
            foreach(string word in ls){
                oput += word + " ";
            }

            return oput;
        }

        static void addWord(List<String> ls, string word)
        {
            ls.Add(word);
        }
    }
}
