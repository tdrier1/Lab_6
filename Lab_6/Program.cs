using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            char[] letter = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] spec = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '?' };

            Console.WriteLine("Welcome to the Pig Latin Translator!");

            do { 
                
                Console.Write("\nEnter a line to be translated: ");

                string input = CheckInput();

                string[] word = input.Split(' ');

                Translator(word, letter, spec);

                run=Cont();

            } while (run == true);
        }
        public static string CheckInput()
        {
            bool verify = true;
            string input;
            do
            {
                input = Console.ReadLine();
                Console.Write("\n");

                if (string.IsNullOrEmpty(input) == true)
                {
                    Console.Write("Please enter words: ");
                }
                else
                {
                    verify = false;
                }
            } while (verify == true);

            return input;
        }
        public static void Translator(string[] word, char[] letter, char[] spec)
        {
            for (int i = 0; i < word.Length; i++)
            {
             
                if (!(letter.Any(word[i].Contains)) || spec.Any(word[i].Contains))
                {
                    Console.Write(word[i] + " ");
                }
                
                else if (word[i].StartsWith("a") || word[i].StartsWith("e") || word[i].StartsWith("i") || word[i].StartsWith("o") || word[i].StartsWith("u")
                    || word[i].StartsWith("A") || word[i].StartsWith("E") || word[i].StartsWith("I") || word[i].StartsWith("O") || word[i].StartsWith("U"))
                {
                    Console.Write(word[i] + "way ");
                }
                    else 
                    {
                        int pos = word[i].IndexOfAny(letter);

                        string sub = word[i].Substring(0, pos);

                        string word1 = word[i] + sub;

                        string rem = word1.Remove(0, pos);

                        Console.Write(rem + "ay ");
                    }
             }
        }
        public static bool Cont()
    {
        bool run = true;
        Console.Write("\n\nContinue?(y/n) ");
        string cont = Console.ReadLine();

        if (cont.ToLower() == "n")
        {
            Console.WriteLine("\nThank you!");
            run = false;
        }
        return run;
    }
   }
}
 

    

        

