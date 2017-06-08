using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
