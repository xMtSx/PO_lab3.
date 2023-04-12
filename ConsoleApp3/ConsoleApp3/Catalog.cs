using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Catalog : ItemManagment
    {
        public IList<Item> Items
        {
            get;
            set;
        }

        public string ThematicDepartment
        {
            get;
            set;
        }

        public Catalog (string thematicDepartment,IList<Item> items)
        {
            Items = items;
            ThematicDepartment = thematicDepartment;
        }

        public Catalog (IList<Item> item)
        {

        }

        public void AddItem (Item item)
        {
            Items.Add(item);
        }

        public override string ToString()
        {
            string C = base.ToString();
            foreach (Item items in Items)
            {
                C += items.ToString();
            }
            return ThematicDepartment + " " + C;
        }

        public void ShowAllItems()
        {
            string C = base.ToString();
            foreach (Item items in Items)
            {
                C += items.ToString();
            }
            Console.WriteLine(C);
        }

        public Item FindItemBy(int id)
        {
            foreach (Item item in Items)
            {
                if (item.Id == id) return item;
            }
            return null;
        }

        public Item FindItemBy(string title)
        {
            foreach (Item item in Items) 
            {
                if (item.Title==title ) return item;
            }
            return null;
        }

        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {

           Func<Item, bool> expression = predicate.Compile();

           foreach (Item item in Items) 
            {
                if (expression(item)) return item;
            }
            return null;
        }
    }
}
