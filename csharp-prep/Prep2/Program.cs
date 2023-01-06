using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What grade did you get in your class?(write a number, such as 87 or 94)");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

    if (number >= 90)
        {
            Console.WriteLine("you recieved an A");
        }
    else if (number >= 80)
        {
            Console.WriteLine("You recieved a B");
        }
    else if (number >= 70)
        {
            Console.WriteLine("You recieved a C");
        }
    else if (number >= 60)
        {
            Console.WriteLine("You recieved a D");
        }
    else
        {
            Console.WriteLine("You recieved an F");
        }
    if (number >= 70)
        {
            Console.WriteLine("You passed!");
        }
    else
        {
            Console.WriteLine("YOU ARE A FAILURE");
        }
    }
}