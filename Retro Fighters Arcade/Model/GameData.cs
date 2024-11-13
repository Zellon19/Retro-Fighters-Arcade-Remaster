using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retro_Fighters_Arcade.Model
{
    internal class GameData
    {
        private readonly List<string> _atariPathList = 
            ["C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\atari\\asteroids.a26",
             "C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\atari\\et.a26",
             "C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\atari\\frogger.a26",
             "C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\atari\\riverRaid.a26",
             "C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\atari\\spaceInvaders.a26"];

        private readonly List<string> _nesPathList = 
            ["C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\nintendones\\dKongClassic.nes",
             "C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\nintendones\\exciteBike.nes",
             "C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\nintendones\\kirbysAdventure.nes",
             "C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\nintendones\\tetris.nes",
             "C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\nintendones\\vsSuperMarioBros.nes"];

        private readonly List<string> _psOnePathList =
            ["C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\playstations\\crashBandicoot.cue",
             "C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\playstations\\granTurismo2.cue",
             "C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\playstations\\pepsiman.cue",
             "C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\playstations\\tekken3.cue"];

        private readonly List<string> _segaGenPathList =
            ["C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\segagenesis\\doom32x.bin",
             "C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\segagenesis\\mortalCombat5.bin",
             "C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\segagenesis\\shinobi3.md",
             "C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\segagenesis\\sonic.md",
             "C:\\Users\\axela\\source\\repos\\Retro Fighters Arcade\\Retro Fighters Arcade\\Resources\\assets\\ROMs\\segagenesis\\superStreetFighter2.bin"];

        private readonly string _atariCorePath = "C:\\Users\\54264632\\Source\\Repos\\Zellon19\\Retro-Fighters-Arcade-Remaster\\Retro Fighters Arcade\\Resources\\assets\\cores\\stella_libretro_atari.dll";
        private readonly string _nesCorePath = "C:\\Users\\54264632\\Source\\Repos\\Zellon19\\Retro-Fighters-Arcade-Remaster\\Retro Fighters Arcade\\Resources\\assets\\cores\\snes9x2010_libretro.dll";
        private readonly string _psOneCorePath = "C:\\Users\\54264632\\Source\\Repos\\Zellon19\\Retro-Fighters-Arcade-Remaster\\Retro Fighters Arcade\\Resources\\assets\\cores";
        private readonly string _segaGenCorePath = "C:\\Users\\54264632\\Source\\Repos\\Zellon19\\Retro-Fighters-Arcade-Remaster\\Retro Fighters Arcade\\Resources\\assets\\cores\\fceumm_libretro_sega_genesis.dll";

        public string AtariCorePath { get { return _atariCorePath; } }
        public string NesCorePath { get { return _nesCorePath; } }
        public string PsOneCorePath { get { return _psOneCorePath; } }
        public string SegaGenesisCorePath { get { return _segaGenCorePath; } }


        public List<string> AtariPathList { get { return _atariPathList; } }
        public List<string> SnesPathList { get {return _nesPathList; } }
        public List<string> PsOnePathList { get { return _psOnePathList; } }
        public List<string> SegaGenPathList { get { return _segaGenPathList; } }
    }
}
