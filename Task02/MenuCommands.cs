using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static InputTools.UIFeatures;

namespace Task02
{
    partial class Program
    {
        public static void InputCommand(ref MenuCommands currentCommand)
        {
            bool IsCorrectCommand = false;

            string menu =
                $"{MenuCommands.menu} - show menu\n" +
                $"{MenuCommands.add} - add new book\n" +
                $"{MenuCommands.delete} - delete book by index or selected\n" +
                $"{MenuCommands.list} - show books list\n" +
                $"{MenuCommands.select} - select book\n" +
                $"{MenuCommands.showselected} - show selected book\n" +
                $"{MenuCommands.edit} - edit selected book\n" +
                $"{MenuCommands.clear} - clear console\n" +
                $"{MenuCommands.exit} - view height for rectangle";
                

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
        add,
        delete,
        list,
        select,
        showselected,
        edit,
        clear,
        exit,
    }
}
