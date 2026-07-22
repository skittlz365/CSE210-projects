public class Reference
{
    // This class has 3 private attributes, Book, Chapter, and Verses
    private string _npBook { get; set; }
    private int _npChapter{ get; set; }
    private int[] _npVerses { get; set; }

    // Set up the constructor for the class
    public Reference(string book, int chapter, params int[] verses)
    {
        _npBook = book;
        _npChapter = chapter;
        _npVerses = verses;
    }
    
    // Override the ToString method to format it correctly
    public override string ToString()
    {
        return $"{_npBook} {_npChapter}:{string.Join(":", _npVerses)}";
    }
}