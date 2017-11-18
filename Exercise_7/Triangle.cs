using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    public class Triangle : ICompare
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double GetPerimeter()
        {
            return A + B + C;
        }

        public double GetArea()
        {
            var halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
        }

        bool ICompare.IsBigger(ICompare another)
        {
            return GetArea() > ((Triangle) another).GetArea();
        }

        public override string ToString()
        {
            return $"Triangle: ({A}, {B}, {C})\tArea: {GetArea()}";
        }
    }
}
