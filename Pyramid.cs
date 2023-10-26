using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class Pyramid
    {
        private int downLine;
        private int height;
        private double sideLine;
        private double p;
        private double s;
        private double sDown;
        private double v;
        public string Choise()
        {
            Console.WriteLine("Выберите основание фигуры\n1. Треугольник    2. Квадрат    3. Круг");
            string input = Console.ReadLine();
            if (input != "1" && input != "2" && input != "3")
            {
                Console.WriteLine("ОШИБКА!!! Нажмите любую клавишу и попробуйте ещё раз");
                Console.ReadKey();
                Console.Clear();
                Choise();
            }
            return input;
        }
        public void InfoPyramid()
        {
            Console.Write("Введите данные пирамиды\nСторона основания = ");
            downLine = Convert.ToInt32(Console.ReadLine());
            Console.Write("Высота = ");
            height = Convert.ToInt32(Console.ReadLine());
            sideLine = Math.Round(Math.Sqrt(Math.Pow(height, 2) + (downLine / (2 * Math.Pow(Math.Sin(Math.PI / 3), 2)))), 2);
            Console.WriteLine($"Боковое ребро = {sideLine}");
        }
        public void InfoCone()
        {
            Console.Write("Введите данные конуса\nРадиус основания = ");
            downLine = Convert.ToInt32(Console.ReadLine());
            Console.Write("Высота = ");
            height = Convert.ToInt32(Console.ReadLine());
            sideLine = Math.Round(Math.Sqrt(Math.Pow(height, 2) + Math.Pow(downLine, 2)), 2);
            Console.WriteLine($"Боковое ребро = {sideLine}");
        }
        public double Perimeter(string pyramidInput)
        {
            if (pyramidInput == "3")
            {
                p = 2 * Math.Round(Math.PI, 2) * downLine;
            }
            else
            {
                p = downLine * (Convert.ToInt32(pyramidInput) + 2) + sideLine * (Convert.ToInt32(pyramidInput) + 2);
            }
            return p;
        }
        public double Area(string pyramidInput)
        {
            if (pyramidInput == "3")
            {
                double apopheme = Math.Sqrt(Math.Pow(downLine, 2) + Math.Pow(height, 2));
                sDown = Math.Round(Math.PI, 2) * Math.Pow(downLine, 2);
                s = Math.Round(Math.Round(Math.PI, 2) * downLine * apopheme + sDown, 2);
            }
            else
            {
                double apopheme = Math.Round(Math.Sqrt(Math.Pow(height, 2) + (downLine / (2 * Math.Tan(Math.PI / (Convert.ToInt32(pyramidInput) + 2))))), 2);
                if (pyramidInput == "1")
                {
                    sDown = (downLine * (Math.Sqrt(Math.Pow(downLine, 2) - Math.Pow(downLine / 2, 2)))) / 2;
                    s = Math.Round(apopheme * 3 + sDown, 2);
                }
                else
                {
                    sDown = Math.Pow(downLine, 2);
                    s = Math.Round(apopheme * 4 + sDown, 2);
                }
            }    
            return s;
        }
        public double Volume()
        {
            v = Math.Round(sDown * height / 3, 2);
            return v;
        }
    }
}