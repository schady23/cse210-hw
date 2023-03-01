public class DeepQuestion : MindfulnessActivity
{
    private string[] questions;

    public DeepQuestion(string prompt, string[] questions)
    {
        this.prompt = prompt;
        this.questions = questions;
    }

    public override void Start()
    {
        Random rand = new Random();
        Console.WriteLine(prompt);
        int index = rand.Next(questions.Length);
        Console.WriteLine(questions[index]);
        Thread.Sleep(5000);
        Console.WriteLine("How did that make you feel?");
    }
}