public class Scripture
{
    // This class has 2 private attributes, ScritpureText and Reference
    private string _npScriptureText;
    private Reference _npReference;
    
    // Set up the constructor for the class
    public Scripture(string scriptureText, Reference reference)
    {
        this._npScriptureText = scriptureText;
        this._npReference = reference;
    }
    
    // These attributes need to be accessed outside the class so make getters/setters
    public string npGetReference()
    {
        return _npReference.ToString();
    }

    public string npGetScriptureText()
    {
        return _npScriptureText;
    }
    
    public void npSetScriptureText(string npNewText)
    {
        _npScriptureText = npNewText;
    }
}