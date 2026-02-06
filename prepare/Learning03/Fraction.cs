using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization.Metadata;

class Fraction
{
    private int top;
    private int bottom;
    public Fraction()
    {
       top=1;
       bottom=1; 
    }
    public Fraction(int t)
    {
        top=t;
        bottom=1;
    }
    public Fraction(int t, int b)
    {
        top=t;
        bottom=b;
    }
    public void setBottom(int b)
    {
        bottom=b;
    }
    public void setTop(int t)
    {
        top=t;
    }
    public int getTop()
    {
        return top;
    }
    public int getBottom()
    {
        return bottom;
    }
    public string GetFractionString()
    {
        return $"{top}/{bottom}";
    }
    public double GetDecimalValue()
    {
        double d = (double)top/(double)bottom;
        return d;
    }
}