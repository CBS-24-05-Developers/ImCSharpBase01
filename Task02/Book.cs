using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Book
    {
        Title bookTitle;
        Author bookAuthor;
        Content bookContent;

        public Book(string title, string author, string content)
        {
            bookTitle = new Title(title);
            bookAuthor = new Author(author);
            bookContent = new Content(content);
        }
    }
}
