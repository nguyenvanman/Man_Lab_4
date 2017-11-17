using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    public class Country : ICompare
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Country(string name, double area)
        {
            Name = name;
            Area = area;
        }

        bool ICompare.IsBigger(ICompare another)
        {
            return Area > ((Country) another).Area;
        }

        public override string ToString()
        {
            return $"Country: {Name}\tArea: {Area}";
        }
    }
}
