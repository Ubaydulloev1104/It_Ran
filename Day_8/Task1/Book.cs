using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    public class Book
    {
        public string Title { get ; set; }
        public string Author { get ; set; }
        public string Genre { get ; set; }
        public override string ToString()
        {
            return $"{Title}-{Author}-{Genre}-";
        }
    }
}
