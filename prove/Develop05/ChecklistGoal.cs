public class ChecklistGoal : Goal
{

    public int _repsTotal;
    public int _repsDone; 
    public int _bonus;

    public ChecklistGoal(string nameGoal,string typeGoal,  string descriptionGoal, int scoreGoal,bool achieved,int bonus, int repsTotal, int repsDone) : base(nameGoal, typeGoal, descriptionGoal, scoreGoal, achieved)
    {
        _repsTotal = repsTotal;
        _repsDone = repsDone;
        _bonus = bonus;

    }

    public override void Display()
    {
        Console.WriteLine($"[] {_nameGoal} ({_descriptionGoal}) -- Currently Completed: {_repsDone}/{_repsTotal} ");
    }

}