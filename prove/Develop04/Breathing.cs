public class BreathingExercise : MindfulnessActivity
{
    private int duration;

    public BreathingExercise(string prompt, int duration)
    {
        this.prompt = prompt;
        this.duration = duration;
    }

    public override void Start()
    {
        Console.WriteLine(prompt);
        for (int i = duration; i >= 1; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
        Console.WriteLine("Great job!");
    }
}