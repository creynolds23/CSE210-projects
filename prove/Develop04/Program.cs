class Program
{
    public static void Main()
    {
        string userSelection = "";
        while (userSelection != "5")
        {
            MenuDisplay();
            Console.Write("Select a choice from the menu: ");
            userSelection = Console.ReadLine();

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
            }
            else if (userSelection == "4")
            {

            }

    static void MenuDisplay()
    {
        // Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4.Display Session Results");
        Console.WriteLine("5. Quit");
    }

        }

    }

}
