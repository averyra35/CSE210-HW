using System;

public class Fraction
{
    private int topNum;
    private int bottomNum;

    public Fraction()
    {
        topNum = 1;
        bottomNum = 1;
    }

    public Fraction(int wholeNumber)
    {
        topNum = wholeNumber;
        bottomNum = 1;
    }

    public Fraction(int top, int bottom)
    {
        topNum = top;
        bottomNum = bottom;
    }

    public string GetFraction()
    {
        string  fraction = $"{topNum}/{bottomNum}";
        return fraction;
    }

    public double GetDecimal()
    {
        return (double)topNum / (double)bottomNum;
    }
}