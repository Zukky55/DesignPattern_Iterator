using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternIterator
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            Teacher you = new MyTeacher();

             //= you.AddStudent();
            you.CreateStudentList();
            you.CallStudents();
        }
    }
}
