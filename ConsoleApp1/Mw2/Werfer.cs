using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{
    class Werfer : Secondary
    {
        public Werfer()
        {

        }

        public Werfer(String name, Aufsatz[] aufsätze, String[] tarnung)
        {
            this.Name = name;
            this.Aufsätze = aufsätze;
            this.Tarnung = tarnung;
        }

        public Werfer(String name)
        {
            this.Name = name;
        }
    }
}
