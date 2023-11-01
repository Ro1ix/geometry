using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class Circle
    {
        protected int a;
        private double p;
        protected double s;
        public Circle(int a)
        {
            this.a = a;
        }
        protected virtual double Perimeter()
        {
            p = 2 * Math.Round(Math.PI, 2) * a;
            return p;
        }
        protected virtual double Area()
        {
            s = Math.Round(Math.PI, 2) * Math.Pow(a, 2);
            return s;
        }
        public void Output()
        {
            Console.WriteLine($"\nПериметр: {Perimeter()}\nПлощадь: {Area()}\n\nНажмите любую кнопку, чтобы вернуться");
        }
    }
}