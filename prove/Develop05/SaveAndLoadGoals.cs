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
                if (goal is SimpleGoal simpleGoal)
                {
                    string _scoreGoalStringS = simpleGoal._scoreGoal.ToString();
                    string _achieved = simpleGoal._achieved.ToString();
                    outputFile.WriteLine($"Simple Goal,{simpleGoal._nameGoal},{simpleGoal._descriptionGoal},{_scoreGoalStringS},{simpleGoal._achieved}");
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    string _scoreGoalStringE = eternalGoal._scoreGoal.ToString();
                    string _achieved = eternalGoal._achieved.ToString();
                    outputFile.WriteLine($"Eternal Goal,{eternalGoal._nameGoal},{eternalGoal._descriptionGoal},{_scoreGoalStringE},{eternalGoal._achieved}");

                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    string _scoreGoalStringC = checklistGoal._scoreGoal.ToString();
                    string _repsDone = checklistGoal._repsDone.ToString();
                    string _repsTotal = checklistGoal._repsTotal.ToString();
                    string _bonus = checklistGoal._bonus.ToString();
                    string _achieved = checklistGoal._achieved.ToString();
                    outputFile.WriteLine($"Checklist Goal,{checklistGoal._nameGoal},{checklistGoal._descriptionGoal},{_scoreGoalStringC},{checklistGoal._achieved},{checklistGoal._bonus},{checklistGoal._repsTotal},{checklistGoal._repsDone}");
                }
            }
        }
    }

    public void GoalLoad(string filename)
    {
        _goalsList = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string [] parts = line.Split(",");
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int scoreGoal = Convert.ToInt32(parts[3]);
            bool achieved = Convert.ToBoolean(parts[4]);
            switch (parts[0])
            {
                case "Simple Goal":
                    _goalsList.Add(new SimpleGoal(name,type,description,scoreGoal,achieved));
                    break;
                case "Eternal Goal":
                    _goalsList.Add(new EternalGoal(name,type,description,scoreGoal,achieved));
                    break;
                case "Checklist Goal":
                    int bonus = Convert.ToInt32(parts[5]);
                    int repsTotal = Convert.ToInt32(parts[6]);
                    int repsDone = Convert.ToInt32(parts[7]);
                    _goalsList.Add(new ChecklistGoal(name,type,description,scoreGoal, achieved, bonus, repsTotal,repsDone));
                    break;
                
            }
        }

    }
    public void DisplayGoal()
    {
        int indexNum = 0;
        foreach (Goal goal in _goalsList)
        {
            indexNum++;
            Console.Write($"{indexNum}. ");
            goal.Display();
        }
    }
}