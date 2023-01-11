using System;
using System.Collections.Generic;

class MainClass {
  public static void Main(string[] args) {
    var numbers = new List<int>();
    Console.WriteLine("Enter a series of numbers, enter 0 to stop: ");
    int userInput;
    do {
        userInput = Convert.ToInt32(Console.ReadLine());
        if(userInput != 0) {
            numbers.Add(userInput);
        }
    } while (userInput != 0);

    int sum = 0;
    numbers.ForEach(n => sum += n);
    Console.WriteLine("The sum of the numbers is: " + sum);

    double average = sum / (double)numbers.Count;
    Console.WriteLine("The average of the numbers is: " + average);

    int max = numbers[0];
    foreach (int number in numbers) {
        if (number > max) {
            max = number;
        }
    }
    Console.WriteLine("The maximum number is: " + max);
  }
}