using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HW_modul_14_part_01
{
    internal class Fraction
    {
        public Fraction() { }

        public int Numerator { get; set; }

        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {

            Numerator = numerator;
            Denominator = denominator;
        }
    }
}
