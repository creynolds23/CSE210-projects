public class Program
{
    public static void Main()
    {
        
        int _totalpoints = 0;
        string userSelection = "";

        


       while (userSelection != "6")
       {
        SaveAndLoadGoals addToGoalList = new SaveAndLoadGoals();
        MenuDisplay();
        Console.Write("Select a choice from the menu: ");
        userSelection = Console.ReadLine();

        if (userSelection == "1")
        {
            Console.WriteLine("\nThe types of Goals are: ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string _typeGoal = Console.ReadLine();
            int _typeGoalint = Int32.Parse(_typeGoal);
            if (_typeGoalint == 1)
            {
                SimpleGoal sg = new SimpleGoal();
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string score = Console.ReadLine();
                int scoreInt = Int32.Parse(score);
                
                sg._nameGoal = name;
                sg._descriptionGoal = description;
                sg._scoreGoal = scoreInt;


                // SimpleGoal sg = new SimpleGoal(name, "Simple Goal", description, scoreInt, false);
                
                addToGoalList.AddList(sg);
            }
            // else if (_typeGoalint == 2)
            // {

            //     EternalGoal eg = new EternalGoal();
            // }
            // else if (_typeGoalint == 3)
            // {
            //     ChecklistGoal cg = new ChecklistGoal();
            // }

            
            
        }
        else if (userSelection == "2")
        {
            addToGoalList.DisplayGoal();

        }
        else if (userSelection == "3")
        {

        }
        else if (userSelection == "4")
        {

        }
        else if (userSelection == "5")
        {

        }
        static void MenuDisplay()
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Creat New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
        }
       }
    }
}