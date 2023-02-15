public class DVD : Loanable
{
    private string _title;
    private int _upc;
    private string _genre;
    private int _duration;

    public DVD(string title, int upc, string genre, int duration)
    {
        _title = title;
        _upc = upc;
        _genre = genre;
        _duration = duration;
    }

    public void ShowDVDDetails()
    {
        Console.WriteLine($"{_title} ({_genre}): {_upc} {_duration} ");
    }
}