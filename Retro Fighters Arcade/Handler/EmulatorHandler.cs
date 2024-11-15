using Retro_Fighters_Arcade.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retro_Fighters_Arcade.Handler
{
    internal class EmulatorHandler
    {
        // just has the paths to retroarch, every game and core
        #region Paths
        private readonly string _retroArchPath = "C:\\Users\\axela\\Desktop\\RetroArch-Win64\\retroarch.exe";

        private static readonly List<string> gamesAtari = new GameData().AtariPathList;
        private static readonly List<string> gamesSega = new GameData().SegaGenPathList;
        private static readonly List<string> gamesPsOne = new GameData().PsOnePathList;
        private static readonly List<string> gamesNes = new GameData().SnesPathList;

        private static readonly string pathCoreAtari = new GameData().AtariCorePath;
        private static readonly string pathCoreSega = new GameData().SegaGenesisCorePath;
        private static readonly string pathCorePsOne = new GameData().PsOneCorePath;
        private static readonly string pathCoreNes = new GameData().NesCorePath;
        #endregion

        private static readonly List<Game> _gameList = new Game().GameList();

        public void StartEmulator(Game pGame)
        {
            foreach (Game game in _gameList)
            {
                string ex = pGame.Console.ToLower();
                string gameName = pGame.Name.ToLower();

                // if game is from ps1 starts the corresponding game
                // crash - gt2 - pepsiman - mvc
                if (ex.Contains("playstation"))
                {
                    if (gameName.Contains("crash bandicoot"))
                    {
                        this.StartEmulator(pathCorePsOne, gamesPsOne[0]);
                        break;
                    }
                    if (gameName.Contains("gran turismo"))
                    {
                        this.StartEmulator(pathCorePsOne, gamesPsOne[1]);
                        break;
                    }
                    if (gameName.Contains("pepsiman"))
                    {
                        this.StartEmulator(pathCorePsOne, gamesPsOne[2]);
                        break;
                    }
                    if (gameName.Contains("marvel vs capcom"))
                    {
                        this.StartEmulator(pathCorePsOne, gamesPsOne[3]);
                        break;
                    }
                    continue;
                }
                
                // if game is from atari starts the corresponding game
                // asteroids - et - frogger - space invaders
                if (ex.Contains("atari"))
                {
                    if (gameName.Contains("asteroids"))
                    {
                        this.StartEmulator(pathCoreAtari, gamesAtari[0]);
                        break;
                    }
                    if (gameName.Contains("e.t."))
                    {
                        this.StartEmulator(pathCoreAtari, gamesAtari[1]);
                        break;
                    }
                    if (gameName.Contains("frogger"))
                    {
                        this.StartEmulator(pathCoreAtari, gamesAtari[2]);
                        break;
                    }
                    if (gameName.Contains("space invaders"))
                    {
                        this.StartEmulator(pathCoreAtari, gamesAtari[3]);
                        break;
                    }
                    continue;
                }

                // if game is from sega gen starts the corresponding game
                // shinobi iii, sonic the hedgehog, super street fighter ii
                if (ex.Contains("sega"))
                {
                    if (gameName.Contains("shinobi iii"))
                    {
                        this.StartEmulator(pathCoreSega , gamesSega[0]);
                        break;
                    }
                    if (gameName.Contains("sonic the hedgehog"))
                    {
                        this.StartEmulator(pathCoreSega, gamesSega[1]);
                        break;
                    }
                    if (gameName.Contains("super street fighter ii"))
                    {
                        this.StartEmulator(pathCoreSega, gamesSega[2]);
                        break;
                    }
                    continue;
                }

                // if game is from nes starts the corresponding game
                // dkong - excitebike - kirby - tetris - super mario bros
                if (ex.Contains("nes") && !ex.Contains("sega"))
                {
                    if (gameName.Contains("donkey kong classic"))
                    {
                        this.StartEmulator(pathCoreNes, gamesNes[0]);
                        break;
                    }
                    if (gameName.Contains("excitebike"))
                    {
                        this.StartEmulator(pathCoreNes, gamesNes[1]);
                        break;
                    }
                    if (gameName.Contains("kirby's adventure"))
                    {
                        this.StartEmulator(pathCoreNes, gamesNes[2]);
                        break;
                    }
                    if (gameName.Contains("tetris"))
                    {
                        this.StartEmulator(pathCoreNes, gamesNes[3]);
                        break;
                    }
                    if (gameName.Contains("super mario bros"))
                    {
                        this.StartEmulator(pathCoreNes, gamesNes[4]);
                        break;
                    }
                    continue;
                }
            }
        }
        
        private void StartEmulator(string corePath, string gamePath)
        {
            string arguments = $" --fullscreen -L \"{corePath}\" \"{gamePath}\"";
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = _retroArchPath,
                Arguments = arguments
            };

            try
            {
                Process.Start(startInfo);
            } catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
