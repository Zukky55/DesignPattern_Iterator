using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesignPatternIterator
{
    public abstract class Teacher
    {
        public abstract void CallStudents();

        public abstract void CreateStudentList();

        public Student AddStudent()
        {
            string name;
            string buff;
            int sex;

            Console.WriteLine("名前 : ");
            name = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("性別(male = 1, female = 2) : ");
                buff = Console.ReadLine();
                if (Regex.IsMatch(buff, "[12]"))
                {
                    sex = int.Parse(buff);
                    break;
                }
                else
                {
                    Console.WriteLine("You must input 1 or 2.\n");
                    continue;
                }
            }
            return new Student(name, sex);
        }
    }
}
