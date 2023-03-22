public class Address
{
    public string _street { get; }
    public string _city { get; }
    public string _state { get; }
    public string _country { get; }

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country == "USA";
    }

    public override string ToString()
    {
        return $"{_street}\n{_city}, {_state} {_country}";
    }
}