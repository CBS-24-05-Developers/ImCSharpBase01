using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Title
    {
        string title;

        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.Write(title);
        }
    }

    public class Author
    {
        string author;

        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.Write(author);
        }
    }

    public class Content
    {
        string content;

        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.Write(content);
        }
    }
}
