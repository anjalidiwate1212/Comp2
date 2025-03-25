namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            Student student2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);

            student1.DisplayInfo();
            student2.DisplayInfo();

             // Creating staff
            Staff staff1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");
            staff1.DisplayInfo();

            Book book1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            Book book2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            Book book3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);

            book1.DisplayBookInfo();

        }
    }
}
