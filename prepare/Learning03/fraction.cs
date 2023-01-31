public class Fraction
{
    private int _bottom;
    private int _top;

    public Fraction()
    {
        _bottom = 1;
        _top = 1;
    }

    public Fraction(int number)
    {
        _bottom = 1;
        _top = number;
    }

    public Fraction(int top, int bottom)
    {
        _bottom = bottom;
        _top = top;
    }

    public int GetFractionTop()
    {
        return _top;
    }
    public void SetFractionTop(int top)
    {
        _top = top;
    }
    public int GetFractionBottom()
    {
        return _bottom;
    }
    public void SetFractionBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = ($"{_top}/{_bottom}");
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}