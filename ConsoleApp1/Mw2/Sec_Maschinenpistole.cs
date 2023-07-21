using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{
    class Sec_Maschinenpistole : Secondary
    {
        public Sec_Maschinenpistole()
        {

        }

        public Sec_Maschinenpistole(String name, List<Aufsatz> aufsätze, String[] tarnung)
        {
            this.Name = name;
            this.Aufsätze = aufsätze;
            this.Tarnung = tarnung;
        }

        public Sec_Maschinenpistole(String name, List<Aufsatz> aufsätze)
        {
            this.Name = name;
            this.Aufsätze = aufsätze;
        }
    }
}
