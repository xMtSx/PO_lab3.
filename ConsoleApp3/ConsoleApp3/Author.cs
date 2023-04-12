﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Author
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
        
        public string Nationality
        {
            get;
            set;
        }

        public Author() { }

        public Author (string firstName, string lastName, string nationality)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Nationality}";
        }
    }
}
