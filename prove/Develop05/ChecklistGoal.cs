using System;

public class ChecklistGoal : Goal
{
    // ChecklistGoal inherits from Goal, it has 3 more attributes
	private int _npTargetCount;
	private int _npCurrentCount = 0;
	private int _npBonus;

	public ChecklistGoal(string name, string description, int pointsPerEvent, int targetCount, int bonus) : base(name, description, pointsPerEvent)
	{
		_npTargetCount = targetCount;
		_npBonus = bonus;
	}

    // Polymorphism in action
	public override int RecordEvent()
	{
		if (_npCurrentCount >= _npTargetCount)
		{
			return 0;
		}

		_npCurrentCount++;
		int npEarned = _npPoints;
		if (_npCurrentCount >= _npTargetCount)
		{
			// reached target, award bonus
			npEarned += _npBonus;
		}
		return npEarned;
	}

	public override bool IsComplete()
	{
		return _npCurrentCount >= _npTargetCount;
	}

	public override string GetDetailsString()
	{
		string npStatus = IsComplete() ? "[X]" : "[ ]";
		return $"{npStatus} {_npShortName} ({_npDescription}) -- Completed {_npCurrentCount}/{_npTargetCount} times";
	}

	public override string GetStringRepresentation()
	{
		return $"Checklist|{_npShortName}|{_npDescription}|{_npPoints}|{_npCurrentCount}|{_npTargetCount}|{_npBonus}";
	}
}