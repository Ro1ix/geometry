using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class Triangle
    {
        private int a;
        private int b;
        private int c;
        private int p;
        private bool right;
        private string type;
        private double s;
        public void Info()
        {
            Console.Write("Введите длины сторон треугольника\na = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b <= c || b + c <= a || c + a <= b)
            {
                Console.WriteLine("\nОШИБКА!!! Треугольник с такими сторонами не существует\nНажмите любую клавишу и попробуйте ещё раз\n");
                Console.ReadKey();
                Info();
            }
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
            return p;
        }
        private double Area()
        {
            s = (Math.Sqrt((double)(Perimeter() / 2) * ((double)(Perimeter() / 2) - a) * ((double)(Perimeter() / 2) - b) * ((double)(Perimeter() / 2) - c)));
            return s;
        }
        public void Output()
        {
            Console.WriteLine($"Вид треугольника: {EquilateralIsosceles()}\n\nПериметр: {Perimeter()}\nПлощадь: {Area()}\n\nНажмите любую кнопку, чтобы вернутсья");
        }
    }
}