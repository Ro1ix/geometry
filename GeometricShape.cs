using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class GeometricShape
    {
        protected int a;
        protected double p;
        protected double s;
    }
    class Square : GeometricShape
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
    class Rectangle : GeometricShape
    {
        private int b;
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
        private double Area()
        {
            s = a * b;
            return s;
        }
        public void Output()
        {
            Console.WriteLine($"\nПериметр: {Perimeter()}\nПлощадь: {Area()}\n\nНажмите любую кнопку, чтобы вернутсья");
        }
    }
    class Circle : GeometricShape
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
    class Triangle : GeometricShape
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
    class Pyramid : GeometricShape
    {
        private int height;
        private double sideLine;
        private double sDown;
        private double v;
        public Pyramid(int a, int height, double sideline)
        {
            this.a = a;
            this.height = height;
            this.sideLine = sideline;
        }
        private double Perimeter(string pyramidInput)
        {
            if (pyramidInput == "3")
            {
                p = 2 * Math.Round(Math.PI, 2) * a;
            }
            else
            {
                p = a * (Convert.ToInt32(pyramidInput) + 2) + sideLine * (Convert.ToInt32(pyramidInput) + 2);
            }
            return p;
        }
        private double Area(string pyramidInput)
        {
            if (pyramidInput == "3")
            {
                double apopheme = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(height, 2));
                sDown = Math.Round(Math.PI, 2) * Math.Pow(a, 2);
                s = Math.Round(Math.Round(Math.PI, 2) * a * apopheme + sDown, 2);
            }
            else
            {
                double apopheme = Math.Round(Math.Sqrt(Math.Pow(height, 2) + (a / (2 * Math.Tan(Math.PI / (Convert.ToInt32(pyramidInput) + 2))))), 2);
                if (pyramidInput == "1")
                {
                    sDown = (a * (Math.Sqrt(Math.Pow(a, 2) - Math.Pow(a / 2, 2)))) / 2;
                    s = Math.Round(apopheme * 3 + sDown, 2);
                }
                else
                {
                    sDown = Math.Pow(a, 2);
                    s = Math.Round(apopheme * 4 + sDown, 2);
                }
            }
            return s;
        }
        private double Volume()
        {
            v = Math.Round(sDown * height / 3, 2);
            return v;
        }
        public void Output(string pyramidInput)
        {
            Console.WriteLine($"\nПериметр: {Perimeter(pyramidInput)}\nПлощадь: {Area(pyramidInput)}\nОбъём: {Volume()}\n\nНажмите любую кнопку, чтобы вернуться");
        }
    }
}