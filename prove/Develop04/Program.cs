class Program
{
    public static void Main()
    {
        int counter = 0;
        string userSelection = "";
        while (userSelection != "5")
        {
            // Activity counter = new Activity();
            MenuDisplay();
            Console.Write("Select a choice from the menu: ");
            userSelection = Console.ReadLine();
            // counter.CountMethod();
            counter++;

            if (userSelection == "1")
            {
                Console.Clear();
                BreathingActivity breath = new BreathingActivity();
                breath.DisplayMessage();
                Console.Write("How long, in seconds, would you like for your session? ");
                string userDuration = Console.ReadLine();
                int duration = int.Parse(userDuration);
                Console.Clear();
                Console.WriteLine("Get ready...\n");
                breath.Animation();
                Console.Clear();
                Console.WriteLine("Get ready...");
                breath.activeBreathing(duration);
                // int countBreath = breath.GetBreathCount();
            }

            else if (userSelection == "2")
            {
                Console.Clear();
                ReflectingActivity reflect = new ReflectingActivity();
                reflect.DisplayMessage();
                Console.Write("How long, in seconds, would you like for your session? ");
                string userDuration = Console.ReadLine();
                int duration = int.Parse(userDuration);
                Console.Clear();
                Console.WriteLine("Get ready...\n");
                reflect.Animation();
                Console.Clear();
                Console.WriteLine("Get ready...");
                reflect.activeReflecting(duration);
                // int countReflect = reflect.GetListCount();

            }

            else if (userSelection == "3")
            {
                Console.Clear();
                ListingActivity list = new ListingActivity();
                list.DisplayMessage();
                Console.Write("How long, in seconds, would you like for your sessions? ");
                string userDuration = Console.ReadLine();
                int duration = int.Parse(userDuration);
                Console.Clear();
                Console.WriteLine("Get ready...\n");
                list.Animation();
                Console.Clear();
                Console.WriteLine("Get ready...");
                list.activeListing(duration);
                // int countList = list.GetListCount();

            }
            else if (userSelection == "4")
            {
                // ListingActivity list = new ListingActivity();
                // BreathingActivity breath = new BreathingActivity();
                // ReflectingActivity reflect = new ReflectingActivity();
                // int countList = list.GetListCount();
                // int countBreath = breath.GetBreathCount();
                // int countReflect = reflect.GetReflectCount();
                Console.Clear();
                // int countNum = counter.GetCountMethod();
                Console.WriteLine($"You have done {counter-1} activities in todays Session! Congrats!");
                // Console.WriteLine("Your Session's Resutls are:");
                // Console.WriteLine($"{bcounter} times of the Breathing Activity");
                // Console.WriteLine($"{rcounter} times of the Reflecting Activity");
                // Console.WriteLine($"{lcounter} times of the Listing Activity");

            }

    static void MenuDisplay()
    {
        // Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Display Session Results");
        Console.WriteLine("5. Quit");
    }

        }

    }

}
