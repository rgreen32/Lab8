using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Library: ILibrary
    {
        private Dictionary<string, Book> Storage;


        public Library()
        {
            Book book1 = new Book("To Kill A MockingBird", "SomeGuy", 100);
            Book book2 = new Book("Americana", "Shemamonda", 100);
            Book book3 = new Book("Berserk", "Kentaro Miura", 100);
            Storage.Add(book1.Title, book1);
            Storage.Add(book2.Title, book2);
            Storage.Add(book3.Title, book3);
        }

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {

        }
    }
}
