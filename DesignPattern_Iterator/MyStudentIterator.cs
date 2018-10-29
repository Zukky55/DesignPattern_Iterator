using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternIterator
{
    class MyStudentIterator : IIterator
    {
        private MyStudentList myStudentList;
        private int index;

        public MyStudentIterator(MyStudentList myStudentList)
        {
            this.myStudentList = myStudentList;
            index = 0;
        }

        public bool HasNext()
        {
            if(myStudentList.GetLastNum() > index)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Next()
        {
            Student s = myStudentList.GetStudentAt(index);
            index++;
            return s;
        }
    }
}
