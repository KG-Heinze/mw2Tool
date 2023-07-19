using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleApp1.Mw2;
using Discord;
using Discord.WebSocket;
using Newtonsoft.Json;
using Discord.Net;

namespace SoloLearn
{
    class Program
    {
        public static Task Main(string[] args) => new Program().MainAsync();
        private DiscordSocketClient _client;

        public async Task MainAsync()
        {
            try
            {
                _client = new DiscordSocketClient();

                _client.Log += Log;
                var token = "MTEzMTE0Njc1OTg3MjE4NDM3MQ.GOw-R-.imMUM7IU9zYUuuUTWYwjWW5Yo5jp2ibu2668v4";

                await _client.LoginAsync(TokenType.Bot, token);
                await _client.StartAsync();
                _client.SlashCommandExecuted += SlashCommandHandler;

                _client.Ready += Client_Ready;
                // Block this task until the program is closed.
                await Task.Delay(-1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
        }

        private async Task SlashCommandHandler(SocketSlashCommand command)
        {
            if (command.Data.Name == "random-loadout")
            {
                String output = "";
                Loadout loudout = new Loadout();

                if (loudout.Perks.Perk1 == "Aufsatz Pro")
                {
                    output += ("Primary: " + loudout.Primary_waffe.Name);
                    if (loudout.Primary_waffe.Aufsätze != null)
                    {
                        Aufsatz first_Aufsatz = loudout.Primary_waffe.getRandomAufsatz();
                        output += " | Aufsatz: " + first_Aufsatz.Name + " + " + loudout.Primary_waffe.getRandomAufsatz(first_Aufsatz).Name + "\n";
                    }

                    output += "Secondary: " + loudout.Secondary_waffe.Name;
                    if (loudout.Secondary_waffe.Aufsätze != null)
                    {
                        output += " | Aufsatz: " + loudout.Secondary_waffe.getRandomAufsatz().Name + "\n";
                    }
                    else
                    {
                        output += "\n";
                    }
                }
                else
                {
                    output += "Primary: " + loudout.Primary_waffe.Name;
                    if (loudout.Primary_waffe.Aufsätze != null)
                    {
                        output += " | Aufsatz: " + loudout.Primary_waffe.getRandomAufsatz().Name + "\n";
                    }

                    output += "Secondary: " + loudout.Secondary_waffe.Name;
                    if (loudout.Secondary_waffe.Aufsätze != null)
                    {
                        output += " | Aufsatz: " + loudout.Secondary_waffe.getRandomAufsatz().Name + "\n";
                    }
                    else
                    {
                        output += "\n";
                    }

                }

                output += "Perk1: " + loudout.Perks.Perk1 + "\n";

                output += "Perk2: " + loudout.Perks.Perk2 + "\n";

                output += "Perk3: " + loudout.Perks.Perk3 + "\n";

                output += "Ausrüstung: " + loudout.Ausrüstung.Name + "\n";

                output += "Spezialgranate: " + loudout.Spezialgranate.Name + "\n";

                output += "Todesserie: " + loudout.Todesserie.Name;

                await command.RespondAsync(output);

            }
            else if (command.Data.Name == "random-map")
            {

                await command.RespondAsync(RandomMap());
            }
            else
            {
                await command.RespondAsync($"{command.Data.Name} is not yet implemented");
            }

        }

        public async Task Client_Ready()
        {
            // Let's build a guild command! We're going to need a guild so lets just put that in a variable.
            var guild = _client.GetGuild(254587476503429120);
            // Next, lets create our slash command builder. This is like the embed builder but for slash commands.
            // Note: Names have to be all lowercase and match the regular expression ^[\w-]{3,32}$

            var random_map = new SlashCommandBuilder();
            random_map.WithName("random-map");
            random_map.WithDescription("Random Mw2 Map");

            var guildCommand = new SlashCommandBuilder();
            guildCommand.WithName("random-loadout");
            guildCommand.WithDescription("Random Mw2 Loadout!");

            try
            {
                // Now that we have our builder, we can call the CreateApplicationCommandAsync method to make our slash command.
                await guild.CreateApplicationCommandAsync(guildCommand.Build());
                await guild.CreateApplicationCommandAsync(random_map.Build());

            }
            catch (HttpException exception)
            {
                // If our command was invalid, we should catch an ApplicationCommandException. This exception contains the path of the error as well as the error message. You can serialize the Error field in the exception to get a visual of where your error is.
                var json = JsonConvert.SerializeObject(exception.Errors, Formatting.Indented);

                // You can send this error somewhere or just print it to the console, for this example we're just going to print it.
                Console.WriteLine(json);
            }
        }
        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

        public static void PrintMenu()
        {
            
            Console.WriteLine("Mw2 Multitool v.1.0");
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