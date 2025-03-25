namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library usfLibrary = new Library();
            Student student1 = new Student("Rohit", "rohit@usf.edu", "S001", "Business Analytics", 2026);
            Student student2 = new Student("mandy", "mandy@usf.edu", "S002", "Information Systems", 2025);

            Staff staff1 = new Staff("brandon singh", "bransingh@usf.edu", "ST001", "Librarian", "Library Services");

            Book book1 = new Book("Distributed System", "Liam Reynolds", "ISBN111", 4);
            Book book2 = new Book("Business Insights", "Olivia Carter", "ISBN222", 3);
            Book book3 = new Book("Analytics in AI", "Nathan Brooks", "ISBN333", 6);

            usfLibrary.AddBook(book1);
            usfLibrary.AddBook(book2);
            usfLibrary.AddBook(book3);

            usfLibrary.AddPatron(student1);
            usfLibrary.AddPatron(student2);
            usfLibrary.AddPatron(staff1);

            usfLibrary.DisplayBooks();
            usfLibrary.DisplayPatrons();

            Console.WriteLine("\nBorrowing Books...");
            usfLibrary.BorrowBook("Business Insights", "mandy");
            usfLibrary.BorrowBook("Analytics in AI", "rohit");

            Console.WriteLine("\nBooks after borrowing:");
            usfLibrary.DisplayBooks();

        }
    }
}
