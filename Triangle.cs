using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class Triangle : GeometricShape
    {
        private int b;
        private int c;
        private bool right;
        private string type;
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public bool Right()
        {
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2) || Math.Pow(c, 2) + Math.Pow(a, 2) == Math.Pow(b, 2))
                right = true;
            else
                right = false;
            return right;
        }
        public string EquilateralIsosceles()
        {
            if (a == b && b == c && c == a)
            {
                type = "равносторонний";
                return type;
            }
            else if (a == b || b == c || c == a)
            {
                type = "равнобедренный";
                return type;
            }
            else
            {
                type = "обычный";
                return type;
            }
        }
        private int Perimeter()
        {
            p = a + b + c;
            return (int)p;
        }
        private double Area()
        {
            s = (Math.Sqrt((double)(Perimeter() / 2) * ((double)(Perimeter() / 2) - a) * ((double)(Perimeter() / 2) - b) * ((double)(Perimeter() / 2) - c)));
            return s;
        }
        public void Output()
        {
            Console.WriteLine($"Вид треугольника: {EquilateralIsosceles()}\n\nПериметр: {Perimeter()}\nПлощадь: {Area()}\n\nНажмите любую кнопку, чтобы вернуться");
        }
    }
}
