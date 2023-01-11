using System;

class MainClass {
    public static void DisplayWelcome() {
        Console.WriteLine("Welcome to the Program!");
    }
    public static string PromptUserName() {
        Console.WriteLine("Please enter your name: ");
        return Console.ReadLine();
    }
    public static int PromptUserNumber() {
        Console.WriteLine("Please enter your favorite number: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    public static int SquareNumber(int number) {
        return number * number;
    }
    public static void DisplayResult(string name, int number) {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Square of the favorite number: " + number);
    }

    public static void Main(string[] args) {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);
    }
}

