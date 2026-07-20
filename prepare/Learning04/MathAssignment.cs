public class MathAssignment : Assignment
{
    private string _npTextbookSection;
    private string _npProblems;
    public MathAssignment(string npName, string npTopic, string npSection, string npProblems) : base(npName, npTopic)
    {
        _npTextbookSection = npSection;
        _npProblems = npProblems;
    }

    public string GetHomeworkList()
    {
        string npHomeworkList = ($"Section {_npTextbookSection} Problems {_npProblems}");
        return npHomeworkList;
    }

}