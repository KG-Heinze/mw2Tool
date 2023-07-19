using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{
    
    class Aufsatz
    {
        private String name = null;
        private Aufsatztyp typ = null;
        public Aufsatz()
        {

        }
        public Aufsatz(String name, Aufsatztyp typ)
        {
            this.name = name;
            this.typ = typ;
        }

        public string Name { get => name; set => name = value; }
        internal Aufsatztyp Typ { get => typ; set => typ = value; }
    }
}
