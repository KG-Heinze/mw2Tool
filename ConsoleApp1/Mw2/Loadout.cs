using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{
    class Loadout
    {
        private Perks perks = null;
        private Ausrüstung ausrüstung = null;
        private Spezialgranate spezialgranate = null;
        private Todesserie todesserie = null;
        private Waffe secondary_waffe = null;
        private Waffe primary_waffe = null;

        public Loadout(Waffenfactory wf, Perks perks)
        {

            //StressTest(wf, perks);

            this.Perks = perks;
            perks.GetRandomPerks();
            this.ausrüstung = new Ausrüstung();
            this.todesserie = new Todesserie();
            this.spezialgranate = new Spezialgranate();
            this.secondary_waffe = wf.GetRandomSecondaryWeapon();
            this.primary_waffe = wf.GetRandomPrimaryWeapon();


            Printloadout();
        }

        public void Printloadout()
        {
            if (this.perks.Perk1 == "Aufsatz Pro")
            {
                Console.Write("Primary: " + this.primary_waffe.Name);
                if (this.primary_waffe.Aufsätze.Count() > 0)
                {
                    Aufsatz first_Aufsatz = this.primary_waffe.GetRandomAufsatz();
                    Console.Write(" | Aufsatz: " + first_Aufsatz.Name + " + " + this.primary_waffe.GetRandomAufsatz(first_Aufsatz).Name);
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.Write("Secondary: " + this.secondary_waffe.Name);
                if (this.secondary_waffe.Aufsätze.Count() > 0)
                {
                    Console.Write(" | Aufsatz: " + this.secondary_waffe.GetRandomAufsatz().Name);
                }
            }
            else
            {
                Console.Write("Primary: " + this.primary_waffe.Name);
                if (this.primary_waffe.Aufsätze.Count() > 0 )
                {
                    Console.Write(" | Aufsatz: " + this.primary_waffe.GetRandomAufsatz().Name);
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.Write("Secondary: " + this.secondary_waffe.Name);
                if (this.secondary_waffe.Aufsätze.Count() > 0)
                {
                    Console.Write(" | Aufsatz: " + this.secondary_waffe.GetRandomAufsatz().Name);
                }

            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("Perk1: " + this.Perks.Perk1);
            Console.WriteLine(" ");

            Console.WriteLine("Perk2: " + this.Perks.Perk2);
            Console.WriteLine(" ");

            Console.WriteLine("Perk3: " + this.Perks.Perk3);
            Console.WriteLine(" ");

            Console.WriteLine("Ausrüstung: " + this.ausrüstung.Name);
            Console.WriteLine(" ");

            Console.WriteLine("Spezialgranate: " + this.spezialgranate.Name);
            Console.WriteLine(" ");

            Console.WriteLine("Todesserie: " + this.todesserie.Name);
            Console.WriteLine(" ");

        }

        public void StressTest(Waffenfactory wf, Perks perks)
        {
            for (int i = 1; i < 1000; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine(i);
                this.perks = perks;
                perks.GetRandomPerks();
                this.ausrüstung = new Ausrüstung();
                this.todesserie = new Todesserie();
                this.spezialgranate = new Spezialgranate();
                this.primary_waffe = wf.GetRandomPrimaryWeapon();
                this.secondary_waffe = wf.GetRandomSecondaryWeapon();


                Printloadout();
            }
        }
        public Perks Perks { get => perks; set => perks = value; }
        public Perks Perks1 { get => perks; set => perks = value; }
        internal Ausrüstung Ausrüstung { get => ausrüstung; set => ausrüstung = value; }
        internal Spezialgranate Spezialgranate { get => spezialgranate; set => spezialgranate = value; }
        internal Todesserie Todesserie { get => todesserie; set => todesserie = value; }
        public Waffe Secondary_waffe { get => secondary_waffe; set => secondary_waffe = value; }
        public Waffe Primary_waffe { get => primary_waffe; set => primary_waffe = value; }
    }
}
