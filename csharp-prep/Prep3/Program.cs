using System;

class MainClass {
  public static void Main(string[] args) {
    Random rnd = new Random();
    int randomNumber = rnd.Next(1, 101);
    int userGuess;
    Console.WriteLine("Please try to guess the random number between 1 and 100: ");
    while (true) {
    userGuess = Convert.ToInt32(Console.ReadLine());
        if (userGuess < randomNumber) {
            Console.WriteLine("Too Low! Guess again");
        }
        else if (userGuess > randomNumber) {
            Console.WriteLine("Too High! Guess again");
        }
        else {
            Console.WriteLine("Congratulations! You've guessed the number correctly.");
            break;
        }
    }
  }
}