using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{
    class Todesserie
    {
        private String name = null;
        public Todesserie()
        {
            String[] Todesserie_list = { "Trittbrettfahrer", "Juiced", "Martyrium", "Letztes Gefecht!" };

            this.name = Todesserie_list[StaticRandom.Instance.Next(0, 3)];

        }

        public string Name { get => name; set => name = value; }
    }
}
