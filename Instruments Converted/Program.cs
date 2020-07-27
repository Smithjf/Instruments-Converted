using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments_Converted
{
    class Program
    {
        static void Main(string[] args)
        {
            Instrument I1 = new Brass("Trombone", -1, "Brass", "Blaring");
            I1.Cost = 7510;
            I1.DisplayInstrument();

            Instrument I2 = new String_Instrument("Violin", -1, true, 4);
            I2.Cost = -2000;
            I2.DisplayInstrument();
         



            string tempname = I1.Name;
            int tempcost = I1.Cost;

            string tempname2 = I2.Name;
            int tempcost2 = I2.Cost;
        }
    }
}
