using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class Cone : Circle
    {
        private int height;
        private double sideLine;
        private double p;
        private new double s;
        private double v;
        public Cone(int a, int height, double sideLine) : base(a)
        {
            this.height = height;
            this.sideLine = sideLine;
        }
        protected override double Perimeter()
        {
            p = base.Perimeter();
            return p;
        }
        protected override double Area()
        {
            double apopheme = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(height, 2));
            s = Math.Round(Math.Round(Math.PI, 2) * a * apopheme + base.Area(), 2);
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