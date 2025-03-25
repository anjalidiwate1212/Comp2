using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        public List<Book> Books { get; private set; }
        public List<Person> Patrons { get; private set; }

        public Library()
        {
            Books = new List<Book>();
            Patrons = new List<Person>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddPatron(Person patron)
        {
            Patrons.Add(patron);
        }

        public void DisplayBooks()
        {
            Console.WriteLine("\nBooks in Library:");
            foreach (var book in Books)
            {
                book.DisplayBookInfo();
            }
        }

        public void DisplayPatrons()
        {
            Console.WriteLine("\nPatrons in Library:");
            foreach (var patron in Patrons)
            {
                patron.DisplayInfo();
            }
        }

        public bool BorrowBook(string bookTitle, string patronName)
        {
            Book book = Books.Find(b => b.Title == bookTitle);
            if (book != null && book.BorrowBook())
            {
                Console.WriteLine($"{patronName} borrowed '{bookTitle}'");
                return true;
            }
            Console.WriteLine($"{bookTitle} is not available for borrowing.");
            return false;
        }
    }
}