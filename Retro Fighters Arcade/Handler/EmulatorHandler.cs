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

        private readonly List<string> gamesSnes = new GameData().SnesPathList;
        public void StartEmulator(string corePath, string gamePath)
        {
            string arguments = $" -L \"{corePath}\" \"{gamePath}\"";

            // temp
            gamePath = gamesSnes[1];
            corePath = new GameData().SegaGenesisCorePath;
            // end temp

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
