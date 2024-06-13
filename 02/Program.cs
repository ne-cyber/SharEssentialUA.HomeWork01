using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {



        // Потрібно: Створити клас із ім'ям Rectangle.
        // У тілі класу створити два поля, що описують довжини сторін double side1, side2.
        // Створити власний конструктор Rectangle(double side1, double side2),
        // у тілі якого поля side1 і side2 ініціалізуються значеннями аргументів.
        // Створити два методи, що обчислюють площу прямокутника - double AreaCalculator()
        // та периметр прямокутника - double PerimeterCalculator().
        // Створити дві властивості double Area та double Perimeter з одним методом доступу get.
        // Написати програму, яка приймає від користувача довжини двох сторін прямокутника і виводить на екран периметр та площу. 
        


        class Rectangle
        {

            // Інкапсуляція, що приховує реалізацію членів класу.
            private double side1, side2;

            public Rectangle(double side1, double side2)
            {
                this.side1 = side1;
                this.side2 = side2;
            }

            private double AreaCalculator()
            {
                return side1 * side2;
            }

            private double PerimeterCalculator()
            {
                return (side1 + side2) * 2;
            }



            public double Area
            {
                get
                {
                    return this.AreaCalculator();
                }
            }
            public double Perimeter
            {
                get
                {
                    return this.PerimeterCalculator();
                }

            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                double h, w;
                Console.Write("Введіть ширину прямокутника: ");
                w = double.Parse(Console.ReadLine());
                Console.Write("Введіть висоту прямокутника: ");
                h = double.Parse(Console.ReadLine());

                Rectangle r = new Rectangle(w, h);
                Console.WriteLine($"Периметр прямокутника {r.Perimeter} (од.)");
                Console.WriteLine($"Площа прямокутника {r.Area} (кв. од.)");

                Console.WriteLine();
            }
        }
    }
}
