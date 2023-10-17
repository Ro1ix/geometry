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
            Console.WriteLine("Выберите фигуру\n1. Квадрат    2. Прямоугольник    3. Круг    4. Треугольник    5. Выход");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("КВАДРАТ\n");
                    Square square = new Square();
                    square.Info();
                    Console.WriteLine($"\nПериметр: {square.Perimeter()}\nПлощадь: {square.Area()}\n\nНажмите любую кнопку, чтобы вернутсья");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("ПРЯМОУГОЛЬНИК\n");
                    Rectangle rectangle = new Rectangle();
                    rectangle.Info();
                    Console.WriteLine($"\nПериметр: {rectangle.Perimeter()}\nПлощадь: {rectangle.Area()}\n\nНажмите любую кнопку, чтобы вернутсья");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("КРУГ\n");
                    Circle circle = new Circle();
                    circle.Info();
                    Console.WriteLine($"\nПериметр: {circle.Perimeter()}\nПлощадь: {circle.Area()}\n\nНажмите любую кнопку, чтобы вернутсья");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("ТРЕУГОЛЬНИК\n");
                    Triangle triangle = new Triangle();
                    triangle.Info();
                    Console.Write("\nПрямоугольный: ");
                    if (triangle.Right() == true)
                        Console.WriteLine("да");
                    else
                        Console.WriteLine("нет");
                    Console.Write("Равносторонний: ");
                    if (triangle.Equilateral() == true)
                        Console.WriteLine("да");
                    else
                        Console.WriteLine("нет");
                    Console.Write("Равнобедренный: ");
                    if (triangle.Isosceles() == true)
                        Console.WriteLine("да");
                    else
                        Console.WriteLine("нет");
                    Console.WriteLine($"Периметр: {triangle.Perimeter()}\nПлощадь: {triangle.Area()}\n\nНажмите любую кнопку, чтобы вернутсья");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "5":
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