using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{
    class Prim_Maschinenpistole : Primary
    {
        public Prim_Maschinenpistole()
        {

        }
        public Prim_Maschinenpistole(String name, String[] aufsätze, String[] tarnung)
        {
            this.Name = name;
            this.Aufsätze = aufsätze;
            this.Tarnung = tarnung;
        }

        public Prim_Maschinenpistole(String name, String[] aufsätze)
        {
            this.Name = name;
            this.Aufsätze = aufsätze;
        }

        public Prim_Maschinenpistole(String name)
        {
            this.Name = name;
        }
    }
}
