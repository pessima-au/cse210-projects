public class Event
{
    protected string title;
    protected string description;
    protected string date;
    protected string time;
    protected Address address;

    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public virtual string StandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address}";
    }

    public virtual string FullDetails()
    {
        return $"{StandardDetails()}\nType: {this.GetType().Name}";
    }

    public virtual string ShortDescription()
    {
        return $"Type: {this.GetType().Name}\nTitle: {title}\nDate: {date}";
    }
}
