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
        private int sideLine;
        private int height;
        private double p;
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
            Console.Write("Боковая грань = ");
            sideLine = Convert.ToInt32(Console.ReadLine());
            Console.Write("Высота = ");
            height = Convert.ToInt32(Console.ReadLine());
        }
        public void InfoCone()
        {

        }
        public void DownPerimeter(string input)
        {
            if (input == "3")
            {
                p = 2 * Math.Round(Math.PI, 2) * downLine;
            }
        }
    }
}