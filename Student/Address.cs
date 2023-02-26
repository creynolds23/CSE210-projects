public class Address
{
    string _street;
    string _city;
    string _state;
    string _postalCode;
    bool _validated = false;

    public Address(string street, string city, string state, string postalCode)
    {
        _street = street;
        _city = city;
        _state = state;
        _postalCode = postalCode;

    }

    public void Validate()
    {
        _validated = true;
    }

    public void OutputAsLabel()
    {
        Console.WriteLine($"{_street}\n{_city}, {_state} {_postalCode}");
    }
}