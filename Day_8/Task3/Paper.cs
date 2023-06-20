using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Paper
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Editions { get; set; }

        public string GetInfo()
        {
            return $"{Date}, {Name}, {Editions}";
        }
    }
}
