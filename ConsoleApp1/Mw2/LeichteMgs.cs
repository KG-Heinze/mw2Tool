using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{
    class LeichteMgs : Primary
    {
        public LeichteMgs()
        {

        }
        public LeichteMgs(String name, Aufsatz[] aufsätze, String[] tarnung)
        {
            this.Name = name;
            this.Aufsätze = aufsätze;
            this.Tarnung = tarnung;
        }

        public LeichteMgs(String name, Aufsatz[] aufsätze)
        {
            this.Name = name;
            this.Aufsätze = aufsätze;
        }

        public LeichteMgs(String name)
        {
            this.Name = name;
        }
    }
}
