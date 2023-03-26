class Event
{
    public string title;
    private string description;
    public DateTime dateTime;
    private Address address;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        this.title = title;
        this.description = description;
        this.dateTime = dateTime;
        this.address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"{title}\n{description}\n{dateTime}\n{address.GetFormattedAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return $"{GetStandardDetails()}";
    }

    public virtual string GetShortDescription()
    {
        return $"Generic Event: {title} on {dateTime.Date.ToShortDateString()}";
    }
}
