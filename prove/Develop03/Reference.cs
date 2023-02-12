public class Reference
{
    private string _reference;
    private string _scriptureText;


    public string GetReferencePart(string script)
    {
        // RandomScript script = new RandomScript();
        // string randScript = script.GetRandomScript();
        string[] reference = script.Split("/");
        foreach (string x in reference)
        {
            _reference = reference[0];
            _scriptureText = reference[1];


        }
        return _reference;
        
    }
    
    public string GetSepScriptText(string script)
    {
        string[] reference = script.Split("/");
        foreach (string x in reference)
        {
            _reference = reference[0];
            _scriptureText = reference[1];
        }
        return _scriptureText;
        
    }
}