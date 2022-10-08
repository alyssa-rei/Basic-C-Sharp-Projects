using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{   
    // Creating an "IQuittable" interface and defining
    // a void method called "Quit()"
    interface IQuittable
    {
        void Quit(string FirstName, string LastName);
    }
}
