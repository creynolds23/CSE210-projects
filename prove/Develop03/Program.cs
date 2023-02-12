using System;
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");
        RandomScript randoms = new RandomScript();
        string wholeScript = randoms.GetRandomScript();
        Reference reference = new Reference();
        string  referenceText = reference.GetReferencePart(wholeScript);
        string scriptText = reference.GetSepScriptText(wholeScript);

        HideWord phrase = new HideWord();
        phrase.Hide(referenceText, scriptText);
    }
}