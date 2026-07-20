public class Assignment
{
    private string _npStudentName;
    private string _npTopic;

    public Assignment(string name, string topic)
    {
        _npStudentName = name;
        _npTopic = topic;
    }

    public string npGetSummary()
    {
        string npSummary = ($"{_npStudentName} - {_npTopic}");
        return npSummary;
    }

    public string npGetStudentName()
    {
        return _npStudentName;
    }
}