﻿using System;
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
                    Console.WriteLine("Эта функция ещё не готова. Пожалуйста, потерпите, пока я не закончу код");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Эта функция ещё не готова. Пожалуйста, потерпите, пока я не закончу код");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Эта функция ещё не готова. Пожалуйста, потерпите, пока я не закончу код");
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