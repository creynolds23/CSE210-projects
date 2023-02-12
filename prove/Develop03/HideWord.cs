public class HideWord
{
    public string _hiddenPhrase  = "";
    public HideWord()
    {
        _hiddenPhrase = "";
    }
    public void Hide(string referencePhrase, string scriptPhrase)
    {
        Random rand = new Random();
        Reference refer = new Reference();
        // string _hiddenPhrase = "";
        string[] sepScriptText = scriptPhrase.Split(" ");
        int wordCount = sepScriptText.Length;
        bool[] wordHidden = new bool[wordCount];
        Console.WriteLine(referencePhrase + scriptPhrase);
        Console.WriteLine();

        // Console.WriteLine("Press Enter to hide a random word in the phrase. type 'quit' to end the program.");
        // Console.WriteLine(referencePhrase + " " + scriptPhrase);
        while (wordHidden.Contains(false))
        {
            int wordToHide = rand.Next(wordCount);
            int wordToHide2 = rand.Next(wordCount);
            
            while (wordHidden[wordToHide] || wordToHide == wordToHide2)
            {
                wordToHide = rand.Next(wordCount);
            }

            while (wordHidden[wordToHide2] || wordToHide == wordToHide2)
            {
                wordToHide2 = rand.Next(wordCount);
            }

            wordHidden[wordToHide] = true;
            wordHidden[wordToHide2] = true;

            string _hiddenPhrase = string.Join(" ", sepScriptText.Select((w, i) => wordHidden[i] ? "_____" : w));
            Console.WriteLine("\nPress Enter to Hide more words, or type 'quit' to end the program.");
            Console.WriteLine(referencePhrase + _hiddenPhrase);
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            Console.Clear();
            // string input = Console.ReadLine();
            // if (input == "quit")
            // {
            //     break;
            // }
            // int hiddenWordIndex = intnumber.Next(0, sepScriptText.Length);
            // _hiddenPhrase += new String('_', sepScriptText[hiddenWordIndex].Length) + " ";
            // Console.Clear();
            // Console.WriteLine("Press Enter to hide a random word in the phrase. Type 'quit' to end the program.");
            // Console.WriteLine(referencePhrase + _hiddenPhrase + scriptPhrase.Substring(_hiddenPhrase.Length));
        }
    }
}