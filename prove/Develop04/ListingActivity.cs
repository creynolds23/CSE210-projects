public class ListingActivity : Activity
{

    private int _repTime = 7;
    private int _listCount = 0;
    private List<string> _listingPrompts = new List<string>{"Who are people that you appreciate?",
                                                     "What are personal strengths of yours?",
                                                     "Who are people that you have helped this week?",
                                                     "When have you felt the Holy Ghost this month?",
                                                     "Who are some of your personal heroes"};

    private string GetRandomListingPrompt()
    {
        Random random = new Random();
        int randint = random.Next(_listingPrompts.Count);
        string prompt = (_listingPrompts[randint]);
        return prompt;

    }
    public void ListRep()
    {
        while (_repTime != 0 )
        {
            Console.Write(_repTime);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b");
            _repTime--;
        }
    }
    public override void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Listing Activity.\n");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
    }

    public void activeListing(int duration)
    {
        _listCount++;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{GetRandomListingPrompt()}---");
        Console.Write("You may begin in: ");
        ListRep();
        Console.WriteLine();
        int listedItems = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            
            listedItems++;
        }
        Console.WriteLine($"You listed {listedItems} items!\n");
        Console.WriteLine("Well Done!!");
        Thread.Sleep(2000);
        Animation();
        Console.Clear();

    }
    public int GetListCount()
    {
        return _listCount;
    }
}