using System;
using System.Globalization;

public class Instrument
{
    protected string name;
    public string Name
    {
        get { return name; }
        protected set { name = value; }
    }
    protected int cost2;

    public virtual int Cost
    {
        get { return cost2; }
        set
        {
            cost2 = Math.Max(value, 1000);
        }
    }

    public Instrument(string N, int C)
    {
        Name = N;
        Cost = C;
        
    }

    public virtual void DisplayInstrument()
    {
        Console.WriteLine("The name of the instrument is : " + name);
        Console.WriteLine("The cost of the instrument is : " + cost2.ToString("C", CultureInfo.CurrentCulture));
    }


}
