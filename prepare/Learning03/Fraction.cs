public class Fraction
{
    private int _npTop;
    private int _npBottom;

    public Fraction()
    {
        _npTop = 1;
        _npBottom = 1;
    }

    public Fraction(int npWholeNum)
    {
        _npTop = npWholeNum;
        _npBottom = 1;
    }

    public Fraction(int npTop, int npBottom)
    {
        _npTop = npTop;
        _npBottom = npBottom;
    }

    public int GetTop()
    {
       int npTopValue = _npTop;
       return npTopValue;
    }

    public void SetTop(int npTopValue)
    {
        _npTop = npTopValue;
    }

    public int GetBottom()
    {
        int npBottomValue = _npBottom;
        return npBottomValue;
    }

    public void SetBottom(int npBottomValue)
    {
        _npBottom = npBottomValue;
    }

    public string GetFractionString()
    {
        string npFractionString = $"{_npTop}" + "/" + $"{_npBottom}";
        return npFractionString;
    }

    public double GetDecimalValue()
    {
        double npDecimalValue = _npTop / _npBottom;
        return npDecimalValue;
    }
}