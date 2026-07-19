public class Scripture
{
    private string _npScriptureText;
    private Reference _npReference;
    
    public Scripture(string scriptureText, Reference reference)
    {
        this._npScriptureText = scriptureText;
        this._npReference = reference;
    }
    
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