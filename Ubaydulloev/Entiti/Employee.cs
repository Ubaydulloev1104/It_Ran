using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubaydulloev.Entiti
{
    public class Employee : User
    {
        public decimal Salaru { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
    }
}
