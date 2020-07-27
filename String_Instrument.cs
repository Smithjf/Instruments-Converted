using System;
using System.Security.Cryptography.X509Certificates;

public class String_Instrument : Instrument
{
    public override int Cost
    {
        set
        {
            if (value < 2000)
            {
                cost = 2000;
            }
            else
            {
                cost = value;
            }
        }
    }
    private bool isbowed;
    private int numstrings;

    public String_Instrument(string n, int c, bool ib, int ns) : base(n, c)
    {
        isbowed = ib;
        numstrings = ns;
    }


    public override void DisplayInstrument()
    {
        base.DisplayInstrument();
        if (isbowed == true)
        {
            Console.WriteLine("The type of instrument is bowed");
        }
        else
        {
            Console.WriteLine("The type of instrument is not bowed");
        }

        Console.WriteLine("number of strings the instrument has is : " + numstrings);

    }
}
