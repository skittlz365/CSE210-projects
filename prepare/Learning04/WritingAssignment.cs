public class WritingAssignment : Assignment
{
    private string _npTitle;

    public WritingAssignment(string npName, string npTopic, string npTitle) : base(npName, npTopic)
    {
        _npTitle = npTitle;
    }

    public string npGetWritingInformation()
    {
        string npName = npGetStudentName();
        string npWritingInfo = ($"{_npTitle} by {npName}");
        return npWritingInfo;
    }
}