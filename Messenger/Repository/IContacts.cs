using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sliding_Application
{
    public interface IContacts<T>
    {
        List<T> ListOfContacts { get; }

    }
}
