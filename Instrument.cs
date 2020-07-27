using System;
using System.Globalization;

public class Instrument
{
    protected string InstrumentName;
    public string Name
    {
        get { return InstrumentName; }
        protected set { InstrumentName = value; }
    }

    protected int cost1;

    public virtual int Cost
    {
        get { return cost1; }
        set
        {
            cost1 = Math.Max(value, 1000);

        }
    }

    public Instrument(string n, int c)
    {
        Name = n;
        Cost = c;
        
    }

    public virtual void DisplayInstrument()
    {
        Console.WriteLine("The name of the instrument is : " + InstrumentName);
        Console.WriteLine("The cost of the instrument is : " + cost1.ToString("C", CultureInfo.CurrentCulture));

    }


}
