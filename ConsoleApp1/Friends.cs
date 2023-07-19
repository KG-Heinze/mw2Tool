using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Friends
    {
        private String Name = "";
        private int Hp;
        private int Attack;
        private int Speed;
        private int Crit = 5;


        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }
        public Friends()
        {
            
        }

        public void startgame()
        {
            try
            {
                //Crit

                // God
                Friends Chris = new Friends("Chris", 9999999, 999999, 9999);
                // 5 % instakill
                Friends Jan = new Friends("Jan", 8, -1, 3);
                // Doppelteam     Shroud Go BRRRRRRR
                Friends Domi = new Friends("Domi", 5, 3, 7);
                // Kotzen, Skateboard    Rucksack packen.
                Friends Rasmus = new Friends("Rasmus", 3, 6, 10);
                // Awakened Multistrike  
                Friends Philipp = new Friends("Philipp", 10, 2, 10);
                // Alle Fähigkeiten, Alles können, aber nicht MÜSSEN
                Friends Lukas = new Friends("Lukas", 12, 2, 10);
                // Sniffing  BIG NOSE 
                Friends Sören = new Friends("Sören", 3, 7, 8);
                // "Doch" Kann reanimiert werden
                Friends Ron = new Friends("Ron", 12, 2, 10);
                // Unsichtbar
                Friends Malena = new Friends("Malena", 30, 1, 17);
                // Auch große Nase 7 KÜMMELKNARRE
                Friends Aylin = new Friends("Aylin", 30, 1, 17);


                Friends[] Round1 = { Jan, Domi, Rasmus, Philipp, Lukas, Sören, Ron, Malena, Aylin };


                //Console.WriteLine("Selbst eingeben 1");
                //Console.ReadLine();

                BattleRoyale(Round1);

                Console.ReadKey();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
                throw;
            }
        }

        public Friends(String name, int Hp, int Attack, int Speed)
        {
            this.Name = name;
            this.Hp = Hp;
            this.Attack = Attack;
            this.Speed = Speed;
        }

        public void SayHello()
        {
            Console.WriteLine(this.Name + " is my name!+");
        }

        public void attack(Friends attacker, Friends bitch)
        {
            if (attacker.GetName() == "Jan")
            {
                if (RandomNumber(0,100) < 5)
                {
                    bitch.Hp = 0;
                }
            }
            else if (attacker.GetName() == "Malena") 
            {
                if (RandomNumber(0,100) < 10)
                {
                    Console.WriteLine("Malena hat sich unsichtbar gemacht und einen Schokoriegel gefunden! Sie wurde um 3 geheilt");
                    attacker.Hp = attacker.Hp + 3;
                }
            }
            else if (attacker.GetName() == "Sören")
            {
                    Console.WriteLine("Sörens Nase wird Größer, seine Crit Chance wird größer");
                    attacker.Crit = attacker.Crit + 10;
            }


            //crit
            if (RandomNumber(0,100) <= attacker.Crit)
            {
                Console.WriteLine("Holy Shit, ein Crit!");
                bitch.Hp = bitch.Hp - attacker.GetAttack() * 2;
            }
            else
            {
                bitch.Hp = bitch.Hp - attacker.GetAttack();
            }
        }

        static Friends DeclareWinner(Friends friend1, Friends friend2)
        {
            int friend1Hp = friend1.GetHp();
            int friend2Hp = friend2.GetHp();

            if (friend1Hp <= 0)
            {
                Console.WriteLine(friend2.GetName() + " WON ");
                return friend1;
            }
            else if (friend2Hp <= 0)
            {
                Console.WriteLine(friend1.GetName() + " WON ");
                return friend2;
            }

            return null;

        }

        public static void BattleRoyale(Friends[] fighters)
        {
            Random rnd = new Random();
            int random1 = rnd.Next(0, fighters.Length);
            int random2 = rnd.Next(0, fighters.Length);

            while (random1 == random2)
            {
                random2 = rnd.Next(0, fighters.Length);
            }

            int setup = 0;
            Boolean Speedcompare = false;

            while ((fighters[random1].GetHp() > 0) && (fighters[random2].GetHp() > 0))
            {
                if (setup == 0)
                {
                    Speedcompare = fighters[random1].GetSpeed() > fighters[random2].GetSpeed();
                    setup++;
                }

                if (Speedcompare)
                {
                    fighters[random1].attack(fighters[random1], fighters[random2]);
                    // check if crit

                    Console.WriteLine(fighters[random1].GetName() + " greift " + fighters[random2].GetName() + " für " + fighters[random1].GetAttack() + " an und macht " + fighters[random1].GetAttack() + " Schaden. " + fighters[random2].GetName() + " hat nun noch " + fighters[random2].GetHp() + " Leben");
                    Speedcompare = !Speedcompare;

                }
                else
                {
                    fighters[random2].attack(fighters[random2], fighters[random1]);
                    // check if crit

                    Console.WriteLine(fighters[random2].GetName() + " greift " + fighters[random1].GetName() + " für " + fighters[random2].GetAttack() + " an und macht " + fighters[random2].GetAttack() + " Schaden. " + fighters[random1].GetName() + " hat nun noch " + fighters[random1].GetHp() + " Leben");
                    Speedcompare = !Speedcompare;
                }
            }
            Friends Loser = DeclareWinner(fighters[random1], fighters[random2]);

            fighters = fighters.Where(val => val != Loser).ToArray();
            if (fighters.Length >= 1)
            {
                BattleRoyale(fighters);
            }
        }

            public int GetHp()
        {
            if (this.Hp < 0)
            {
                return 0;
            }
            return this.Hp;
        }

        public int GetSpeed()
        {
            return this.Speed;
        }

        public void SetHp(int Hp)
        {
            this.Hp = Hp;
        }

        public int GetAttack()
        {
            return this.Attack;
        }

        public String GetName()
        {
            return this.Name;
        }

        public void reduceLife()
        {
            
        }
    }
}
