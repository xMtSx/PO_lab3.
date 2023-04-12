using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Book : Item
    {
        public int PageCount
        {
            get;
            set;
        }

        public IList<Author> Authors
        {
            get;
            set;
        }

        public Book (string publisher, int id, string title, DateTime dateOfIssue, int pageCount, IList<Author> authors) :base (id, title, publisher, dateOfIssue)
        {
            Id = id;
            Title = title;
            Publisher = publisher;
            DateOfIssue = dateOfIssue;
            PageCount = pageCount;
            Authors = new List<Author>();
        }

        public override string ToString()
        {
           string A = base.ToString() + $"{PageCount}";

            foreach (Author author in Authors)
                A += author.ToString();

            return A;
        }

        public void AddAuthor (Author author) 
        {
            Authors.Add(author); 
        }

        public override string GenerateBarCode()
        {
            return $"{DateOfIssue} {Id}";
        }
    }
}
