using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class PyramidSquare : Square
    {
        private int height;
        private double sideLine;
        private double p;
        private new double s;
        private double v;
        public PyramidSquare(int a, int height, double sideLine) : base(a)
        {
            this.height = height;
            this.sideLine = sideLine;
        }
        protected override double Perimeter()
        {
            p = base.Perimeter() + sideLine * 4;
            return p;
        }
        protected override double Area()
        {
            double apopheme = Math.Round(Math.Sqrt(Math.Pow(height, 2) + (a / (2 * Math.Tan(Math.PI / 4)))), 2);
            s = Math.Round(apopheme * 4 + base.Area(), 2);
            return s;
        }
        private double Volume()
        {
            v = Math.Round(base.Area() * height / 3, 2);
            return v;
        }
        public new void Output()
        {
            Console.WriteLine($"\nПериметр: {Perimeter()}\nПлощадь: {Area()}\nОбъём: {Volume()}\n\nНажмите любую кнопку, чтобы вернуться");
        }
    }
}