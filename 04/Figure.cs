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
            {
                Array.Resize(ref points, 4);
            }

            public Figure(Point p1, Point p2, Point p3)
                : this(p1, p2, p3, null, null)
            {
                Array.Resize(ref points, 3);
            }



            public double LengthSide(Point A, Point B)
            {
                return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            }

            public double PerimeterCalculator()
            {
                double perimeter = 0;

                for (int i = 0; i < points.Length - 1; i++)
                {
                    perimeter += LengthSide(points[i], points[i + 1]);
                }

                perimeter += LengthSide(points[points.Length - 1], points[0]);

                return perimeter;

            }

            public string FigureName
            {
                get
                {
                    if (points.Length == 3)
                        return "трикутник";
                    else if (points.Length == 4)
                        return "чотирикутник";
                    else if (points.Length == 5)
                        return "п'ятикутник";
                    else
                        return "не трикутник, не чотирикутник, не п'ятикутник";
                }
            }

            public double Perimeter
            {
                get { return PerimeterCalculator(); }
            }


        }
    }
}
