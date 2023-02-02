using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptureMemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter scripture reference (e.g. John 3:16 or Proverbs 3:5-6): ");
            string reference = Console.ReadLine();

            Console.WriteLine("Enter scripture text: ");
            string text = Console.ReadLine();

            Scripture scripture = new Scripture(reference, text);

            while (scripture.HiddenWords.Count < scripture.Words.Count)
            {
                Console.Clear();
                scripture.DisplayScripture();
                Console.WriteLine("\nPress enter to hide another word or type quit to exit: ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                {
                    break;
                }

                scripture.HideWord();
            }

            Console.Clear();
            Console.WriteLine("All words have been hidden. Thank you for playing!");
        }
    }
}