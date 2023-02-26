public class Person 
{
    string _name;
    Address _homeAddress;
    string _emailAddress;


    public Person(string name, Address homeAddress, string emailAddress)
    {
        _name = name;
        _homeAddress = homeAddress;
        _emailAddress = emailAddress;
    }

    public void ShowEmails()
    {
        Console.WriteLine($"Getting emails for {_emailAddress}");
    }

    public void ShowAddress()
    {
        _homeAddress.OutputAsLabel();
    }
}