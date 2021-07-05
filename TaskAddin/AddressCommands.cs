using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAddin
{
    public enum AddressCommands
    {
        menu,
        input,
        show,
        current,
        delete,
        exit
    }

    public partial class Program
    {      

        public static void ShowMenu()
        {
            string menuItems =
                $"{AddressCommands.menu} - show menu\n" +
                $"{AddressCommands.input} - input new address in address book\n" +
                $"{AddressCommands.show} - show address in address book by index\n" +
                $"{AddressCommands.current} - set current address by index\n" +
                $"{AddressCommands.delete} - delete current address\n" +
                $"{AddressCommands.exit} - exit from programm";

            Console.WriteLine(menuItems);
        }

        public static void CommandsSelector(ref AddressCommands currentCommand)
        {
            switch (currentCommand)
            {
                case (AddressCommands.menu):
                    break;
                case (AddressCommands.input):
                    break;
                case (AddressCommands.current):
                    break;
                case (AddressCommands.show):
                    break;
                case (AddressCommands.delete):
                    break;
                case (AddressCommands.exit):
                    break;
                default:
                    break;
            }
        }
    }

}
