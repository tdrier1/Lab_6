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
        {   //defining local variable for the do/while loop
            bool run = true;

            //setting up arrays used for checking values for input
            char[] letter = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] spec = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '?' };

            //main heading at the start of the program
            Console.WriteLine("Welcome to the Pig Latin Translator!");

            //main statements used in program, includes calls to different methods
            do { 
                
                Console.Write("\nEnter a line to be translated: ");

                string input = CheckInput();

                //creates word string array by splitting words by space value
                string[] word = input.Split(' ');

                Translator(word, letter, spec);

                run=Cont();

            } while (run == true);
        }
        //method used to ensure user input a string value into program
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
            //returns the input value to the main method
            return input;
        }
        //method used to perform the actual translation
        public static void Translator(string[] word, char[] letter, char[] spec)
        {
            //for loop used to cycle through each letter in the word array 
            for (int i = 0; i < word.Length; i++)
            {
                //if statement used to determin if the word contains any variables or special chars
                if (!(letter.Any(word[i].Contains)) || spec.Any(word[i].Contains))
                {
                    Console.Write(word[i] + " ");
                }
                //if those conditions were not met, the program will now search for vowels and add "way" to the end of the word
                else if (word[i].StartsWith("a") || word[i].StartsWith("e") || word[i].StartsWith("i") || word[i].StartsWith("o") || word[i].StartsWith("u")
                    || word[i].StartsWith("A") || word[i].StartsWith("E") || word[i].StartsWith("I") || word[i].StartsWith("O") || word[i].StartsWith("U"))
                {
                    Console.Write(word[i] + "way ");
                }

                //checks index of vowel letter and performs operations on the string value of the word array
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
        //simple method used to prompt the user to continue the program
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
 

    

        

