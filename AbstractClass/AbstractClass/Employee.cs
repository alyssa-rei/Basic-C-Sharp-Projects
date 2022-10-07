using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // Creating an "Employee" class and having it inherit from
    // the "Person" class; printing "FirstName" and "LastName".
    class Employee : Person
    {
        public override void SayName()
        {
            Console.Write("Name: " + FirstName + " " + LastName);
        }
    }
}
