using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Library
    {
        public string Name  { get; set; }
        public List<Worker> _workers;
        public List<Book> _books;
        public Library()
        {
            _workers = new List<Worker>();
            _books = new List<Book>();
        }

    }
}
