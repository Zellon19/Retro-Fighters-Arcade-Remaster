using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
namespace Retro_Fighters_Arcade.Model
{
    internal class GameData
    {

        /*
         *  The whole class just has all of the current game names,
         *  ROM paths and the current cores' path
         * 
         */

        private readonly string[] _atariGames = 
            ["Asteroids",
             "ET",
             "Frogger", 
             "Space Invaders"];
        private readonly List<string> _atariPathList = 
            ["E:\\ROMs\\atari\\asteroids.a26",
             "E:\\ROMs\\atari\\et.a26",
             "E:\\ROMs\\atari\\frogger.a26",
             "E:\\ROMs\\atari\\spaceInvaders.a26"];

        private readonly string[] _nesGames = 
            ["Donkey Kong Classic", 
             "Excite Bike", 
             "Kirby's Adventure", 
             "Tetris", 
             "Vs. Super Mario Bros."];
        private readonly List<string> _nesPathList = 
            ["E:\\ROMs\\nintendones\\dKongClassic.nes",
             "E:\\ROMs\\nintendones\\exciteBike.nes",
             "E:\\ROMs\\nintendones\\kirbysAdventure.nes",
             "E:\\ROMs\\nintendones\\tetris.nes",
             "E:\\ROMs\\nintendones\\vsSuperMarioBros.nes"];

        private readonly string[] _psOneGames = 
            ["Crash Bandicoot",
             "Gran Turismo 2",
             "Pepsiman", 
             "Marvel VS Capcom"];
        private readonly List<string> _psOnePathList =
            ["E:\\ROMs\\playstations\\crashBandicoot.bin",
             "E:\\ROMs\\playstations\\granTurismo2.bin",
             "E:\\ROMs\\playstations\\pepsiman.bin",
             "E:\\ROMs\\playstations\\marvelVsCapcom.bin"];

        private readonly string[] _segaGenesisGames = 
            ["Shinobi III: Return of the Ninja Master", 
             "Sonic the Hedgehog", 
             "Super Street Fighter II"];
        private readonly List<string> _segaGenPathList =
            ["E:\\ROMs\\segagenesis\\shinobi3.md",
             "E:\\ROMs\\segagenesis\\sonic.md",
             "E:\\ROMs\\segagenesis\\superStreetFighter2.bin"];

        private readonly string _atariCorePath = "E:\\cores\\stella_libretro_atari.dll";
        private readonly string _nesCorePath = "E:\\cores\\fceumm_libretro.dll";
        private readonly string _psOneCorePath = "E:\\cores\\pcsx_rearmed_libretro.dll";
        private readonly string _segaGenCorePath = "E:\\cores\\blastem_libretro.dll";

        public string AtariCorePath { get { return _atariCorePath; } }
        public string NesCorePath { get { return _nesCorePath; } }
        public string PsOneCorePath { get { return _psOneCorePath; } }
        public string SegaGenesisCorePath { get { return _segaGenCorePath; } }

        public string[] AtariGames => _atariGames;
        public string[] NesGames => _nesGames;
        public string[] PsOneGames => _psOneGames;
        public string[] SegaGenesisGames => _segaGenesisGames;

        public List<string> AtariPathList { get { return _atariPathList; } }
        public List<string> SnesPathList { get {return _nesPathList; } }
        public List<string> PsOnePathList { get { return _psOnePathList; } }
        public List<string> SegaGenPathList { get { return _segaGenPathList; } }
    }
}
