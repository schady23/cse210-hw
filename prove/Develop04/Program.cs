using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        BreathingExercise breathingExercise = new BreathingExercise("Let's do a breathing exercise. Breathe in for 4 seconds, hold for 4 seconds, and exhale for 4 seconds.", 12);
        DeepQuestion deepQuestion = new DeepQuestion("Let's do a deep question. Here's your question:", new string[] { "What motivates you?", "What do you want to achieve in life?", "What do you want your legacy to be?" });
        GratitudeList gratitudeList = new GratitudeList("Let's write down things you're grateful for. Please enter 5 items.", 5);

        Console.WriteLine("Choose an activity: 1) Breathing Exercise, 2) Deep Question, 3) Gratitude List, 4) Exit");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                breathingExercise.Start();
                break;
            case 2:
                deepQuestion.Start();
                break;
            case 3:
                gratitudeList.Start();
                break;
            case 4:
                Console.WriteLine("Exiting...");
                return;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }
    }
}

