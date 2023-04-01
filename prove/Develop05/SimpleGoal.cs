public class SimpleGoal : Goal
{
    // public string _nameGoal;
    // public string _typeGoal;
    // public string _descriptionGoal;
    // public int _scoreGoal;
    
    public SimpleGoal(string nameGoal, string typeGoal, string descriptionGoal, int scoreGoal, bool achieved) : base(nameGoal, typeGoal, descriptionGoal, scoreGoal, achieved)
    {

    }

    public override void IsFinished(int userValue)
    {
        
    }


    public override void Display()
    {
        Console.WriteLine($"[{_achieved}] {_nameGoal} ({_descriptionGoal}) ");
    }
    // public override string GetStringFormat()
    // {
    //     string _scoreGoalString = _scoreGoal.ToString();
    //     return Console.WriteLine($"SimpleGoal:{_nameGoal},{_descriptionGoal},{_scoreGoalString},{_achieved}");
    // }
}