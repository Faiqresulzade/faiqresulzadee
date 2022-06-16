using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Worker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int maash { get; set; }
        public int Id { get; }
        private static int _id=1;
        public Worker()
        {
            Id = _id;
            _id++;
        }
    }
}
