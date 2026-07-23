using System;

public abstract class Goal
{
    // Base class for all the different types of goals
    protected string _npShortName;
    protected string _npDescription;
    protected int _npPoints;

    public Goal(string name, string description, int points)
    {
        _npShortName = name;
        _npDescription = description;
        _npPoints = points;
    }

    // Record an event and return how many points were earned for that event.
    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string npStatus = IsComplete() ? "[X]" : "[ ]";
        return $"{npStatus} {_npShortName} ({_npDescription})";
    }

    // A string representation suitable for saving/loading
    public abstract string GetStringRepresentation();

    public virtual int GetPoints()
    {
        return _npPoints;
    }
}