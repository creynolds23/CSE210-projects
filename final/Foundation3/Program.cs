class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "ID", "12345");
        Address address2 = new Address("456 Elm St", "Othertown", "CA", "67890");
        Address address3 = new Address("789 Maple St", "Thistown", "MA", "23456");

        Lecture lecture = new Lecture("Electronic Devices Lecture", "Learn about transistors and diodes", new DateTime(2023, 4, 15, 13, 30, 0), address1, "Jane", 50);

        Reception reception = new Reception("Best Friend's Wedding Reception", "Wedding reception for best friend, bring present.", new DateTime(2023, 4, 20, 17, 0, 0), address2, "rsvp@company.com");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Wilderness Survival", "Methods and ways for better wilderness survival", new DateTime(2023, 4, 25, 10, 0, 0), address3, "Sunny");

        // Call methods on each event to generate marketing messages
        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine();

        Console.WriteLine("Reception:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}
