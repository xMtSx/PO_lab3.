using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal abstract class Item
    {

        protected int _id;
        protected string _title, _publisher;
        protected DateTime _dateOfIssue;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value;}
        }

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public DateTime DateOfIssue
        {
            get { return _dateOfIssue; }
            set
            {
                _dateOfIssue = value;
            }
        }

        public Item (){ }

        public Item (int id, string title, string publisher, DateTime dateOfIssue)
        {
            this.Id = id;
            this.Title = title;
            this.Publisher = publisher;
            this.DateOfIssue = dateOfIssue;

        }

        public override string ToString()
        {
            return $"{_id} {_title} {_publisher} {_dateOfIssue}";
        }

        public virtual void Details()
        {
            Console.WriteLine(this);
        }

        public abstract string GenerateBarCode() ;
       
    }
}
