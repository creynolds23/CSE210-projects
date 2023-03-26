class OutdoorGathering : Event
{
    private string weather;

    public OutdoorGathering(string title, string description, DateTime dateTime, Address address, string weather) : base(title, description, dateTime, address)
    {
        this.weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nEvent Type: Outdoor Gathering\nWeather: {weather}";
    }

    public override string GetShortDescription()
    {
        return $"Outdoor Gathering: {title} on {dateTime.Date.ToShortDateString()}";
    }
}