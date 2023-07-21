using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mw2
{
    public class Perks
    {
        private String perk1 = "";
        private String perk2 = "";
        private String perk3 = "";

        private List<String> perk1_list = new List<String>();
        private List<String> perk2_list = new List<String>();
        private List<String> perk3_list = new List<String>();

        public Perks()
        {
            this.perk1_list.Add("Marathon Pro");
            this.perk1_list.Add("Fingerfertigkeit Pro");
            this.perk1_list.Add("Plünderer Pro");
            this.perk1_list.Add("Aufsatz Pro");
            this.perk1_list.Add("Ein-Mann-Armee Pro");

            this.perk2_list.Add("Feuerkraft Pro");
            this.perk2_list.Add("Leichtgewicht Pro");
            this.perk2_list.Add("Hardliner Pro");
            this.perk2_list.Add("Eiskalt Pro");
            this.perk2_list.Add("Direkte Gefahr Pro");

            this.perk3_list.Add("Kommando Pro");
            this.perk3_list.Add("Ruhige Hand Pro");
            this.perk3_list.Add("Störer Pro");
            this.perk3_list.Add("Ninja Pro");
            this.perk3_list.Add("Lagebericht Pro");
            this.perk3_list.Add("Eliminator Pro");
        }

        public void GetRandomPerks()
        {
            this.perk1 = perk1_list[StaticRandom.Instance.Next(0, this.perk1_list.Count())];
            this.perk2 = perk2_list[StaticRandom.Instance.Next(0, this.perk2_list.Count())];
            this.perk3 = perk3_list[StaticRandom.Instance.Next(0, this.perk3_list.Count())];
        }

        public void RemovePerk(String remove_perk)
        {
            if (perk1_list.Contains(remove_perk))
            {
                this.perk1_list.Remove(remove_perk);
            }
            else if (perk2_list.Contains(remove_perk))
            {
                this.perk2_list.Remove(remove_perk);
            }
            else if (perk3_list.Contains(remove_perk))
            {
                this.perk3_list.Remove(remove_perk);
            }
        }

        public string Perk1 { get => perk1; set => perk1 = value; }
        public string Perk2 { get => perk2; set => perk2 = value; }
        public string Perk3 { get => perk3; set => perk3 = value; }
    }
}
