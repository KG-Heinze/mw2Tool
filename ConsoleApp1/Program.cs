using ConsoleApp1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp1.Mw2;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    PrintMenu();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void PrintMenu()
        {
            
            Console.WriteLine("Mw2 Multitool");
            Console.WriteLine("1. Generate Random class");
            Console.WriteLine("2. Random Map");
            Console.WriteLine("3. Exit");

            String userInputRaw = Console.ReadLine();
            int userInput;

            if (!int.TryParse(userInputRaw, out userInput))
            {
                Console.WriteLine("Error: Please put in a number");
                return;
            }

            Console.WriteLine(" ");
            switch (userInput)
            {
                case 1:
                    Loadout loadout = new Loadout();
                    break;
                case 2:
                    Console.WriteLine(RandomMap());
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Error: Please put in a valid number");
                    break;

            }
            Console.WriteLine("--------------------------------------------------------------");
        }

        public static String RandomMap()
        {
            List<String> map_List = new List<string>();

            map_List.Add("Afghan");
            map_List.Add("Bailout");
            map_List.Add("Carnival");
            map_List.Add("Derail");
            map_List.Add("Estate");
            map_List.Add("Favela");
            map_List.Add("Fuel");
            map_List.Add("Highrise");
            map_List.Add("Invasion");
            map_List.Add("Karachi");
            map_List.Add("Overgrown");
            map_List.Add("Quarry");
            map_List.Add("Rundown");
            map_List.Add("Salvage");
            map_List.Add("Scrapyard");
            map_List.Add("Skidrow");
            map_List.Add("Storm");
            map_List.Add("Strike");
            map_List.Add("Sub Base");
            map_List.Add("Terminal");
            map_List.Add("Trailer Park");
            map_List.Add("Underpass");
            map_List.Add("Vacant ");

            int size = map_List.Count;

            return map_List[StaticRandom.Instance.Next(0, size - 1)];
        }
    }
}