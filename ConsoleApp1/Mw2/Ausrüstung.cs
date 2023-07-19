using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{
    class Ausrüstung
    {
        private String name = null;
        public Ausrüstung()
        {
            String[] ausrüstung_list = { "Splitter", "Semtex", "Wurfmesser", "Taktikeinstieg", "Visier", "Claymore", "C4" };

            this.name = ausrüstung_list[StaticRandom.Instance.Next(0, 6)];
        }

        public string Name { get => name; set => name = value; }
    }
}
