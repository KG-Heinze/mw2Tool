using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{
    class Schrotflinte : Secondary
    {
        public Schrotflinte()
        {

        }

        public Schrotflinte(String name, String[] aufsätze, String[] tarnung)
        {
            this.Name = name;
            this.Aufsätze = aufsätze;
            this.Tarnung = tarnung;
        }

        public Schrotflinte(String name, String[] aufsätze)
        {
            this.Name = name;
            this.Aufsätze = aufsätze;
        }
    }
}
