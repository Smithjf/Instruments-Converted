using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Instruments_Converted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is the instrument a brass or string instrument : ");
            string InstrumentType = Console.ReadLine();

            Console.WriteLine("Enter The name of the instrument : ");
            string name = Console.ReadLine();

            Console.WriteLine("What is the cost of the instrument? : ");
            int Cost = Int32.Parse(Console.ReadLine());


            if (InstrumentType.ToLower() == "brass")
            {

                Console.WriteLine("What material is the instrument made of? : ");
                string Material = Console.ReadLine();

                Console.WriteLine("What kind of sound does the instrument make? : ");
                string SoundMaking = Console.ReadLine();

                Instrument I1 = new Brass(name, Cost, Material, SoundMaking);
                I1.DisplayInstrument();
            }


            if (InstrumentType.ToLower() == "string")
            {
                bool isbowed = true;
                Console.WriteLine("How many strings does the instrument have? : ");
                int numstrings = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Is the instrument bowed? : ");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                {
                    isbowed = true;
                }
                if (answer.ToLower() == "no")
                {
                    isbowed = false;
                }


                Instrument I2 = new String_Instrument(name, Cost, isbowed, numstrings);
                I2.DisplayInstrument();


            }


        }
    }
}
