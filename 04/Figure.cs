using System;

namespace _04
{
    internal partial class Program
    {

        class Figure
        {
            private Point[] points = new Point[5];

            public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
            {
                points[0] = p1;
                points[1] = p2;
                points[2] = p3;
                points[3] = p4;
                points[4] = p5;
            }

            public Figure(Point p1, Point p2, Point p3, Point p4)
                : this(p1, p2, p3, p4, null) 
            { }

            public Figure(Point p1, Point p2, Point p3)
                : this(p1, p2, p3, null, null) 
            { }



            public double LengthSide(Point A, Point B)
            {
                return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            }

            public void PerimeterCalculator()
            {
                double perimeter = 0;

                //Потім pointsCount == 3 це трикутник, pointsCount == 4 це чотирикутник, pointsCount == 5 це п'ятикутник
                int pointsCount = 0;  

                // Обходимо кожну пару (0,1), (1,2), ..., (i-1, i)
                for (int i = 1; (i < points.Length && points[i] != null); i++)
                {
                    pointsCount = i;

                    perimeter += LengthSide(points[i - 1], points[i]);
                }

                // додаємо останню пару (i, 0)
                perimeter += LengthSide(points[pointsCount], points[0]);


                
                pointsCount++;
                string nazva;
                if (pointsCount == 3)
                    nazva = "трикутник";
                else if (pointsCount == 4)
                    nazva = "чотирикутник";
                else if (pointsCount == 5)
                    nazva = "п'ятикутник";
                else
                    throw new Exception("Щось пішло не так. Невідповідна кількість точок. Повино бути 3, 4 чи 5.");


                Console.WriteLine($"Фігура {nazva} має периметр {perimeter} (од.)");
            }

        }
    }
}
