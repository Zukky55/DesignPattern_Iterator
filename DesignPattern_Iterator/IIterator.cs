using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternIterator
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
