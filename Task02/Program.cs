using System;

using static InputTools.UIFeatures;

namespace Task02
{
    partial class Program
    {
        static void Main(string[] args)
        {
            MenuCommands currentCommand = MenuCommands.menu;
            Book[] bookList = new Book[] { };
            Book selectedBook = null;

            do
            {
                InputCommand(ref currentCommand);

                switch (currentCommand)
                {
                    case (MenuCommands.menu):
                        currentCommand = MenuCommands.menu;
                        break;
                    case (MenuCommands.add):
                        AddBook(ref bookList);
                        break;
                    case (MenuCommands.delete):
                        DeleteBook(ref bookList, ref selectedBook);
                        break;
                    case (MenuCommands.list):
                        ShowBookList(bookList);
                        break;
                    case (MenuCommands.select):
                        SelectBook(ref bookList, out selectedBook);
                        break;
                    case (MenuCommands.showselected):
                        ShowSelectedBook(bookList, selectedBook);
                        break;
                    case (MenuCommands.edit):
                        Console.WriteLine();
                        Console.WriteLine("Feature in development");
                        Console.WriteLine();
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


    }
}
