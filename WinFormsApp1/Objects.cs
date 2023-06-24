using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Class
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Number { get; set; }
        public double AverageGrade { get; set; }
    }
}
