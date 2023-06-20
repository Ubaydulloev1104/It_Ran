using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3
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
        public string GetInfo()
        {
            return $"{Title}, {Author}, {Genre}";
        }
    }
}
