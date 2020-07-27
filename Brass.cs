using System;
using System.Security.Cryptography.X509Certificates;

public class Brass : Instrument
{
	private string SoundMaking;
	private string Material;
	public Brass(string n, int c, string sm, string m) : base(n,c)
    {
		SoundMaking = sm;
		Material = m;
    }
	public override void DisplayInstrument()
	{
		base.DisplayInstrument();
		Console.WriteLine("The sound the instrument makes is : " + SoundMaking);
		Console.WriteLine("The material of the instrument is : " + Material);

	}
	
	
	
}
