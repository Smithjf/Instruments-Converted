using System;
using System.Globalization;

public class Instrument
{
    protected string nametwo;
    public string Name
    {
        get { return nametwo; }
        protected set { nametwo = value; }
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
        Console.WriteLine("The name of the instrument is : " + nametwo);
        Console.WriteLine("The cost of the instrument is : " + cost1.ToString("C", CultureInfo.CurrentCulture));

    }


}
