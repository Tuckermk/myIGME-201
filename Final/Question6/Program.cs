using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Question6
{
    internal class Program
    {
        public class PlayerInfo
        {
            public string player_name;
            public int level;
            public int hp;
            public List<string> inventory;
            public string license;
        }
        public class SingletonClass
        {
            private static SingletonClass instance = new SingletonClass();
            private SingletonClass(){}
            public static SingletonClass GetInstance()
            {
                return instance;
            }
            public PlayerInfo LoadSaveFile(string filename)
            {
                PlayerInfo settings = null;
                if (File.Exists(filename))
                {
                    string json = File.ReadAllText(filename);
                    settings = JsonConvert.DeserializeObject<PlayerInfo>(json);
                }
                return settings;
            }
            public void SavetheSaveFile(PlayerInfo settings, string file)  
            {
                string json = JsonConvert.SerializeObject(settings);
                File.WriteAllText(file, json);
            }
        }
        static void Main(string[] args)
        {
            PlayerInfo playerInfo = new PlayerInfo();
            playerInfo.player_name = "dschuh";
            playerInfo.level = 4;
            playerInfo.hp = 99;
            playerInfo.inventory = new List<string> { "spear\",\"water bottle\",\"hammer\",\"sonic screwdriver\",\"cannonball\",\"wood\",\"Scooby snack\",\"Hydra\",\"poisonous potato\",\"dead bush\",\"repair powder" };
            playerInfo.license = "DFGU99-1454";
            SingletonClass singleton = SingletonClass.GetInstance();
            singleton.SavetheSaveFile(playerInfo, "playersettings.json");

            PlayerInfo playerSettings = singleton.LoadSaveFile("playersettings.json");
            if(playerSettings != null)
            {
                try
                {
                    Console.WriteLine("Player Name: " + playerSettings.player_name);
                    Console.WriteLine("Level: " + playerSettings.level);
                    Console.WriteLine("HP: " + playerSettings.hp);
                    Console.WriteLine("Inventory: " + String.Join(",", playerSettings.inventory));
                    Console.WriteLine("License Key:" + playerSettings.license);
                }
                catch
                {
                    Console.WriteLine("info missing");
                }
            }
            else
            {
                Console.WriteLine("No player info loaded");            }
        }
    }
}
