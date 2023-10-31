using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Геометрические фигуры";
            Console.WriteLine("Выберите фигуру\n1. Квадрат    2. Прямоугольник    3. Круг    4. Треугольник    5. Пирамида/конус    6. Выход");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("КВАДРАТ\n");
                    Console.Write("Введите длину стороны квадрата\na = ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Square square = new Square(a);
                    square.Output();
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("ПРЯМОУГОЛЬНИК\n");
                    Console.Write("Введите длины сторон прямоугольника\na = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("b = ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(a, b);
                    rectangle.Output();
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("КРУГ\n");
                    Console.Write("Введите радиус круга\nr = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Circle circle = new Circle(a);
                    circle.Output();
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("ТРЕУГОЛЬНИК\n");
                    Console.Write("Введите длины сторон треугольника\na = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("b = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("c = ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    if (a + b <= c || b + c <= a || c + a <= b)
                    {
                        Console.WriteLine("\nОШИБКА!!! Треугольник с такими сторонами не существует\nНажмите любую клавишу и попробуйте ещё раз\n");
                        Console.ReadKey();
                        goto case "4";
                    }
                    Triangle triangle = new Triangle(a ,b, c);
                    Console.Write("\nПрямоугольный: ");
                    if (triangle.Right() == true)
                        Console.WriteLine("да");
                    else
                        Console.WriteLine("нет");
                    triangle.Output();
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Выберите основание фигуры\n1. Треугольник    2. Квадрат    3. Круг");
                    string pyramidInput = Console.ReadLine();
                    if (pyramidInput == "3")
                    {
                        Console.Clear(); 
                        Console.WriteLine("КОНУС\n");
                        Console.Write("Введите данные конуса\nРадиус основания = ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Высота = ");
                        int height = Convert.ToInt32(Console.ReadLine());
                        double sideLine = Math.Round(Math.Sqrt(Math.Pow(height, 2) + Math.Pow(a, 2)), 2);
                        Console.WriteLine($"Боковое ребро = {sideLine}");
                        Pyramid pyramid = new Pyramid(a, height, sideLine);
                        pyramid.Output(pyramidInput);
                    }
                    else if (pyramidInput == "1" || pyramidInput == "2")
                    {
                        Console.Clear(); 
                        if (pyramidInput == "1")
                            Console.WriteLine("ТРЕУГОЛЬНАЯ ПИРАМИДА\n");
                        if (pyramidInput == "2")
                            Console.WriteLine("ЧЕТЫРЁХУГОЛЬНАЯ ПИРАМИДА\n");
                        Console.Write("Введите данные пирамиды\nСторона основания = ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Высота = ");
                        int height = Convert.ToInt32(Console.ReadLine());
                        double sideLine = Math.Round(Math.Sqrt(Math.Pow(height, 2) + (a / (2 * Math.Pow(Math.Sin(Math.PI / 3), 2)))), 2);
                        Console.WriteLine($"Боковое ребро = {sideLine}");
                        Pyramid pyramid = new Pyramid(a, height, sideLine);
                        pyramid.Output(pyramidInput);
                    }
                    else
                    {
                        Console.WriteLine("ОШИБКА!!! Нажмите любую клавишу и попробуйте ещё раз");
                        Console.ReadKey();
                        Console.Clear();
                        goto case "5";
                    }
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("\nОШИБКА!!! Нажмите любую клавишу и попробуйте ещё раз");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
            }
        }
    }
}