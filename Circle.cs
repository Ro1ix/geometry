using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class Circle
    {
        private int r;
        private double p;
        private double s;
        public void Info()
        {
            Console.Write("Введите радиус круга\nr = ");
            r = Convert.ToInt32(Console.ReadLine());
        }
        public double Perimeter()
        {
            p = 2 * Math.Round(Math.PI, 2) * r;
            return p;
        }
        public double Area()
        {
            s = Math.Round(Math.PI, 2) * Math.Pow(r, 2);
            return s;
        }
    }
}