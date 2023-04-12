using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Person
    {
        public string FirstName 
        {
            get;
            set; 
        }
        public string LastName 
        { 
            get;
            set; 
        }

        public Person () { }

        public Person (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public virtual void Details()
        {
            Console.WriteLine(this);
        }
    }
}
