using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3a_przec
{
    internal class ListaTM
    {
        public List<Element> elements;
    }

    internal class Element
    {
        public string name;
        public int number;
        public string symbol;
        public int xpos;
        public int ypos;
        public decimal atomic_mass;
    }
}
