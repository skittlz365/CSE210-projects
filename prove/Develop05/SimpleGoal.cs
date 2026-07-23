using System;

public class SimpleGoal : Goal
{
    // SimpleGoal inherits from Goal, it has only one extra attribute
	private bool _npCompleted = false;

	public SimpleGoal(string name, string description, int points) : base(name, description, points)
	{
	}

    // Polymorphism in action
	public override int RecordEvent()
	{
		if (!_npCompleted)
		{
			_npCompleted = true;
			return _npPoints;
		}
		return 0;
	}

	public override bool IsComplete()
	{
		return _npCompleted;
	}

	public override string GetDetailsString()
	{
		string npStatus = _npCompleted ? "[X]" : "[ ]";
		return $"{npStatus} {_npShortName} ({_npDescription})";
	}

	public override string GetStringRepresentation()
	{
		return $"Simple|{_npShortName}|{_npDescription}|{_npPoints}|{_npCompleted}";
	}
}