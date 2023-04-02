class Event
{
    public string _title;
    private string _description;
    public DateTime _dateTime;
    private Address _address;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        this._title = title;
        this._description = description;
        this._dateTime = dateTime;
        this._address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"{_title}\n{_description}\n{_dateTime}\n{_address.GetFormattedAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return $"{GetStandardDetails()}";
    }

    public virtual string GetShortDescription()
    {
        return $"Generic Event: {_title} on {_dateTime.Date.ToShortDateString()}";
    }
}
