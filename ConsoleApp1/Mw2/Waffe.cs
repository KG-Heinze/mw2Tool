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
        private Aufsatz[] aufsätze = null;
        private String[] tarnung = null;

        public Waffe()
        {

        }

        public Waffe( String waffenkategorie, String name, Aufsatz[] aufsätze, String[] tarnung) 
        {
            this.Waffenkategorie = waffenkategorie;
            this.Name = name;
            this.Aufsätze = aufsätze;
            this.Tarnung = tarnung;
        }

        public Waffe(String waffenkategorie, String name, Aufsatz[] aufsätze)
        {
            this.Waffenkategorie = waffenkategorie;
            this.Name = name;
            this.Aufsätze = aufsätze;
        }

        public Aufsatz getRandomAufsatz()
        {
            if (this.aufsätze != null)
            {
                int size = this.aufsätze.Length;

                return this.aufsätze[StaticRandom.Instance.Next(0, size)]; 
            }
            return new Aufsatz();
        }

        public Aufsatz getRandomAufsatz(Aufsatz aufsatz)
        {
            if (this.aufsätze != null)
            {
                int size = this.aufsätze.Length;
                if (aufsatz.Typ != "normal")
                {
                    Aufsatz[] test = aufsätze.Where(s => s.Typ != aufsatz.Typ).ToArray();
                    size = test.Length;
                    return test[StaticRandom.Instance.Next(0, size)];
                }
                return this.aufsätze[StaticRandom.Instance.Next(0, size)];
            }
            return new Aufsatz();
        }



        public string Waffenkategorie { get => waffenkategorie; set => waffenkategorie = value; }
        public string Name { get => name; set => name = value; }
        public Aufsatz[] Aufsätze { get => aufsätze; set => aufsätze = value; }
        public string[] Tarnung { get => tarnung; set => tarnung = value; }
    }
}
