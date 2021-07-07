using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static InputTools.ProgramElementEdit;
using static InputTools.UIFeatures;

namespace Task02
{
    partial class Program
    {
        public static void AddBook(ref Book[] books)
        {
            DrawSymbolLine(50, '-');
            Console.Write("Input book title: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string title = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Input book author: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string author = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Input book content: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string content = Console.ReadLine();
            Console.ResetColor();
            DrawSymbolLine(10, 50, '-');
            Book newBook = new Book(title, author, content);
            AddItemToArray<Book>(ref books, newBook);
            Console.WriteLine("done!");
            DrawSymbolLine(50, '-');

        }

        public static void DeleteBook(ref Book[] books, ref Book selectedBook)
        {
            int bookIndex;
            bool deleteSelected = true;


            DrawSymbolLine(50, '-');

            if(books.Length == 0)
            {
                Console.WriteLine("There is no books in list. You can't do delete opearation");
                return;
            }

            if(selectedBook != null)
            {
                Console.WriteLine("Delete selected book, or book by index? - ");
                deleteSelected = Console.ReadLine() == "y" ? true : false;
            }

            if (!deleteSelected || selectedBook == null)
            {
                Console.WriteLine("Input index of book in list: ");
                bookIndex = Convert.ToInt32(Console.ReadLine());
                RemoveItemFromArray(ref books, books[bookIndex]);
                return;
            }

            RemoveItemFromArray(ref books, selectedBook);

            selectedBook = null;            

            DrawSymbolLine(50, '-');
        }

        public static void SelectBook(ref Book[] books, out Book selectedBook)
        {
            DrawSymbolLine(50, '-');
            Console.WriteLine("Input index of the book: ");
            int index = Convert.ToInt32(Console.ReadLine());
            // TODO проверка на корректность ввоода индекса
            selectedBook = books[index];
            DrawSymbolLine(10, 50, '-');
        }

        public static void ShowBookList(Book[] books)
        {
            if(books.Length < 1)
            {
                Console.WriteLine();
                Console.WriteLine("There is no books in list");
                Console.WriteLine();
                return;
            }
            DrawSymbolLine(50, '-');
            for(int i = 0; i < books.Length; i++)
            {
                Console.Write(i + " - ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                books[i].Author.Show();
                Console.Write(" - ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                books[i].Title.Show();
                Console.Write(" - ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                books[i].Content.Show();
                Console.Write(" - ");
                Console.ResetColor();                
                Console.WriteLine();
            }
            DrawSymbolLine(50, '-');
        }

        public static void ShowSelectedBook(Book[] bookList, Book selectedBook)
        {
            if(selectedBook == null)
            {
                Console.WriteLine();
                Console.WriteLine("There is no selected books");
                Console.WriteLine();
                return;
            }

            DrawSymbolLine(50, '-');
            Console.ForegroundColor = ConsoleColor.Magenta;
            selectedBook.Author.Show();
            Console.Write(" - ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            selectedBook.Title.Show();
            Console.Write(" - ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            selectedBook.Content.Show();
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine($"Index in list = {Array.IndexOf(bookList, selectedBook)}");
            DrawSymbolLine(50, '-');

        }
    }
}
