using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class Rectangle
    {
        private int a;
        private int b;
        private int p;
        private double s;
        public void Info()
        {
            Console.Write("Введите длины сторон прямоугольника\na = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        private int Perimeter()
        {
            p = (a + b) * 2;
            return p;
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
}