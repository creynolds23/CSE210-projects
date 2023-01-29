public class Program
{
    public static void Main()
    {
        JournalEntries journal = new JournalEntries();
        Entry entry = new Entry();
        
        string userSelection = "";
        while (userSelection != "6")
        {
            MenuDisplay();
            Console.Write("What would you like to do? ");
            userSelection = Console.ReadLine();

            if (userSelection == "1")
            {
                string prompt = entry._GetPrompt();
                Console.WriteLine(prompt);
                Console.Write("---");
                string userText = Console.ReadLine();
                DateTime Today = DateTime.Today;
                string date = Today.ToString("MM/dd/yyyy");
                
                entry._date = date;
                entry._userText = userText;
                entry._promptQuestion = prompt;
                journal.AddEntry(entry);
                
                
            }
            else if (userSelection == "2")
            {
                journal.DisplayJournal();
            }
            else if (userSelection == "3")
            {
                Console.WriteLine("What is the name of the file? ");
                string filename = Console.ReadLine();
                journal.JournalLoad(filename);
            }
            else if (userSelection == "4")
            {
                Console.WriteLine("What is the name of the file? ");
                string filename = Console.ReadLine();
                journal.SaveJournal(filename);
            }
            else if (userSelection == "5")
            {
                Console.Write("What index number of entry would you like to remove? ");
                string removeIndexString = Console.ReadLine();
                int removeIndex = Int32.Parse(removeIndexString);
                journal.RemoveEntryFromJournal(removeIndex);
            }
    static void MenuDisplay()
    {
        Console.WriteLine("\nPlease select one of the following choices (entering the number 1-5); ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Remove");
        Console.WriteLine("6. Quit");
        Console.WriteLine("");
    }
            
        }

    }       

}