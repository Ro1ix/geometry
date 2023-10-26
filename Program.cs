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
                    Square square = new Square();
                    Console.WriteLine("КВАДРАТ\n");
                    square.Info();
                    Console.WriteLine($"\nПериметр: {square.Perimeter()}\nПлощадь: {square.Area()}\n\nНажмите любую кнопку, чтобы вернутсья");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "2":
                    Console.Clear();
                    Rectangle rectangle = new Rectangle();
                    Console.WriteLine("ПРЯМОУГОЛЬНИК\n");
                    rectangle.Info();
                    Console.WriteLine($"\nПериметр: {rectangle.Perimeter()}\nПлощадь: {rectangle.Area()}\n\nНажмите любую кнопку, чтобы вернутсья");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "3":
                    Console.Clear();
                    Circle circle = new Circle();
                    Console.WriteLine("КРУГ\n");
                    circle.Info();
                    Console.WriteLine($"\nПериметр: {circle.Perimeter()}\nПлощадь: {circle.Area()}\n\nНажмите любую кнопку, чтобы вернутсья");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "4":
                    Console.Clear();
                    Triangle triangle = new Triangle();
                    Console.WriteLine("ТРЕУГОЛЬНИК\n");
                    triangle.Info();
                    Console.Write("\nПрямоугольный: ");
                    if (triangle.Right() == true)
                        Console.WriteLine("да");
                    else
                        Console.WriteLine("нет");
                    Console.WriteLine($"Вид треугольника: {triangle.EquilateralIsosceles()}\n\nПериметр: {triangle.Perimeter()}\nПлощадь: {triangle.Area()}\n\nНажмите любую кнопку, чтобы вернутсья");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "5":
                    Console.Clear();
                    Pyramid pyramid = new Pyramid();
                    string pyramidInput = pyramid.Choise();
                    Console.Clear();
                    if (pyramidInput == "3")
                    {
                        pyramid.InfoCone();
                    }
                    else
                    {
                        if (pyramidInput == "1")
                            Console.WriteLine("ТРЕУГОЛЬНАЯ ПИРАМИДА\n");
                        if (pyramidInput == "2")
                            Console.WriteLine("ЧЕТЫРЁХУГОЛЬНАЯ ПИРАМИДА\n");
                        pyramid.InfoPyramid();
                    }
                    Console.WriteLine($"\nПериметр: {pyramid.Perimeter(pyramidInput)}\nПлощадь: {pyramid.Area(pyramidInput)}\nОбъём: {pyramid.Volume()}\n\nНажмите любую кнопку, чтобы вернутсья");
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