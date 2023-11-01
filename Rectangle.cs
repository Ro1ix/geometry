using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class Rectangle
    {
        protected int a;
        protected int b;
        private double p;
        protected double s;
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        private int Perimeter()
        {
            p = (a + b) * 2;
            return (int)p;
        }
        protected double Area()
        {
            s = a * b;
            return s;
        }
        public void Output()
        {
            Console.WriteLine($"\nПериметр: {Perimeter()}\nПлощадь: {Area()}\n\nНажмите любую кнопку, чтобы вернутсья");
        }
    }
}