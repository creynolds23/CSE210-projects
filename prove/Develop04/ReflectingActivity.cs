public class ReflectingActivity : Activity
{
    private int _repTime = 10;
    private float _reps;
    private int _reflectCount = 0;

    // Activity activity = new Activity();
    List<string> _reflectingQuestions = new List<string>{"Why was this experience meaninful to you?",
                                                                  "Have you ever done anything like this before?",
                                                                  "How did you get started?",
                                                                  "How did you feel when it was complete?",
                                                                  "What made this time different than other times when you were not as successful?",
                                                                  "What is your favorite thing about this experience?",
                                                                  "What could ou learn from this experience that applies to other situations?",
                                                                  "What did you learn about yourself through this experience?",
                                                                  "How can you keep this experience in mind in the future?"};
    private List<string> _reflectingPrompts = new List<string>{"Think of a time when you stood up for someone else.",
                                                                "Think of a time when you did something really difficult.",
                                                                "Think of a time when you helped someone in need.",
                                                                "Think of a time when you did something truly selfless."};
    
    private string GetRandomReflectingPrompt()
    {
        Random random = new Random();
        int randint = random.Next(_reflectingPrompts.Count);
        string prompt = (_reflectingPrompts[randint]);
        return prompt;

    }
    private string GetRandomReflectingQuestion()
    {
        Random random = new Random();
        int randint = random.Next(_reflectingQuestions.Count);
        string _question = (_reflectingQuestions[randint]);
        return _question;

    }

    public override void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Reflecting Activity.\n");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other apsectsof your life.\n");
    }
    public void ReflectRep()
    {
        while (_repTime != 0 )
        {
            Console.Write(_repTime);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b");
            _repTime--;
        }
    }
    public void activeReflecting(int duration)
    {
        _reflectCount++;
        _reps = ((duration) / (_repTime));
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"---{GetRandomReflectingPrompt()}---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        if (_reps>0)
        {
            Console.Write($"Now ponder on each of the following questions as they relate to this experience.\nYou may begin in: ");
            ReflectRep();
            Console.Clear();
            while (_reps > 0)
            {
                Console.Write("\n" + GetRandomReflectingQuestion() + " ");
                Animation();
                _reps--;

            }
        }
        Console.WriteLine("\n\nWell Done!!\n");
        Console.WriteLine($"You have completed another {duration} seconds of the Reflecting Activity.");
        Animation();
        Thread.Sleep(2000);
        Animation();
        Console.Clear();
    }
    public int GetListCount()
    {
        return _reflectCount;
    }
}