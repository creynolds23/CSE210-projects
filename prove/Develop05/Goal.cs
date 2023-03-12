public class Goal
{
    string _nameGoal;
    string _typeGoal;
    string _descriptionGoal;
    int _scoreGoal;



// public Goal(string nameGoal, string typeGoal, string descriptionGoal, int scoreGoal)
// {
//     _nameGoal = nameGoal;
//     _typeGoal = typeGoal;
//     _descriptionGoal = descriptionGoal;
//     _scoreGoal = scoreGoal;
// }

    public virtual void GoalPrep()
    {
        
    }
    
    public virtual void Display()
    {

         Console.WriteLine($"[ ] {_nameGoal} ({_descriptionGoal})");
    }
    
}