// Abstract base class for goals
public abstract class Goal
{
    protected string _shortName { get; private set; }
    protected string _description { get; private set; }
    public int _points { get; private set; }

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();
}
