using Retro_Fighters_Arcade.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retro_Fighters_Arcade.Model
{
    internal class Emulator
    {
        private int _id;
        private string _name;
        private string _consoleDescription;
        private string _consoleYear;
        private string _consoleName;
        private string _emulatorPath;

        private static List<Emulator> _emulatorList = new List<Emulator>();

        public int Id
        {
            get => _id; set => _id = value;
        }
        public string Name
        {
            get => _name; set => _name = value;
        }
        public string ConsoleDescription
        {
            get => _consoleDescription; set => _consoleDescription = value;
        }
        public string ConsoleYear
        {
            get => _consoleYear; set => _consoleYear = value;
        }
        public string ConsoleName
        {
            get => _consoleName; set => _consoleName = value;
        }
        public string EmulatorPath
        {
            get => _emulatorPath; set => _emulatorPath = value;
        }

        // searches locally, for in-class-use
        private Emulator? SearchEmulator()
        {
            foreach (Emulator emu in _emulatorList)
                if (emu.Id.Equals(this.Id)) return emu;

            return null;
        }

        // search using whole object
        public Emulator? SearchEmulator(Emulator pEmulator)
        {
            foreach(Emulator emu in _emulatorList)
                if(emu.Id.Equals(pEmulator.Id)) return emu;

            return null;
        }

        public bool AddEmulator(Emulator pEmulator)
        {
            return new EmulatorController().AddEmulator(pEmulator);
        }
        public bool RemoveEmulator(Emulator pEmulator)
        {
            return new EmulatorController().RemoveEmulator(pEmulator);
        }
        public bool ModifyEmulator(Emulator pEmulator)
        {
            return new EmulatorController().ModifyEmulator(pEmulator);
        }

        public List<Emulator> GetEmulators() => _emulatorList;

        public Emulator(int pId, string pName, string pConsoleDescription, string pConsoleYear, string pConsoleName, string pEmulatorPath)
        {
            _id = pId;
            _name = pName;
            _consoleDescription = pConsoleDescription;
            _consoleYear = pConsoleYear;
            _consoleName = pConsoleName;
            _emulatorPath = pEmulatorPath;
        }

        public Emulator()
        {

        }


    }
}
