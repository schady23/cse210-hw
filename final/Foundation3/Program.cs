using System;

class Program {
    static void Main(string[] args) {
        Address address1 = new Address("4400 Sett Street", "Riverside", "CA", "12345");
        Lecture lecture1 = new Lecture("How to Code", "Learn the basics of coding", new DateTime(2023, 4, 1), new TimeSpan(10, 0, 0), address1, "John Denver", 50);

        Address address2 = new Address("456 Oak Ave", "Plano", "TX", "67890");
        Reception reception1 = new Reception("Networking Event", "Meet and greet with industry professionals", new DateTime(2023, 4, 15), new TimeSpan(18, 0, 0), address2, "rsvp@gmail.com");

        Address address3 = new Address("789 Pine St", "Albany", "NY", "54321");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Picnic in the Park", "Enjoy a day in the sun with friends and family", new DateTime(2023, 5, 1), new TimeSpan(12, 0, 0), address3, "Sunny and warm");

        Console.WriteLine("Lecture\n");
        Console.WriteLine(lecture1.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n");
        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine("\nShort Description:\n");
        Console.WriteLine(lecture1.GetShortDescription());

        Console.WriteLine("\n\nReception\n");
        Console.WriteLine(reception1.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n");
        Console.WriteLine(reception1.GetFullDetails());
        Console.WriteLine("\nShort Description:\n");
        Console.WriteLine(reception1.GetShortDescription());

        Console.WriteLine("\n\nOutdoor Gathering\n");
        Console.WriteLine(outdoorGathering1.GetStandardDetails());
        Console.WriteLine("\nFull Details:\n");
        Console.WriteLine(outdoorGathering1.GetFullDetails());
        Console.WriteLine("\nShort Description:\n");
        Console.WriteLine(outdoorGathering1.GetShortDescription());

        Console.ReadLine();
    }
}