using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int AvailableCopies { get; private set; }

        public Book(string title, string author, string isbn, int availableCopies)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            AvailableCopies = availableCopies;
        }

        public bool BorrowBook()
        {
            if (AvailableCopies > 0)
            {
                AvailableCopies--;
                return true;
            }
            return false;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Available Copies: {AvailableCopies}");
        }
    }
}
