using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class Square : GeometricShape
    {
        public Square(int a)
        {
            this.a = a;
        }
        private int Perimeter()
        {
            p = a * 4;
            return (int)p;
        }
        private double Area()
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
