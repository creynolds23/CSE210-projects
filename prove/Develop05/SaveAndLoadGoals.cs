public class SaveAndLoadGoals
{


    private List<Goal> _goalsList = new List<Goal>();
     


    public void AddList(Goal goalNew)
    {
        _goalsList.Add(goalNew);
    }
    
    public void SaveGoal(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goalsList)
            {
                outputFile.WriteLine($"");
            }
        }
    }

    public void GoalLoad(string filename)
    {
        _goalsList = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            // string [] parts = line.Split
        }
    }
    public void DisplayGoal()
    {
        foreach (Goal goal in _goalsList)
        {
            goal.Display();
        }
    }
}