using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Geometries
    {
    }

    public class Point
    {
        double x;
        double y;
        string name;

        public Point()
        {
            X = 0;
            Y = 0;
            name = $"Point {X}-{Y}";
        }

        public Point(double xCoordinate, double yCoordinate)
        {
            X = xCoordinate;
            Y = yCoordinate;
            name = $"Point {X}-{Y}";
        }

        public Point(double xCoordinate, double yCoordinate, string name)
        {
            X = xCoordinate;
            Y = yCoordinate;
            this.name = name;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        
    }

    public class Figure
    {
        Point[] figurePoints;
        double perimeter;
        string name;
        FigureType figureType;

        public Figure(params Point[] points)
        {
            figurePoints = points;
            PerimeterCalculator();
        }

        public Figure(string name, params Point[] points)
        {
            figurePoints = points;
            PerimeterCalculator();
            Name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Perimeter
        {
            get { return perimeter; }
            private set { perimeter = value; }
        }

        //
        public string GetFigureType()
        {
            FigureType ft;
            Enum.TryParse(figurePoints.Length.ToString(), out ft);
            return ft.ToString();
        }

        public void ShowPoints()
        {
            for(int i = 0; i < figurePoints.Length; i++)
            {
                Console.WriteLine($"point {figurePoints[i].Name} [x={figurePoints[i].X} - y={figurePoints[i].Y}]");
            }
        }


        double LengthSide(Point a, Point b)
        {
            double deltaX = Math.Abs(a.X - b.X);
            double deltaY = Math.Abs(a.Y - b.Y);

            double sideLength = Math.Sqrt((Math.Pow(deltaX, 2)) + (Math.Pow(deltaY, 2)));

            return sideLength;
        }

        void PerimeterCalculator()
        {
            Perimeter = 0;

            if (figurePoints.Length < 2) return;
            if (figurePoints.Length == 2)
            {
                Perimeter = LengthSide(figurePoints[0], figurePoints[1]); 
                return;
            }

            for(int i = 0; i<figurePoints.Length; i++)
            {
                if(i < figurePoints.Length - 1)
                {
                    Perimeter += LengthSide(figurePoints[i], figurePoints[i + 1]);
                    continue;
                }

                Perimeter += LengthSide(figurePoints[i], figurePoints[0]);

            }
        }

    }



    public enum FigureType
    {
        notAFigure = 1,
        line = 2,
        triangle = 3,
        quadrilateral = 4,
        pentagon = 5,
        hexagon = 6,
        heptagon = 7,
        octаgon = 8,
    }
}
