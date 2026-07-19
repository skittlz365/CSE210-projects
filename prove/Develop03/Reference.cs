public class Reference
{
    private string _npBook { get; set; }
    private int _npChapter{ get; set; }
    private int[] _npVerses { get; set; }

    public Reference(string book, int chapter, params int[] verses)
    {
        _npBook = book;
        _npChapter = chapter;
        _npVerses = verses;
    }
    
    public override string ToString()
    {
        return $"{_npBook} {_npChapter}:{string.Join(":", _npVerses)}";
    }
}