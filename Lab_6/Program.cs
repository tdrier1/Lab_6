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
            
                Console.WriteLine("Welcome to the Pig Latin Translator!");
                
            do
            {
                Console.Write("\nEnter a line to be translated: ");
                
                string input = Console.ReadLine();

                Console.Write("\n");

                input.ToLower();

                string[] word = input.Split(' ');

                Translator(word);

                run=Cont();

            } while (run == true);

        }
        public static void Translator(string[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].StartsWith("a") || word[i].StartsWith("e") || word[i].StartsWith("i") || word[i].StartsWith("o") || word[i].StartsWith("u"))
                {
                    Console.Write(word[i] + "way ");
                }

                else
                {
                    int pos = word[i].IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u', 'y' });

                    string sub = word[i].Substring(0, pos);

                    string word1 = word[i] + sub;

                    string rem = word1.Remove(0, pos);

                    Console.Write(rem + "ay ");

                }

            }
        }

        public static bool Cont()
        {
            bool run=true;
                Console.Write("\n\nContinue?(y/n) ");
                string cont = Console.ReadLine();


                if (cont == "n")
                {
                    Console.WriteLine("\nThank you!");
                    run = false;
                }
            return run;
        }
    }
 }

    

        

