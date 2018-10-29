using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternIterator
{
    public class MyStudentList : StudentList, IAggregate
    {
        public MyStudentList(int studentCount):base(studentCount){ }

        public IIterator Iterator()
        {
            return new MyStudentIterator(this);
        }
    }
}
