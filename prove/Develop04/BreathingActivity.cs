public class BreathingActivity : Activity
{
    private int _breathCount = 0;
    private int _repTime = 4;
    private float _reps;

    public override void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Breathing Activity.\n");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
    }

    public void BreathRep()
    {
        while (_repTime != 0 )
        {
            Console.Write(_repTime);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            _repTime--;
        }
    }

    public void activeBreathing(int duration)
    {
        _breathCount++;
        _reps = ((duration) / (_repTime*2));

        while (_reps > 0)
        {
            Console.Write("\nBreath in...");
            BreathRep();
            _repTime = 5;
            Console.Write("\nBreath out...");
            BreathRep();
            Console.WriteLine();
            _repTime = 5;
            _reps--;
        }
        Console.WriteLine("\nBreathing Exercise complete, Great Job!");
        Console.WriteLine($"You have completed another {duration} seconds of the Breathing Activity.");
        Thread.Sleep(2000);
        Animation();
        Console.Clear();
    }
    public int GetBreathCount()
    {
        return _breathCount;
    }


}