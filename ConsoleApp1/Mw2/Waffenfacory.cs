using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{
    class Waffenfacory
    {
        private List<Waffe> primär_Waffen_Liste = new List<Waffe>();
        private List<Waffe> secondary_Waffen_Liste = new List<Waffe>();

        public List<Waffe> Secondary_Waffen_Liste { get => secondary_Waffen_Liste; set => secondary_Waffen_Liste = value; }
        public List<Waffe> Primär_Waffen_Liste { get => primär_Waffen_Liste; set => primär_Waffen_Liste = value; }

        public Waffenfacory()
        {
            // Sturmgewehre
            Sturmgewehre m4a1 = new Sturmgewehre("M4A1", new[] { "Granatenwerfer", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Schrotflinte", "Holographisches Visier", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });
            Sturmgewehre famas = new Sturmgewehre("Famas", new[] { "Granatenwerfer", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Schrotflinte", "Holographisches Visier", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });
            Sturmgewehre scar = new Sturmgewehre("Scar-H", new[] { "Granatenwerfer", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Schrotflinte", "Holographisches Visier", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });
            Sturmgewehre tar = new Sturmgewehre("TAR-21", new[] { "Granatenwerfer", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Schrotflinte", "Holographisches Visier", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });
            Sturmgewehre fal = new Sturmgewehre("FAL", new[] { "Granatenwerfer", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Schrotflinte", "Holographisches Visier", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });
            Sturmgewehre m16a4 = new Sturmgewehre("M16A4", new[] { "Granatenwerfer", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Schrotflinte", "Holographisches Visier", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });
            Sturmgewehre acr = new Sturmgewehre("ACR", new[] { "Granatenwerfer", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Schrotflinte", "Holographisches Visier", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });
            Sturmgewehre f2000 = new Sturmgewehre("F2000", new[] { "Granatenwerfer", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Schrotflinte", "Holographisches Visier", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });
            Sturmgewehre ak47 = new Sturmgewehre("AK47", new[] { "Granatenwerfer", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Schrotflinte", "Holographisches Visier", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });
            Sturmgewehre ak47c = new Sturmgewehre("AK47-Classic", new[] { "Granatenwerfer", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Erweiterte Magazine" });

            // Primäre Maschinenpistole
            Prim_Maschinenpistole mp5k = new Prim_Maschinenpistole("MP5K", new[] { "Schnellfeuer", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Akimbo", "Holographisches Visier", "Thermal", "Erweiterte Magazine" });
            Prim_Maschinenpistole ump45 = new Prim_Maschinenpistole("UMP45", new[] { "Schnellfeuer", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Akimbo", "Holographisches Visier", "Thermal", "Erweiterte Magazine" });
            Prim_Maschinenpistole vector = new Prim_Maschinenpistole("Vector", new[] { "Schnellfeuer", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Akimbo", "Holographisches Visier", "Thermal", "Erweiterte Magazine" });
            Prim_Maschinenpistole p90 = new Prim_Maschinenpistole("P90", new[] { "Schnellfeuer", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Akimbo", "Holographisches Visier", "Thermal", "Erweiterte Magazine" });
            Prim_Maschinenpistole miniuzi = new Prim_Maschinenpistole("Mini-Uzi", new[] { "Schnellfeuer", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Akimbo", "Holographisches Visier", "Thermal", "Erweiterte Magazine" });
            Prim_Maschinenpistole ak47u = new Prim_Maschinenpistole("AK47U", new[] { "ACOG-Zielfernrohr", "Erweiterte Magazine" });
            Prim_Maschinenpistole peacekeeper = new Prim_Maschinenpistole("Peacekeeper" );

            // Leichte MGS
            LeichteMgs l86LSW = new LeichteMgs("L86 LSW", new[] { "Griff", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Holographisches Visier", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });
            LeichteMgs rpd = new LeichteMgs("RPD", new[] { "Griff", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Holographisches Visier", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });
            LeichteMgs mg4 = new LeichteMgs("MG4", new[] { "Griff", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Holographisches Visier", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });
            LeichteMgs aug = new LeichteMgs("AUG HBAR", new[] { "Griff", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Holographisches Visier", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });
            LeichteMgs m240 = new LeichteMgs("L86 LSW", new[] { "Griff", "Rotpunktvisier", "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Holographisches Visier", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });

            // Scharfschützengewehr
            Scharfschützengewehr intervention = new Scharfschützengewehr("Intervention", new[] { "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });
            Scharfschützengewehr barrett = new Scharfschützengewehr("Barrett KAL. .50", new[] { "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });
            Scharfschützengewehr wa2000 = new Scharfschützengewehr("WA2000", new[] { "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });
            Scharfschützengewehr m21ebr = new Scharfschützengewehr("M21EBR", new[] { "Schalldämpfer", "ACOG-Zielfernrohr", "Vollmantelgeschoss", "Herzschlagsensor", "Thermal", "Erweiterte Magazine" });
            Scharfschützengewehr m40A3 = new Scharfschützengewehr("M40A3");
            Scharfschützengewehr dragunow = new Scharfschützengewehr("Dragunow");

            // Einsatzschild
            Einsatzschild schild = new Einsatzschild("Einsatzschild");

            this.primär_Waffen_Liste.Add(m4a1);
            this.primär_Waffen_Liste.Add(famas);
            this.primär_Waffen_Liste.Add(scar);
            this.primär_Waffen_Liste.Add(tar);
            this.primär_Waffen_Liste.Add(fal);
            this.primär_Waffen_Liste.Add(m16a4);
            this.primär_Waffen_Liste.Add(acr);
            this.primär_Waffen_Liste.Add(f2000);
            this.primär_Waffen_Liste.Add(ak47);
            this.primär_Waffen_Liste.Add(ak47c);
            this.primär_Waffen_Liste.Add(mp5k);
            this.primär_Waffen_Liste.Add(ump45);
            this.primär_Waffen_Liste.Add(vector);
            this.primär_Waffen_Liste.Add(p90);
            this.primär_Waffen_Liste.Add(miniuzi);
            this.primär_Waffen_Liste.Add(ak47u);
            this.primär_Waffen_Liste.Add(peacekeeper);
            this.primär_Waffen_Liste.Add(l86LSW);
            this.primär_Waffen_Liste.Add(rpd);
            this.primär_Waffen_Liste.Add(mg4);
            this.primär_Waffen_Liste.Add(aug);
            this.primär_Waffen_Liste.Add(m240);
            this.primär_Waffen_Liste.Add(intervention);
            this.primär_Waffen_Liste.Add(barrett);
            this.primär_Waffen_Liste.Add(wa2000);
            this.primär_Waffen_Liste.Add(m21ebr);
            this.primär_Waffen_Liste.Add(m40A3);
            this.primär_Waffen_Liste.Add(dragunow);
            this.primär_Waffen_Liste.Add(schild);







            //Sekundäre Maschinenpistolen
            Sec_Maschinenpistole pp2000 = new Sec_Maschinenpistole("PP2000", new[] { "Rotpunktvisier", "Schalldämpfer", "Vollmantelgeschoss", "Akimbo", "Holographisches Visier", "Erweiterte Magazine" });
            Sec_Maschinenpistole g18 = new Sec_Maschinenpistole("G18", new[] { "Rotpunktvisier", "Schalldämpfer", "Vollmantelgeschoss", "Akimbo", "Holographisches Visier", "Erweiterte Magazine" });
            Sec_Maschinenpistole m93Raffica = new Sec_Maschinenpistole("M93 Raffica", new[] { "Rotpunktvisier", "Schalldämpfer", "Vollmantelgeschoss", "Akimbo", "Holographisches Visier", "Erweiterte Magazine" });
            Sec_Maschinenpistole tmp = new Sec_Maschinenpistole("TMP",  new[] { "Rotpunktvisier", "Schalldämpfer", "Vollmantelgeschoss", "Akimbo", "Holographisches Visier", "Erweiterte Magazine" });

            // Handfeuerwaffe
            Handfeuerwaffe usp = new Handfeuerwaffe("USP .45", new[] { "Vollmantelgeschoss", "Schalldämpfer", "Akimbo", "Taktikmesser", "Erweiterte Magazine" });
            Handfeuerwaffe magnum = new Handfeuerwaffe(".44 Magnum", new[] { "Vollmantelgeschoss", "Akimbo", "Taktikmesser" });
            Handfeuerwaffe m9 = new Handfeuerwaffe("M9", new[] { "Vollmantelgeschoss", "Akimbo", "Taktikmesser" });
            Handfeuerwaffe desert = new Handfeuerwaffe("Desert Eagle", new[] { "Vollmantelgeschoss", "Akimbo", "Taktikmesser" });
            Handfeuerwaffe goldenDesert = new Handfeuerwaffe("Gold Desert Eagle", new[] { "Vollmantelgeschoss", "Akimbo", "Taktikmesser" });

            // Schrotflinten
            Schrotflinte spas = new Schrotflinte("SPAS-12", new[] { "Rotpunktvisier", "Schalldämpfer", "Griff", "Vollmantelgeschoss", "Holographisches Visier", "Erweiterte Magazine" });
            Schrotflinte aa12 = new Schrotflinte("AA-12", new[] { "Rotpunktvisier", "Schalldämpfer", "Griff", "Vollmantelgeschoss", "Holographisches Visier", "Erweiterte Magazine" });
            Schrotflinte striker = new Schrotflinte("Striker", new[] { "Rotpunktvisier", "Schalldämpfer", "Griff", "Vollmantelgeschoss", "Holographisches Visier", "Erweiterte Magazine" });
            Schrotflinte ranger = new Schrotflinte("Ranger", new[] { "Akimbo", "Vollmantelgeschoss" });
            Schrotflinte m1014 = new Schrotflinte("M1014", new[] { "Rotpunktvisier", "Schalldämpfer", "Griff", "Vollmantelgeschoss", "Holographisches Visier", "Erweiterte Magazine" });
            Schrotflinte modell1887 = new Schrotflinte("Modell 1887", new[] { "Akimbo", "Vollmantelgeschoss" });

            // Werfer
            Werfer at4 = new Werfer("AT4-Wärmelenk");
            Werfer thum = new Werfer("Thumper x2");
            Werfer sting = new Werfer("Stinger");
            Werfer jav = new Werfer("Javelin");
            Werfer rak = new Werfer("Raketenwerfer");

            // Add Weapons to List
            this.secondary_Waffen_Liste.Add(pp2000);
            this.secondary_Waffen_Liste.Add(g18);
            this.secondary_Waffen_Liste.Add(m93Raffica);
            this.secondary_Waffen_Liste.Add(tmp);
            this.secondary_Waffen_Liste.Add(usp);
            this.secondary_Waffen_Liste.Add(magnum);
            this.secondary_Waffen_Liste.Add(m9);
            this.secondary_Waffen_Liste.Add(desert);
            this.secondary_Waffen_Liste.Add(goldenDesert);
            this.secondary_Waffen_Liste.Add(spas);
            this.secondary_Waffen_Liste.Add(aa12);
            this.secondary_Waffen_Liste.Add(striker);
            this.secondary_Waffen_Liste.Add(ranger);
            this.secondary_Waffen_Liste.Add(m1014);
            this.secondary_Waffen_Liste.Add(at4);
            this.secondary_Waffen_Liste.Add(thum);
            this.secondary_Waffen_Liste.Add(sting);
            this.secondary_Waffen_Liste.Add(jav);
            this.secondary_Waffen_Liste.Add(rak);
        }

        public Waffe Primary()
        {

            return new Waffe();
        }


        public Waffe getRandomPrimaryWeapon()
        {
            int size = this.primär_Waffen_Liste.Count;

            return primär_Waffen_Liste[StaticRandom.Instance.Next(0, size - 1)];

        }

        public Waffe getRandomSecondaryWeapon()
        {
            int size = this.secondary_Waffen_Liste.Count;


            return secondary_Waffen_Liste[StaticRandom.Instance.Next(0, size - 1)];

        }


    }
}
