using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{
    class Spezialgranate
    {
        private String name = null;
        public Spezialgranate()
        {
            String[] Spezialgranate_list = { "Blendgranate", "Handgranate", "Rauchgranate" };

            this.Name = Spezialgranate_list[StaticRandom.Instance.Next(0, 2)];
        }

        public string Name { get => name; set => name = value; }
    }
}
