class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime dateTime, Address address, string weather) : base(title, description, dateTime, address)
    {
        this._weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nEvent Type: Outdoor Gathering\nWeather: {_weather}";
    }

    public override string GetShortDescription()
    {
        return $"Outdoor Gathering: {_title} on {_dateTime.Date.ToShortDateString()}";
    }
}