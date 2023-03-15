using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

// The parent class for all types of goals
public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public bool Completed { get; set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        Completed = false;
    }

    public abstract void RecordEvent();
    public abstract string GetProgress();
}

// Simple goal that can be marked complete
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points)
    {
    }

    public override void RecordEvent()
    {
        Completed = true;
    }

    public override string GetProgress()
    {
        return Completed ? "Completed" : "Not completed";
    }
}

// Eternal goal that can be recorded multiple times
public class EternalGoal : Goal
{
    public int TimesRecorded { get; set; }

    public EternalGoal(string name, int points) : base(name, points)
    {
        TimesRecorded = 0;
    }

    public override void RecordEvent()
    {
        TimesRecorded++;
    }

    public override string GetProgress()
    {
        return $"Recorded {TimesRecorded} times";
    }
}

// Checklist goal that must be accomplished a certain number of times
public class ChecklistGoal : Goal
{
    public int RequiredTimes { get; set; }
    public int BonusPoints { get; set; }
    public int TimesRecorded { get; set; }

    public ChecklistGoal(string name, int points, int requiredTimes, int bonusPoints) : base(name, points)
    {
        RequiredTimes = requiredTimes;
        BonusPoints = bonusPoints;
        TimesRecorded = 0;
    }

    public override void RecordEvent()
    {
        TimesRecorded++;
        if (TimesRecorded >= RequiredTimes)
        {
            Completed = true;
            Points += BonusPoints;
        }
    }

    public override string GetProgress()
    {
        return $"Completed {TimesRecorded}/{RequiredTimes} times";
    }
}

// Main program
class Program
{
    static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        LoadGoals();

        while (true)
        {
            Console.WriteLine("1. Add goal");
            Console.WriteLine("2. Record event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("0. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddGoal();
                    break;
                case 2:
                    RecordEvent();
                    break;
                case 3:
                    ShowGoals();
                    break;
                case 4:
                    ShowScore();
                    break;
                case 5:
                    SaveGoals();
                    break;
                case 6:
                    LoadGoals();
                    break;
                case 0:
                    SaveGoals();
                    return;
            }
        }
    }

    static void AddGoal()
    {
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter goal type (1=simple, 2=eternal, 3=checklist):");
        int type = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter goal points:");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                goals.Add(new SimpleGoal(name,                points));
                break;
            case 2:
                goals.Add(new EternalGoal(name, points));
                break;
            case 3:
                Console.WriteLine("Enter required times:");
                int requiredTimes = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bonus points:");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, points, requiredTimes, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }

        Console.WriteLine("Goal added.");
    }

    static void RecordEvent()
    {
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();
        Goal goal = goals.Find(g => g.Name == name);

        if (goal == null)
        {
            Console.WriteLine("Goal not found.");
        }
        else
        {
            goal.RecordEvent();
            Console.WriteLine("Event recorded.");
        }
    }

    static void ShowGoals()
    {
        Console.WriteLine("Goals:");
        foreach (Goal goal in goals)
        {
            Console.Write($"[{(goal.Completed ? "X" : " ")}] {goal.Name} ({goal.Points} points)");
            Console.WriteLine($" - {goal.GetProgress()}");
        }
    }

    static void ShowScore()
    {
        int score = 0;
        foreach (Goal goal in goals)
        {
            if (goal.Completed)
            {
                score += goal.Points;
            }
        }

        Console.WriteLine($"Score: {score}");
    }

    static void SaveGoals()
    {
        string json = JsonConvert.SerializeObject(goals, Formatting.Indented);
        File.WriteAllText("goals.json", json);
        Console.WriteLine("Goals saved.");
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.json"))
        {
            string json = File.ReadAllText("goals.json");
            goals = JsonConvert.DeserializeObject<List<Goal>>(json);
            Console.WriteLine("Goals loaded.");
        }
        else
        {
            Console.WriteLine("No saved goals.");
        }
    }
}

