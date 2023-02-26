public class Activity
{
    private int _duration = 0;
    private string _message;
    private string _prompt;

    
                                                    
    // public Activity(int duration, string message, string prompt)
    // {
    //     _duration = duration;
    //     _message = message;
    //     _prompt = prompt;
    // }

    private List<string> _animationString = new List<string>{"|", "/","-","\\","|","/","-","\\"};





    // public virtual void Duration()
    // {
        
    //     Console.Write("How long, in seconds, would you like for your session? ");
    //     // string userDuration = Console.ReadLine();
    //     // _duration = int.Parse(userDuration);
    //     // return _duration;
        

    // }
    public virtual void DisplayMessage()
    {
        Console.WriteLine("");
    }
    public  void Animation()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = _animationString[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;

            if (i >= _animationString.Count)
            {
                i = 0;
            }
        }
    }

}