using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{
    class Aufsatzfactory
    {
        List<Aufsatz> Aufsätze= new List<Aufsatz>();

        public Aufsatzfactory()
        {
            Aufsatz granatenwerfer = new Aufsatz("Granatenwerfer", "Aufsatz");
            Aufsatz rotpunktvisier = new Aufsatz("Rotpunktvisier", "Visier");
            Aufsatz schalldämpfer = new Aufsatz("Schalldämpfer", "Normal");
            Aufsatz acog = new Aufsatz("ACOG-Zielfernrohr", "Visier");
            Aufsatz vollmantelgeschoss = new Aufsatz("Vollmantelgeschoss", "Normal");
            Aufsatz schrotflinte = new Aufsatz("Schrotflinte", "Aufsatz");
            Aufsatz holographisches_Visier = new Aufsatz("Holographisches Visier", "Visier");
            Aufsatz herzschlagsensor = new Aufsatz("Herzschlagsensor", "Normal");
            Aufsatz thermal = new Aufsatz("Thermal", "Visier");
            Aufsatz erweiterte_Magazine = new Aufsatz("Erweiterte Magazine", "Normal");
            Aufsatz schnellfeuer = new Aufsatz("Schnellfeuer", "Normal");
            Aufsatz akimbo = new Aufsatz("Akimbo", "Visier");
            Aufsatz taktik = new Aufsatz("Taktikmesser", "Aufsatz");
            Aufsatz griff = new Aufsatz("Griff", "Normal");

            this.Aufsätze.Add(granatenwerfer);
            this.Aufsätze.Add(rotpunktvisier);
            this.Aufsätze.Add(schalldämpfer);
            this.Aufsätze.Add(acog);
            this.Aufsätze.Add(vollmantelgeschoss);
            this.Aufsätze.Add(schrotflinte);
            this.Aufsätze.Add(holographisches_Visier);
            this.Aufsätze.Add(herzschlagsensor);
            this.Aufsätze.Add(thermal);
            this.Aufsätze.Add(erweiterte_Magazine);
            this.Aufsätze.Add(schnellfeuer);
            this.Aufsätze.Add(akimbo);
            this.Aufsätze.Add(griff);
            this.Aufsätze.Add(taktik);
        }

        public Aufsatz Get_Aufsatz_By_Name(String name)
        {
            return Aufsätze.Single(s => s.Name == name);
        }

        public Aufsatz[] Get_Aufsatz_By_Name(String[] nameArray)
        {
            Aufsatz[] output = new Aufsatz[nameArray.Length];

            for (int i = 0; i < nameArray.Length; i++)
            {
                output[i] = Get_Aufsatz_By_Name(nameArray[i]);
            }

            return output;
        }
    }
}
