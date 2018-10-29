using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternIterator
{
    public class Student
    {
        private string name;
        private int sex; //male = 1,female = 2

        /// <summary>Constructor</summary>
        /// <param name="name"></param>
        /// <param name="sex"></param>
        public Student(string name, int sex)
        {
            this.name = name;
            this.sex = sex;
        }


        public string GetName()
        {
            return name;
        }

        public int GetSex()
        {
            return sex;
        }
    }
}
