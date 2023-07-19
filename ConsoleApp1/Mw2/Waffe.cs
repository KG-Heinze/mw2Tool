using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{

    public class Waffe
    {
        private String waffenkategorie = null;
        private String name = null;
        private String[] aufsätze = null;
        private String[] tarnung = null;

        public Waffe()
        {

        }

        public Waffe( String waffenkategorie, String name, String[] aufsätze, String[] tarnung) 
        {
            this.Waffenkategorie = waffenkategorie;
            this.Name = name;
            this.Aufsätze = aufsätze;
            this.Tarnung = tarnung;
        }

        public Waffe(String waffenkategorie, String name, String[] aufsätze)
        {
            this.Waffenkategorie = waffenkategorie;
            this.Name = name;
            this.Aufsätze = aufsätze;
        }

        public String getRandomAufsatz()
        {
            if (this.aufsätze != null)
            {
                int size = this.aufsätze.Count();

                return this.aufsätze[StaticRandom.Instance.Next(0, size - 1)]; ;
            }
            return "";
        }


        public string Waffenkategorie { get => waffenkategorie; set => waffenkategorie = value; }
        public string Name { get => name; set => name = value; }
        public string[] Aufsätze { get => aufsätze; set => aufsätze = value; }
        public string[] Tarnung { get => tarnung; set => tarnung = value; }
    }
}
