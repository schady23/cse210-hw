public class GratitudeList : MindfulnessActivity
{
    private int numItems;

    public GratitudeList(string prompt, int numItems)
    {
        this.prompt = prompt;
        this.numItems = numItems;
    }

    public override void Start()
    {
        Console.WriteLine(prompt);
        for (int i = 1; i <= numItems; i++)
        {
            Console.Write($"{i}. ");
            string item = Console.ReadLine();
            if (string.IsNullOrEmpty(item))
            {
                Console.WriteLine("Please enter a valid item.");
                i--;
            }
        }
        Console.WriteLine("Great job!");
    }
}
