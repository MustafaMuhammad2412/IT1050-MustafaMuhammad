using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book_1 = new Book();
            book_1.Display();

            BookTest book_2 = new BookTest("Friends Not Masters - A Political Autobiography", "Mohammad Ayub Khan", "1967");
            book_2.display_2();

            Console.ReadLine();
        }
    }

    class Book
    {
        public string Title = "Friends Not Masters - A Political Autobiography";
        public string Author = "Mohammad Ayub Khan";
        public string Year = "1967";
        public void Display()
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nYear: {Year}");
            Console.WriteLine();
        }
    }

    class BookTest
    {
        public string title;
        public string author;
        public string year;
        public BookTest(string title, string author, string year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }

        public void display_2()
        {
            Console.WriteLine($"Title: {this.title}\nAuthor: {this.author}\nYear: {this.year}");
        }

    }
}
