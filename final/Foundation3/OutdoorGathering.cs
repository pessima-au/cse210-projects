public class OutdoorGathering : Event
{
    private string weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        this.weather = weather;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nWeather: {weather}";
    }

    public override string ShortDescription()
    {
        return $"Outdoor Gathering: {title} on {date}";
    }
}
