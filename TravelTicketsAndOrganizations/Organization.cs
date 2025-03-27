using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursovWork_
{
    internal class Organization
    {
        private int id { get; set; }
        private string name { get; set; }
        private string description { get; set; }

        private Organization(int id, string name, string description) { }
    }
}
