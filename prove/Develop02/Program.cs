using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    static List<Entry> journal = new List<Entry>();
    static string[] prompts = new string[] {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    static void Main(string[] args)
    {
        int choice;
        do
        {
            DisplayMenu();
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    WriteNewEntry();
                    break;
                case 2:
                    DisplayJournal();
                    break;
                case 3:
                    SaveJournal();
                    break;
                case 4:
                    LoadJournal();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 5);
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Journal Menu");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
    }

    static void WriteNewEntry()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        string prompt = prompts[index];

        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        Entry entry = new Entry(prompt, response, DateTime.Now);
        journal.Add(entry);
    }

    static void DisplayJournal()
    {
        if (journal.Count == 0)
        {
            Console.WriteLine("No entries in the journal.");
        }
        else
        {
            foreach (Entry entry in journal)
            {
                Console.WriteLine("Prompt: " + entry.prompt);
                Console.WriteLine("Response: " + entry.response);
                Console.WriteLine("Date: " + entry.date);
                Console.WriteLine();
            }
        }
        Console.ReadLine();
    }

    static void SaveJournal()
    {
        Console.WriteLine("Enter a file name: ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in journal)
            {
                writer.WriteLine(entry.prompt);
                writer.WriteLine(entry.response);
                writer.WriteLine(entry.date);
                writer.WriteLine();
            }
        }
    }

    static void LoadJournal()
    {
        Console.WriteLine("Enter a file name: ");
        string fileName = Console.ReadLine();

        journal.Clear();

        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string prompt = reader.ReadLine();
                    string response = reader.ReadLine();
                    DateTime date = DateTime.Parse(reader.ReadLine());

                    Entry entry = new Entry(prompt, response, date);
                    journal.Add(entry);
                    reader.ReadLine();
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
        Console.ReadLine();
    }
}

	
