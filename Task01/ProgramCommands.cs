using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    partial class Program
    {
        public static void ShowMenu()
        {
            string menuItems =
                $"{ProgramCommands.create} - show menu\n" +
                $"{ProgramCommands.setw} - input new address in address book\n" +
                $"{ProgramCommands.seth} - show address in address book by index\n" +
                $"{ProgramCommands.showw} - set current address by index\n" +
                $"{ProgramCommands.showh} - delete current address\n" +
                $"{ProgramCommands.showa} - show rectangle area\n" +
                $"{ProgramCommands.showp} - show rectangle perimeter\n" +
                $"{ProgramCommands.exit} - exit from programm";

            Console.WriteLine(menuItems);
        }

        public static void CommandsSelector(ref ProgramCommands currentCommand)
        {
            switch (currentCommand)
            {
                case (ProgramCommands.create):
                    break;
                case (ProgramCommands.setw):
                    break;
                case (ProgramCommands.seth):
                    break;
                case (ProgramCommands.showh):
                    break;
                case (ProgramCommands.showw):
                    break;
                case (ProgramCommands.showp):
                    break;
                case (ProgramCommands.showa):
                    break;
                case (ProgramCommands.exit):
                    break;
            }
        }
    }

    enum ProgramCommands
    {
        create,
        setw,
        seth,
        showh,
        showw,
        showp,
        showa,
        exit,
    }
}
