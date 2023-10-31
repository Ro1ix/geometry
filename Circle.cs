using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class Circle : GeometricShape
    {
        public Circle(int a)
        {
            this.a = a;
        }
        private double Perimeter()
        {
            p = 2 * Math.Round(Math.PI, 2) * a;
            return p;
        }
        private double Area()
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
