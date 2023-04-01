public class Program
{
    public static void Main()
    {
        SaveAndLoadGoals addToGoalList = new SaveAndLoadGoals();
        
        int _totalpoints = 0;
        string userSelection = "";

        


       while (userSelection != "6")
       {
        MenuDisplay();
        Console.Write("Select a choice from the menu: ");
        userSelection = Console.ReadLine();

        if (userSelection == "1")
        {
            Console.WriteLine("\nThe types of Goals are: ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string _typeGoal = Console.ReadLine();
            int _typeGoalint = Int32.Parse(_typeGoal);
            if (_typeGoalint == 1)
            {
                // SimpleGoal sg = new SimpleGoal();
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string score = Console.ReadLine();
                int scoreInt = Int32.Parse(score);
                bool achieved = false;

                SimpleGoal sg = new SimpleGoal(name, "Simple Goal", description, scoreInt, achieved);
                
                addToGoalList.AddList(sg);
            }
            else if (_typeGoalint == 2)
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string score = Console.ReadLine();
                int scoreInt = Int32.Parse(score);
                bool achieved = false;

                EternalGoal eg = new EternalGoal(name, "Eternal Goal", description, scoreInt, achieved);
                addToGoalList.AddList(eg);
            }
            else if (_typeGoalint == 3)
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string score = Console.ReadLine();
                int scoreInt = Int32.Parse(score);
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string repGoal = Console.ReadLine();
                int repGoalInt = Int32.Parse(repGoal);
                Console.Write("What is the bonus for accomplishing it that many times? ");
                string bonus = Console.ReadLine();
                int bonusInt = Int32.Parse(bonus);
                int repsDone=0;
                bool achieved = false;

                ChecklistGoal cg = new ChecklistGoal(name, "Checklist Goal", description, scoreInt, achieved, bonusInt, repGoalInt, repsDone);
                addToGoalList.AddList(cg);
            }

            
            
        }
        else if (userSelection == "2")
        {
            // Console.WriteLine("here");
            addToGoalList.DisplayGoal();

        }
        else if (userSelection == "3")
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();
            addToGoalList.SaveGoal(filename);

        }
        else if (userSelection == "4")
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();
            addToGoalList.GoalLoad(filename);
        }
        else if (userSelection == "5")
        {

        }
        static void MenuDisplay()
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
        }
       }
    }
}