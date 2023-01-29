public class Entry
{
    public List<string> _prompts = new List<string>{"What was the best part of your day?", 
                                                "If you could, what would you change about today?",
                                                "Who did you speak with today?", 
                                                "Where did you go today?", 
                                                "What things did you see today?",
                                                "What was the strongest emotion you felt today?",
                                                "What was your favorite food you ate today?",
                                                "What is one example of the Lord's hand in your day today?"};
    DateTime Today = DateTime.Today;
    public string _date;
    public string _promptQuestion;
    public string _userText;
     public string _GetPrompt()
     {
        Random randint = new Random();
        int randnumber = randint.Next(_prompts.Count);
        string prompt = (_prompts[randnumber]);
        return prompt;
        // Console.Write($"{prompt} \n>");
        // string userResponse = Console.ReadLine();
        // string _Date = Today.ToString("MM/dd/yyyy");
        // _entry = ($"{_Date}:{prompt}:{userResponse}");
      //   return _entry;
     }

     public void Display()
     {
      Console.WriteLine($"Date: {_date} --- Prompt: {_promptQuestion}");
      Console.WriteLine(_userText);
     }

}