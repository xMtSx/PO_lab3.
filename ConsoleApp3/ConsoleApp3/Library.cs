using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Library : ItemManagment
    {

        public string Adres
        {
            get;
            set;
        }

        public IList<Librarian> librarians
        {
            get;
            set;
        }

        public IList<Catalog> catalogs
        {
            get;
            set;
        }

        public Library(string adres, IList<Librarian> librarians, IList<Catalog> catalogs)
        {
            Adres = adres;
            this.librarians = librarians;
            this.catalogs = catalogs;
        }

        public void AddLibrarian(Librarian librarian)
        {
            librarians.Add(librarian);
        }

        public void ShowAllLibrarians()
        {
            string L = ToString();
            foreach (Librarian items in librarians)
            {
                L += items.ToString();
            }
            Console.WriteLine(L);
        }


        public void AddCatalog(Catalog catalog1)
        {
            catalogs.Add(catalog1);
        }

        public void AddItem(Item item, string thematicDepartment)
        {
            foreach (Catalog catalog in catalogs) 
            {
                if (catalog.ThematicDepartment == thematicDepartment) catalog.AddItem(item);
                break;
            }
        }

        public void ShowAllItems()
        {
            string C = base.ToString();
            foreach (Catalog catalog in catalogs)
            {

                foreach (Item items in catalog.Items)
                {

                    C += items.ToString();
                }
            }

            Console.WriteLine(C);
        }

        public Item FindItemBy(int id)
        {
            foreach (Catalog catalog in catalogs)
            {
                foreach (Item item in catalog.Items)
                {
                    if (item.Id == id) return item;
                }
            }
            return null;
        }

        public Item FindItemBy(string title)
        {
            foreach (Catalog catalog in catalogs)
            {
                foreach (Item item in catalog.Items)
                {
                    if (item.Title == title) return item;
                }
            }
            return null;
        }

        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {

            Func<Item, bool> expression = predicate.Compile();
            foreach (Catalog catalog in catalogs)
                foreach (Item item in catalog.Items)
            {
                if (expression(item)) return item;
            }
            return null;
        }
    }
}
