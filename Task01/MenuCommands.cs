using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static InputTools.UIFeatures;

namespace Task01
{
    partial class Program
    {
        public static void InputCommand(ref MenuCommands currentCommand)
        {
            bool IsCorrectCommand = false;

            string menu =
                $"{MenuCommands.menu} - show menu\n" +
                $"{MenuCommands.create} - create new rectangle\n" +
                $"{MenuCommands.setw} - input new width for rectangle\n" +
                $"{MenuCommands.seth} - input new height for rectangle\n" +
                $"{MenuCommands.width} - view width for rectangle\n" +
                $"{MenuCommands.height} - view height for rectangle\n" +
                $"{MenuCommands.area} - show rectangle area\n" +
                $"{MenuCommands.perimeter} - show rectangle perimeter\n" +
                $"{MenuCommands.clear} - clear console\n" +
                $"{MenuCommands.exit} - exit from programm";

            if (currentCommand == MenuCommands.menu)
            {
                DrawSymbolLine(50, '-');
                Console.WriteLine(menu);
            }


            Console.ForegroundColor = ConsoleColor.Yellow;
            DrawSymbolLine(50, '*');
            Console.Write("input command:");
            IsCorrectCommand = Enum.TryParse(Console.ReadLine(), out currentCommand);
            DrawSymbolLine(10, 50, '*');
            Console.ResetColor();

            if (IsCorrectCommand == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Command input error. Input correct command.");
                Console.ResetColor();

                currentCommand = MenuCommands.menu;

                InputCommand(ref currentCommand);
            }
        }        
    }

    public enum MenuCommands
    {
        menu,
        create,
        setw,
        seth,
        height,
        width,
        perimeter,
        area,
        clear,
        exit,
    }
}
