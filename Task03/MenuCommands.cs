using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using static InputTools.UIFeatures;

namespace Task03
{
    // разобраться с атрибутами к перечислениям
    // возможно ли через рефлексию получить доступ к членам перечисления
    public enum MenuCommands
    {
        menu,
        figure,
        type,
        points,
        perimeter,
        clear,
        exit
    }

    public partial class Program
    {
        static void InputCommand(ref MenuCommands currentCommand)
        {
            bool IsCorrectCommand = false;

            string menu =
                $"{MenuCommands.menu} ({(int)MenuCommands.menu}) - show program menu\n" +
                $"{MenuCommands.figure} ({(int)MenuCommands.figure}) - create new figure\n" +
                $"{MenuCommands.type} ({(int)MenuCommands.type}) - show type of figure\n" +
                $"{MenuCommands.points} ({(int)MenuCommands.points}) - show list of figure points\n" +
                $"{MenuCommands.perimeter} ({(int)MenuCommands.perimeter}) - view figure perimeter value\n" +
                $"{MenuCommands.clear} ({(int)MenuCommands.clear}) - erase screen from old info\n" +
                $"{MenuCommands.exit} ({(int)MenuCommands.exit}) - exit from program";

            if(currentCommand == MenuCommands.menu)
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

            if(IsCorrectCommand == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Command input error. Input correct command.");
                Console.ResetColor();

                currentCommand = MenuCommands.menu;

                InputCommand(ref currentCommand);
            }
        }

        
    }

}
