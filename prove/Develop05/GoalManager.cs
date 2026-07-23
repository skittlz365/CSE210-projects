using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    // This class stores a list of goals and manages them
    private List<Goal> _npGoals = new List<Goal>();
    private int _npScore = 0;

    public int Score => _npScore;

    public void AddGoal(Goal g)
    {
        _npGoals.Add(g);
    }

    public void ListGoals()
    {
        if (_npGoals.Count == 0)
        {
            Console.WriteLine("No goals defined.");
            return;
        }
        int i = 1;
        foreach (var g in _npGoals)
        {
            Console.WriteLine($"{i}. {g.GetDetailsString()}");
            i++;
        }
    }

    public void RecordEventForGoal(int index)
    {
        if (index < 0 || index >= _npGoals.Count) return;
        var g = _npGoals[index];
        int npEarned = g.RecordEvent();
        _npScore += npEarned;
        Console.WriteLine($"You earned {npEarned} points!");
    }

    public void SaveToFile(string path)
    {
        using (var sw = new StreamWriter(path))
        {
            sw.WriteLine(_npScore);
            foreach (var g in _npGoals)
            {
                sw.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadFromFile(string path)
    {
        _npGoals.Clear();
        if (!File.Exists(path)) return;
        var npLines = File.ReadAllLines(path);
        if (npLines.Length == 0) return;
        if (!int.TryParse(npLines[0], out _npScore)) _npScore = 0;
        for (int i = 1; i < npLines.Length; i++)
        {
            var npParts = npLines[i].Split('|');
            if (npParts.Length == 0) continue;
            string type = npParts[0];
            try
            {
                if (type == "Simple")
                {
                    // Simple|name|desc|points|completed
                    string npName = npParts[1];
                    string npDesc = npParts[2];
                    int npPoints = int.Parse(npParts[3]);
                    bool npCompleted = bool.Parse(npParts[4]);
                    var s = new SimpleGoal(npName, npDesc, npPoints);
                    if (npCompleted) s.RecordEvent();
                    _npGoals.Add(s);
                }
                else if (type == "Eternal")
                {
                    // Eternal|name|desc|points|times
                    string npName = npParts[1];
                    string npDesc = npParts[2];
                    int npPoints = int.Parse(npParts[3]);
                    int npTimes = int.Parse(npParts[4]);
                    var e = new EternalGoal(npName, npDesc, npPoints);
                    for (int t = 0; t < npTimes; t++) e.RecordEvent();
                    _npGoals.Add(e);
                }
                else if (type == "Checklist")
                {
                    // Checklist|name|desc|points|current|target|bonus
                    string npName = npParts[1];
                    string npDesc = npParts[2];
                    int npPoints = int.Parse(npParts[3]);
                    int npCurrent = int.Parse(npParts[4]);
                    int npTarget = int.Parse(npParts[5]);
                    int npBonus = int.Parse(npParts[6]);
                    var c = new ChecklistGoal(npName, npDesc, npPoints, npTarget, npBonus);
                    for (int t = 0; t < npCurrent; t++) c.RecordEvent();
                    _npGoals.Add(c);
                }
            }
            catch
            {
                // skip malformed lines
            }
        }
    }

    public int GoalCount() => _npGoals.Count;
}
