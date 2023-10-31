using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class Pyramid : GeometricShape
    {
        protected int height;
        protected double sideLine;
        protected double sDown;
        protected double v;
        public Pyramid(int a, int height, double sideLine)
        {
            this.a = a;
            this.height = height;
            this.sideLine = sideLine;
        }
        protected double Area(string pyramidInput)
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
        protected double Volume()
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
