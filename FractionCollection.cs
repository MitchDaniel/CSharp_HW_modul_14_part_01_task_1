using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharp_HW_modul_14_part_01
{
    public class FractionCollection
    {
        public FractionCollection() { }

        List<Fraction> _fractions = new List<Fraction>();

        public List<Fraction> Fractions
        { 
            get { return _fractions; } 
            set { _fractions = value; }
        }

        public void Add(params Fraction[] fractions)
        {
            if (fractions is null) throw new ArgumentNullException();
            _fractions.AddRange(fractions);
        }
    }
}
