using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Journal : Item
    {
        public int Number
        {
            get; 
            set;
        }

        public Journal() { }

        public Journal (string publisher, int id, string title, DateTime dateOfIssue,int number) : base(id,title, publisher,dateOfIssue)
        {
            Id = id;
            Title = title;
            Publisher = publisher;
            DateOfIssue = dateOfIssue;
            Number = number;
        }

        public override string ToString()
        {
            return base.ToString() + $"{Number}";
        }



        public override string GenerateBarCode()
        {
            return $"{Id}";
        }

        
    }
}
