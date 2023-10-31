using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class PyramidTriangle : Pyramid
    {
        public PyramidTriangle(int a, int height, double sideLine) : base(a, height, sideLine)
        { }
        private double Perimeter()
        {
            p = a * 3 + sideLine * 3;
            return p;
        }
        private double Area() 
        {
            double apopheme = Math.Round(Math.Sqrt(Math.Pow(height, 2) + (a / (2 * Math.Tan(Math.PI / 3)))), 2);
            sDown = (a * (Math.Sqrt(Math.Pow(a, 2) - Math.Pow(a / 2, 2)))) / 2;
            s = Math.Round(apopheme * 3 + sDown, 2);
            return s;
        }
    }
}