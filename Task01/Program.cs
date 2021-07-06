using System;
using static InputTools.UIFeatures;

namespace Task01
{
    partial class Program
    {
        static void Main(string[] args)
        {
            MenuCommands currentCommand = MenuCommands.menu;
            Rectangle rectangle = new Rectangle();

            do
            {
                InputCommand(ref currentCommand);

                switch (currentCommand)
                {
                    case (MenuCommands.menu):
                        InputCommand(ref currentCommand);
                        break;
                    case (MenuCommands.create):
                        CreataRectangle(ref rectangle);
                        break;
                    case (MenuCommands.setw):
                        SetWidth(ref rectangle);
                        break;
                    case (MenuCommands.seth):
                        SetHeight(ref rectangle);
                        break;
                    case (MenuCommands.height):
                        DrawSymbolLine(50, '-');
                        Console.WriteLine($"rectangle height = {rectangle.Height}");
                        DrawSymbolLine(50, '-');
                        break;
                    case (MenuCommands.width):
                        DrawSymbolLine(50, '-');
                        Console.WriteLine($"rectangle width = {rectangle.Width}");
                        DrawSymbolLine(50, '-');
                        break;
                    case (MenuCommands.perimeter):
                        DrawSymbolLine(50, '-');
                        Console.WriteLine($"rectangle perimeter = {rectangle.Perimeter}");
                        DrawSymbolLine(50, '-');
                        break;
                    case (MenuCommands.area):
                        DrawSymbolLine(50, '-');
                        Console.WriteLine($"rectangle area = {rectangle.Area}");
                        DrawSymbolLine(50, '-');
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

        static void CreataRectangle(ref Rectangle rectangle)
        {
            DrawSymbolLine(50, '-');
            Console.WriteLine("Draw new rectangle. Input width and height of figure:");
            Console.Write("width = ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("height = ");
            double height = Convert.ToDouble(Console.ReadLine());

            rectangle = new Rectangle(width, height);
            DrawSymbolLine(10, 50, '-');            
        }

        static void SetWidth(ref Rectangle rectangle)
        {
            DrawSymbolLine(50, '-');
            Console.Write("Input new width for rectangle - ");
            rectangle.Width = Convert.ToDouble(Console.ReadLine());
            DrawSymbolLine(10, 50, '-');            
        }

        static void SetHeight(ref Rectangle rectangle)
        {
            DrawSymbolLine(50, '-');
            Console.Write("Input new height for rectangle - ");
            rectangle.Height = Convert.ToDouble(Console.ReadLine());
            DrawSymbolLine(10, 50, '-');
        }
    }
}
