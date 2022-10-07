using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // Creating an abstract class called "Person" and giving
    // it two properties - both, string-data-types and called
    // "FirstName" and "LastName" and declaring an abstract
    // method called "SayName()".
    public abstract class Person
    {   
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName();
    }
}   
