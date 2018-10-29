using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesignPatternIterator
{
    public class MyTeacher : Teacher
    {
        private StudentList studentList;
        private Student[] students =
        {
            new Student("赤井亮太", 1),
            new Student("赤羽里美", 2),
            new Student("岡田美央", 2),
            new Student("西森俊介", 1),
            new Student("中ノ森玲菜", 2)
        };


        public override void CreateStudentList()
        {
            studentList = new StudentList(30);
        }

        public override void CallStudents()
        {
            //for (int i = 0; i < studentList.GetLastNum(); i++)
            //{
            //    var student = studentList.GetStudentAt(i);
            //    Console.WriteLine(student.getName() + " " + student.getSex());
            //}

            
        }
    }
}
