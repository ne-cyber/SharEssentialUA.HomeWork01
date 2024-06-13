﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _04
{
    internal partial class Program
    {



        // Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        // Потрібно: Створити класи Point та Figure.
        // Клас Point повинен містити два цілих поля і одне рядкове поле.
        // Створити три властивості одним методом доступу get.
        // Створити власний конструктор, у тілі якого проініціалізуйте поля значеннями аргументів.
        // Клас Figure повинен містити конструктори, які приймають від 3 до 5 аргументів типу Point.
        // Створити два методи: double LengthSide(Point A, Point B),
        // що розраховує довжину сторони багатокутника; void PerimeterCalculator(),
        // що розраховує периметр багатокутника.Написати програму, яка виводить на екран назву та периметр багатокутника.



        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Figure triangle = new Figure(new Point(0, 0), new Point(1, 1), new Point(0, 2));
            triangle.PerimeterCalculator();

            Console.WriteLine(new string('-', 30));

            Figure quadrangle = new Figure(new Point(0, 0), new Point(2, 0), new Point(2, 2), new Point(0, 2));
            quadrangle.PerimeterCalculator();

            Console.WriteLine(new string('-', 30));

            Figure pentagon = new Figure(new Point(0, 0), new Point(2, 0), new Point(1, 2), new Point(2, 2), new Point(0, 2));
            pentagon.PerimeterCalculator();

            Console.WriteLine(new string('-', 30));

            Point p1 = new Point(10, 10, "перша точка");
            Point p2 = new Point(20, 20, "друга точка");
            Point p3 = new Point(30, 10, "третя точка");
            Figure someFigure = new Figure(p1, p2, p3);
            someFigure.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
