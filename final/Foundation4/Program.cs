using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        RunningActivity running = new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0);
        CyclingActivity cycling = new CyclingActivity(new DateTime(2022, 12, 4), 60, 16);
        SwimmingActivity swimming = new SwimmingActivity(new DateTime(2023, 1, 25), 45, 30);

        // Add activities to list
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // Display summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}