using System;
using System.Threading;
using SteamBot.util;
using System.Collections.Generic;
using SteamKit2;

namespace SteamBot {
    public class Program {
		public static List<SteamID> bots = new List<SteamID>();
        public static void Main(string[] args) {
			Configuration config = Configuration.LoadConfiguration("settings.json");

			byte counter = 0;
            foreach (Configuration.BotInfo info in config.Bots) {
                Console.WriteLine("Launching bot " + counter++);
                new Thread(() =>
                {
                    int crashes = 0;
                    while (crashes < 1000)
                    {
                        try
                        {
							info.Admins = config.Admins;
                            new Bot(info, config.ApiKey);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            crashes++;
                        }
                    }
                }).Start();
                Thread.Sleep(5000);
            }
        }
    }
}
