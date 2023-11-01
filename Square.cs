using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class Square
    {
        protected int a;
        private double p;
        protected double s;
        public Square(int a)
        {
            this.a = a;
        }
        protected virtual double Perimeter()
        {
            p = a * 4;
            return p;
        }
        protected virtual double Area()
        {
            s = Math.Pow(a, 2);
            return s;
        }
        public void Output()
        {
            Console.WriteLine($"\nПериметр: {Perimeter()}\nПлощадь: {Area()}\n\nНажмите любую кнопку, чтобы вернуться");
        }
    }
}