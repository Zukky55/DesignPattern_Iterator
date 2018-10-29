using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternIterator
{
    public class StudentList
    {
        protected Student[] students;
        private int last = 0;

        public StudentList() { }
        public StudentList(int studentCount)
        {
            students = new Student[studentCount];
        }

        public void Add (Student student)
        {
            students[last] = student;
            last++;
        }

        public Student GetStudentAt(int index)
        {
            return students[index];
        }

        public int GetLastNum()
        {
            return last;
        }
    }
}
