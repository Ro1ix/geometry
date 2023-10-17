using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class Square
    {
        private int a;
        private int p;
        private double s;
        public void Info()
        {
            Console.Write("Введите длину стороны квадрата\na = ");
            a = Convert.ToInt32(Console.ReadLine());
        }
        public int Perimeter()
        {
            p = a * 4;
            return p;
        }
        public double Area()
        {
            s = Math.Pow(a, 2);
            return s;
        }
    }
}