using System;

public class EternalGoal : Goal
{
    // EternalGoal inherits from Goal, and only has one extra attribute
	private int _npTimesRecorded = 0;

	public EternalGoal(string name, string description, int points) : base(name, description, points)
	{
	}

    // Polymorphism in action
	public override int RecordEvent()
	{
		_npTimesRecorded++;
		return _npPoints;
	}

	public override bool IsComplete()
	{
		return false;
	}

	public override string GetDetailsString()
	{
		return $"[ ] {_npShortName} ({_npDescription}) -- Recorded {_npTimesRecorded} times";
	}

	public override string GetStringRepresentation()
	{
		return $"Eternal|{_npShortName}|{_npDescription}|{_npPoints}|{_npTimesRecorded}";
	}
}