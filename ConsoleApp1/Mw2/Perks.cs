using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{
    public class Perks
    {
        private String perk1;
        private String perk2;
        private String perk3;

        public Perks()
        {
            String[] perk1_list = { "Marathon Pro", "Fingerfertigkeit Pro", "Plünderer Pro", "Aufsatz Pro", "Ein-Mann-Armee Pro" };
            String[] perk2_list = { "Feuerkraft Pro", "Leichtgewicht Pro", "Hardliner Pro", 
                //"Eiskalt Pro",
                "Direkte Gefahr Pro" };
            String[] perk3_list = { 
                "Kommando Pro",
                "Ruhige Hand Pro",
                //"Störer Pro",
                //"Ninja Pro",
                "Lagebericht Pro",
                "Eliminator Pro" };

            this.perk1 = perk1_list[StaticRandom.Instance.Next(0, 4)];
            this.perk2 = perk2_list[StaticRandom.Instance.Next(0, 4)];
            this.perk3 = perk3_list[StaticRandom.Instance.Next(0, 4)];
        }

        public string Perk1 { get => perk1; set => perk1 = value; }
        public string Perk2 { get => perk2; set => perk2 = value; }
        public string Perk3 { get => perk3; set => perk3 = value; }
    }
}
