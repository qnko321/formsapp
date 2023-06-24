using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public delegate void AddStudentCallback(int classIndex, string name, int[] grades);

    public delegate void AddClassCallback(string name);
}
