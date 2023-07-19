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

        public Loadout()
        {
            Aufsatzfactory af = new Aufsatzfactory();

            Waffenfacory wf = new Waffenfacory(af);
            //stressTest(wf);

            this.Perks = new Perks();
            this.ausrüstung = new Ausrüstung();
            this.todesserie = new Todesserie();
            this.spezialgranate = new Spezialgranate();
            this.secondary_waffe = wf.getRandomSecondaryWeapon();
            this.primary_waffe = wf.getRandomPrimaryWeapon();


            printloadout();
        }

        public void printloadout()
        {
            if (this.Perks.Perk1 == "Aufsatz Pro")
            {
                Console.Write("Primary: " + this.primary_waffe.Name);
                if (this.primary_waffe.Aufsätze != null)
                {
                    Aufsatz first_Aufsatz = this.primary_waffe.getRandomAufsatz();
                    Console.Write(" | Aufsatz: " + first_Aufsatz.Name + " + " + this.primary_waffe.getRandomAufsatz(first_Aufsatz).Name);
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.Write("Secondary: " + this.secondary_waffe.Name);
                if (this.secondary_waffe.Aufsätze != null)
                {
                    Console.Write(" | Aufsatz: " + this.secondary_waffe.getRandomAufsatz().Name);
                }
            }
            else
            {
                Console.Write("Primary: " + this.primary_waffe.Name);
                if (this.primary_waffe.Aufsätze != null)
                {
                    Console.Write(" | Aufsatz: " + this.primary_waffe.getRandomAufsatz().Name);
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.Write("Secondary: " + this.secondary_waffe.Name);
                if (this.secondary_waffe.Aufsätze != null)
                {
                    Console.Write(" | Aufsatz: " + this.secondary_waffe.getRandomAufsatz().Name);
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

        public void stressTest(Waffenfacory wf)
        {
            for (int i = 1; i < 1000; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine(i);
                this.Perks = new Perks();
                this.ausrüstung = new Ausrüstung();
                this.todesserie = new Todesserie();
                this.spezialgranate = new Spezialgranate();
                this.primary_waffe = wf.getRandomPrimaryWeapon();
                this.secondary_waffe = wf.getRandomSecondaryWeapon();


                printloadout();
            }
        }
        public Perks Perks { get => perks; set => perks = value; }
    }
}
