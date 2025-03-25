using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Student : Person
    {
        public string Major { get; set; }
        public int GraduationYear { get; set; }

        public Student(string name, string email, string id, string major, int graduationYear)
            : base(name, email, id)
        {
            Major = major;
            GraduationYear = graduationYear;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Major: {Major}, Graduation Year: {GraduationYear}");
        }
    }
}