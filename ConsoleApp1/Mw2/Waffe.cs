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
        private List<Aufsatz> aufsätze = new List<Aufsatz>();
        private String[] tarnung = null;

        public Waffe()
        {

        }

        public Waffe( String waffenkategorie, String name, List<Aufsatz> aufsätze, String[] tarnung) 
        {
            this.Waffenkategorie = waffenkategorie;
            this.Name = name;
            this.Aufsätze = aufsätze;
            this.Tarnung = tarnung;
        }

        public Waffe(String waffenkategorie, String name, List<Aufsatz> aufsätze)
        {
            this.Waffenkategorie = waffenkategorie;
            this.Name = name;
            this.Aufsätze = aufsätze;
        }

        public Aufsatz GetRandomAufsatz()
        {
            if (this.aufsätze.Count() > 0)
            {
                int size = this.aufsätze.Count();

                return this.aufsätze[StaticRandom.Instance.Next(0, size)]; 
            }
            return new Aufsatz();
        }

        public Aufsatz GetRandomAufsatz(Aufsatz aufsatz)
        {
            if (this.aufsätze.Count() > 0)
            {
                int size = this.aufsätze.Count();
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

        public List<Waffe> RemoveAufsätze(Aufsatz aufsatz, List<Waffe> waffenliste)
        {
            foreach (var waffe in waffenliste)
            {
                if (waffe.aufsätze.Contains(aufsatz))
                {
                    waffe.aufsätze = waffe.aufsätze.Where(x => x.Name != aufsatz.Name).ToList();
                }
            }
            return waffenliste;
        }

        public Waffe RemoveAufsatz(Aufsatz aufsatz, Waffe waffe)
        {
            waffe.aufsätze.Where(x => x.Name != aufsatz.Name).ToList();
            return waffe;
        }

        public string Waffenkategorie { get => waffenkategorie; set => waffenkategorie = value; }
        public string Name { get => name; set => name = value; }
        public List<Aufsatz> Aufsätze { get => aufsätze; set => aufsätze = value; }
        public string[] Tarnung { get => tarnung; set => tarnung = value; }
    }
}
