public class SimpleGoal : Goal
{
    public string _nameGoal;
    public string _typeGoal;
    public string _descriptionGoal;
    public int _scoreGoal;

    public bool _achieved = false;
    // public SimpleGoal(string nameGoal, string typeGoal, string descriptionGoal, int scoreGoal, bool achieved) : base(nameGoal, typeGoal, descriptionGoal, scoreGoal)
    // {
    //     _achieved = achieved;
    // }
    // public bool CheckAchieved(bool achieved)
    // {
    //     if (achieved == true)
    //     {
    //         return true;
    //     }
    //     else if (achieved == false)
    //     {
    //         return false;
    //     }
    // }


    public override void Display()
    {
        Console.WriteLine($"[ ] {_nameGoal} ({_descriptionGoal}) ");
    }
}