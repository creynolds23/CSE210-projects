public abstract class Goal
{
    public string _nameGoal;
    public string _typeGoal;
    public string _descriptionGoal;
    public int _scoreGoal;
    public bool _achieved;



public Goal(string nameGoal, string typeGoal, string descriptionGoal, int scoreGoal, bool achieved)
{
    _nameGoal = nameGoal;
    _typeGoal = typeGoal;
    _descriptionGoal = descriptionGoal;
    _scoreGoal = scoreGoal;
    _achieved = achieved;
}

    public virtual void GoalPrep()
    {
        
    }
    
    public virtual void Display()
    {

    }
    public virtual void IsFinished(int userValue)
    {

    }

    // public abstract string GetStringFormat();
}