using System;
using static InputTools.UIFeatures;

namespace Task03
{
    partial class Program
    {
        static void Main(string[] args)
        {
            MenuCommands currentCommand = MenuCommands.menu;
            Figure figure = new Figure();

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                InputCommand(ref currentCommand);

                switch (currentCommand)
                {
                    case (MenuCommands.menu):
                        currentCommand = MenuCommands.menu;
                        break;
                    case (MenuCommands.figure):
                        CreateNewFigure(out figure);
                        break;
                    case (MenuCommands.type):
                        DrawSymbolLine(50, '-');
                        Console.WriteLine(figure.GetFigureType());
                        DrawSymbolLine(50, '-');
                        break;
                    case (MenuCommands.points):
                        DrawSymbolLine(50, '-');
                        Console.WriteLine(figure.Name);
                        figure.ShowPoints();
                        DrawSymbolLine(50, '-');
                        break;
                    case (MenuCommands.perimeter):
                        DrawSymbolLine(50,'-');
                        Console.WriteLine(figure.Perimeter);
                        break;
                    case (MenuCommands.clear):
                        Console.Clear();
                        break;
                    case (MenuCommands.exit):
                        break;
                }

                if (currentCommand == MenuCommands.exit) break;

            }
            while (true);
        }

        public static void CreateNewFigure(out Figure figure)
        {
            Point[] pointsArray = new Point[] { };
            double x;
            double y;
            string name;
            Point pt;
            ConsoleKeyInfo cki = new ConsoleKeyInfo();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine("to continue input - press ENTER after point coordinates input");
            Console.WriteLine("to exit from input point mode - press E after point coordinates input");
            Console.ResetColor();
            Console.Write("Input figure name - ");
            string figureName = Console.ReadLine();

            do
            {               
                DrawSymbolLine(50, '-', ConsoleColor.DarkGray);
                Console.WriteLine($"Input new point coordinates:");
                Console.Write("X - ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y - ");
                y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Point name - ");
                name = "";
                name = Console.ReadLine();
                if (name == "") ;
                pt = new Point(x, y);
                if (name != "")
                pt = new Point(x, y, name);
                AddPointToArray(ref pointsArray, pt);

                cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.Escape)
                {
                    //иначе будет удалена следующая строка
                    Console.Write("e");
                    break;
                }
                
            }
            while (true);
            
            DrawSymbolLine(50, '-', ConsoleColor.DarkGray);

            Console.WriteLine("Figure is done");
            figure = new Figure(figureName, pointsArray);
            

        }

        /*Метод для добавления в массив точек новой точки
        Случай упрощённый. Точка добавляется только в конец массива.
        */
        public static void AddPointToArray(ref Point[] pointsArray, Point point)
        {
            if(pointsArray is null)
            {
                pointsArray = new Point[] { };
            }

            Array.Resize<Point>(ref pointsArray, pointsArray.Length + 1);
            pointsArray[pointsArray.Length - 1] = point;
        }

        /*Метод для удаления точки из массива точек
         * Случай упрощённый, удаляются только точки из конца массива
         */
        public static void RemovePointFromArray(ref Point[] pointsArray)
        {
            if(pointsArray.Length > 0)
            Array.Resize<Point>(ref pointsArray, pointsArray.Length - 1);
        }

        static double InputPointCoordinate(ref Point point, Coordinate xy)
        {
            double coordinate = Convert.ToInt32(Console.ReadLine());
            if(xy == Coordinate.X)
            {
                point.X = coordinate;
                return point.X;
            }
                
            point.Y = coordinate;
            return point.Y;            
        }

        enum Coordinate
        {
            X,
            Y,
        }
        
    }
}
