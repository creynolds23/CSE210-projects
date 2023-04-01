public class EternalGoal : Goal
{
    // public string _nameGoal;
    // public string _typeGoal;
    // public string _descriptionGoal;
    // public int _scoreGoal;

    public EternalGoal(string nameGoal, string typeGoal,  string descriptionGoal, int scoreGoal, bool achieved) : base(nameGoal,typeGoal,descriptionGoal,scoreGoal, achieved)
    {

    }

    public override void Display()
    {
        Console.WriteLine($"[ ] {_nameGoal} ({_descriptionGoal})");
    }
}