using System;
class Program
{
    static void Main(string[] args)
    {
        Assignment as1 = new Assignment("Ryan Schader", "Diff Eq");
        Console.WriteLine(as1.GetSummary());

        MathAssignment as2 = new MathAssignment("Nathan Schader", "Trigonometry", "5.1", "5-10");
        Console.WriteLine(as2.GetSummary());
        Console.WriteLine(as2.GetHomeworkList());

        WritingAssignment as3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(as3.GetSummary());
        Console.WriteLine(as3.GetWritingInformation());
    }
}