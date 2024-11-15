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
        private readonly string _retroArchPath = "C:\\RetroArch-Win64\\retroarch.exe";

        private static readonly List<string> gamesAtari = new GameData().AtariPathList;
        private static readonly List<string> gamesSega = new GameData().SegaGenPathList;
        private static readonly List<string> gamesPsOne = new GameData().PsOnePathList;
        private static readonly List<string> gamesNes = new GameData().SnesPathList;

        public string test = new GameData().PsOneCorePath;

        public void StartEmulator(Game pGame)
        {
            
        }
        
        private void StartEmulator(string corePath, string gamePath)
        {
            // temp
            gamePath = gamesPsOne[3];
            corePath = new GameData().PsOneCorePath;
            // end temp

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
