using Retro_Fighters_Arcade.Handler;
using Retro_Fighters_Arcade.Model;
using Retro_Fighters_Arcade.Properties;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;

namespace Retro_Fighters_Arcade
{
    public partial class MainPage : Form
    {

        private static List<Game> _gameList = new Game().GameList();
        private static Game _selectedGame = _gameList.First();

        private static List<Game> _tempGameList = _gameList;

        public MainPage()
        {
            InitializeComponent();
            LoadAllGamesOnList();
            this.ManageShownGame(_gameList[0].Name, _gameList[0]);
        }

        #region EmulatorToggleSearch area     
        private static bool[] toggledSearchButtons = [true, true, true, true];

        // this order -> ps1 - sega - nes - atari
        private void btnPsOneSearch_Click(object sender, EventArgs e) // desactiva la consola
        {
            this.btnPsOneSearch.Visible = false;
            this.btnPsOneSearchDisabled.Visible = true;
            this.btnPsOneSearchDisabled.Focus();
;
            toggledSearchButtons[0] = !toggledSearchButtons[0];
            this.lboGameList.Items.Clear();
            foreach (Game game in _tempGameList)
            {
                if (!game.Console.ToLower().Contains("playstation")) this.lboGameList.Items.Add(game.Name);
            }
            LoadAllGamesOnList();
        }

        private void btnPsOneSearchDisabled_Click(object sender, EventArgs e) // activa la consola
        {
            this.btnPsOneSearchDisabled.Visible = false;
            this.btnPsOneSearch.Visible = true;
            this.btnPsOneSearch.Focus();
 
            toggledSearchButtons[0] = !toggledSearchButtons[0];
            this.lboGameList.Items.Clear();
            foreach (Game game in _tempGameList)
            {
                if (game.Console.ToLower().Contains("playstation")) this.lboGameList.Items.Add(game.Name);
            }
            LoadAllGamesOnList();
        }

        private void btnSegaSearch_Click(object sender, EventArgs e) //desactiva la consola
        {
            this.btnSegaSearch.Visible = false;
            this.btnSegaSearchDisabled.Visible = true;
            this.btnSegaSearchDisabled.Focus();

            toggledSearchButtons[1] = !toggledSearchButtons[1];
            this.lboGameList.Items.Clear();
            foreach (Game game in _tempGameList)
            {
                if (!game.Console.ToLower().Contains("sega")) this.lboGameList.Items.Add(game.Name);
            }
            LoadAllGamesOnList();
        }

        private void btnSearchSegaDisabled_Click(object sender, EventArgs e) //activa la consola
        {
            this.btnSegaSearchDisabled.Visible = false;
            this.btnSegaSearch.Visible = true;
            this.btnSegaSearch.Focus();

            toggledSearchButtons[1] = !toggledSearchButtons[1];
            this.lboGameList.Items.Clear();
            foreach (Game game in _tempGameList)
            {
                if (game.Console.ToLower().Contains("sega")) this.lboGameList.Items.Add(game.Name);
            }
            LoadAllGamesOnList();
        }

        private void btnNesSearch_Click(object sender, EventArgs e) //desactiva la consola
        {
            this.btnNesSearch.Visible = false;
            this.btnNesSearchDisabled.Visible = true;
            this.btnNesSearchDisabled.Focus();

            toggledSearchButtons[2] = !toggledSearchButtons[2];
            this.lboGameList.Items.Clear();
            foreach (Game game in _tempGameList)
            {
                if (!game.Console.ToLower().Contains("nes")) this.lboGameList.Items.Add(game.Name);
            }
            LoadAllGamesOnList();
        }

        private void btnNesSearchDisabled_Click(object sender, EventArgs e) //activa la consola
        {
            this.btnNesSearch.Visible = true;
            this.btnNesSearchDisabled.Visible = false;
            this.btnNesSearch.Focus();

            toggledSearchButtons[2] = !toggledSearchButtons[2];
            this.lboGameList.Items.Clear();
            foreach (Game game in _tempGameList)
            {
                if (game.Console.ToLower().Contains("nes")) this.lboGameList.Items.Add(game.Name);
            }
            LoadAllGamesOnList();
        }

        private void btnAtariSearch_Click(object sender, EventArgs e) //desactiva la consola
        {
            this.btnAtariSearchDisabled.Visible = true;
            this.btnAtariSearch.Visible = false;
            this.btnAtariSearchDisabled.Focus();

            toggledSearchButtons[3] = !toggledSearchButtons[3];
            this.lboGameList.Items.Clear();
            foreach (Game game in _tempGameList)
            {
                if (!game.Console.ToLower().Contains("atari")) this.lboGameList.Items.Add(game.Name);
            }
            LoadAllGamesOnList();
        }

        private void btnAtariSearchDisabled_Click(object sender, EventArgs e) //activa la consola
        {
            this.btnAtariSearchDisabled.Visible = false;
            this.btnAtariSearchDisabled.Focus();
            this.btnAtariSearch.Visible = true;

            toggledSearchButtons[3] = !toggledSearchButtons[3];
            this.lboGameList.Items.Clear();
            foreach (Game game in _tempGameList)
            {
                if (game.Console.ToLower().Contains("atari")) this.lboGameList.Items.Add(game.Name);
            }
            LoadAllGamesOnList();
        }
        #endregion

        #region do not open
        private void txtSearchGame_TextChanged(object sender, EventArgs e)
        {

        }
        /*          switch (gameId)
                {
                    case 0:
                        this.pboPsOneGranTurismo2.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    case 1:
                        this.pboPsOnePepsiman.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    case 2:
                        this.pboPsOneCrashBandicoot.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    case 3:
                        this.pboPsOneMarvelVsCapcom.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    case 4:
                        this.pboAtariAsteroids.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    case 5:
                        this.pboAtariEt.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    case 6:
                        this.pboAtariFrogger.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    case 7:
                        this.pboAtariSpaceInvaders.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    case 8:
                        this.pboNesDKongClassic.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    case 9:
                        this.pboNesExciteBike.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    case 10:
                        this.pboNesKirbysAdventure.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    case 11:
                        this.pboNesTetris.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    case 12:
                        this.pboNesVsSuperMarioBros.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    case 13:
                        this.pboSegaGenDoom32.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    case 14:
                        this.pboSegaGenMortalKombat5.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    case 15:
                        this.pboSegaGenShinobi3.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    case 16:
                        this.pboSegaGenSuperStreetFighter2.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    case 17:
                        this.pboSegaGenSonicTheHedgehog.BringToFront();
                        this.lblGameName.Text = $"Nombre: {_gameList[gameId].Name}";
                        this.lblGameConsole.Text = $"Consola: {_gameList[gameId].Console}";
                        this.lblGameLaunch.Text = $"Lanzamiento: {_gameList[gameId].Year}";
                        this.lblGameDeveloper.Text = $"Desarrollador: {_gameList[gameId].Developer}";
                        this.lblGameDescription.Text = _gameList[gameId].Description;
                        break;
                    default:
                        break;
                } */
        #endregion

        // this order -> ps1 - sega - nes - atari
        private void LoadAllGamesOnList()
        {
            this.lboGameList.Items.Clear();
            if (_gameList == null) return;
            if (toggledSearchButtons.All(b => b == false))
            {
                foreach (Game game in _gameList)
                    this.lboGameList.Items.Add(game.Name);

                this.MakeActivatedButtonsVisible();
                return;
            }
            // this order -> ps1 - sega - nes - atari
            foreach (Game game in _gameList)
            {
                if (toggledSearchButtons[0] && game.Console.ToLower().Contains("playstation"))
                {
                    this.lboGameList.Items.Add(game.Name);
                    continue;
                }
                if (toggledSearchButtons[1] && game.Console.ToLower().Contains("sega"))
                {
                    this.lboGameList.Items.Add(game.Name);
                    continue;
                }
                if (toggledSearchButtons[2] && game.Console.ToLower().Contains("nes") && !game.Console.ToLower().Contains("sega"))
                {
                    this.lboGameList.Items.Add(game.Name);
                    continue;
                }
                if (toggledSearchButtons[3] && game.Console.ToLower().Contains("atari"))
                {
                    this.lboGameList.Items.Add(game.Name);
                    continue;
                }
            }
        }

        private void MakeActivatedButtonsVisible()
        {
            this.btnAtariSearch.Visible = true;
            this.btnAtariSearchDisabled.Visible = false;

            this.btnPsOneSearch.Visible = true;
            this.btnPsOneSearchDisabled.Visible = false;

            this.btnSegaSearch.Visible = true;
            this.btnSegaSearchDisabled.Visible = false;

            this.btnNesSearch.Visible = true;
            this.btnNesSearchDisabled.Visible = false;
        }

        private void lboGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedListGame = this.lboGameList.SelectedIndex;
            for (int i = 0; i < _gameList.Count; i++)
            {
                if (i == selectedListGame)
                {
                    _selectedGame = new Game().SearchGame(_gameList[i]);

                    this.ManageShownGame(this.lboGameList.SelectedItem.ToString(), _selectedGame);
                    break;
                }
            }
        }

        private void ManageShownGame(string pGame, Game pGameObj)
        {
            this.HideAllImages();

            // this order -> ps1 - sega - nes - atari

            // PS1
            if (toggledSearchButtons[0])
            {
                if (pGame.ToLower().Contains("gran turismo 2"))
                {
                    this.pboPsOneGranTurismo2.Visible = true;
                }
                if (pGame.ToLower().Contains("pepsiman"))
                {
                    this.pboPsOnePepsiman.Visible = true;
                }
                if (pGame.ToLower().Contains("crash bandicoot"))
                {
                    this.pboPsOneCrashBandicoot.Visible = true;
                }
                if (pGame.ToLower().Contains("marvel vs capcom"))
                {
                    this.pboPsOneMarvelVsCapcom.Visible = true;
                }
            }

            // Sega Genesis
            if (toggledSearchButtons[1])
            {
                if (pGame.ToLower().Contains("doom 32x"))
                {
                    this.pboSegaGenDoom32.Visible = true;
                }
                if (pGame.ToLower().Contains("mortal kombat"))
                {
                    this.pboSegaGenMortalKombat5.Visible = true;
                }
                if (pGame.ToLower().Contains("shinobi iii"))
                {
                    this.pboSegaGenShinobi3.Visible = true;
                }
                if (pGame.ToLower().Contains("super street fighter ii"))
                {
                    this.pboSegaGenSuperStreetFighter2.Visible = true;
                }
                if (pGame.ToLower().Contains("sonic the hedgehog"))
                {
                    this.pboSegaGenSonicTheHedgehog.Visible = true;
                }
            }

            // NES
            if (toggledSearchButtons[2])
            {
                if (pGame.ToLower().Contains("donkey kong classic"))
                {
                    this.pboNesDKongClassic.Visible = true;
                }
                if (pGame.ToLower().Contains("excite"))
                {
                    this.pboNesExciteBike.Visible = true;
                }
                if (pGame.ToLower().Contains("kirby's adventure"))
                {
                    this.pboNesKirbysAdventure.Visible = true;
                }
                if (pGame.ToLower().Contains("tetris"))
                {
                    this.pboNesTetris.Visible = true;
                }
                if (pGame.ToLower().Contains("super mario bros"))
                {
                    this.pboNesVsSuperMarioBros.Visible = true;
                }
            }

            // Atari
            if (toggledSearchButtons[3])
            {
                if (pGame.ToLower().Contains("asteroids"))
                {
                    this.pboAtariAsteroids.Visible = true;
                }
                if (pGame.ToLower().Contains("e.t."))
                {
                    this.pboAtariEt.Visible = true;
                }
                if (pGame.ToLower().Contains("frogger"))
                {
                    this.pboAtariFrogger.Visible = true;
                }
                if (pGame.ToLower().Contains("space invaders"))
                {
                    this.pboAtariSpaceInvaders.Visible = true;
                }
            }


            // Set labels for all cases
            this.lblGameName.Text = $"Nombre: {pGameObj.Name}";
            this.lblGameConsole.Text = $"Consola: {pGameObj.Console}";
            this.lblGameLaunch.Text = $"Lanzamiento: {pGameObj.Year}";
            this.lblGameDeveloper.Text = $"Desarrollador: {pGameObj.Developer}";
            this.lblGameDescription.Text = pGameObj.Description;

        }

        private void HideAllImages()
        {
            this.pboPsOneGranTurismo2.Visible = false;
            this.pboPsOnePepsiman.Visible = false;
            this.pboPsOneCrashBandicoot.Visible = false;
            this.pboPsOneMarvelVsCapcom.Visible = false;
            this.pboAtariAsteroids.Visible = false;
            this.pboAtariEt.Visible = false;
            this.pboAtariFrogger.Visible = false;
            this.pboAtariSpaceInvaders.Visible = false;
            this.pboNesDKongClassic.Visible = false;
            this.pboNesExciteBike.Visible = false;
            this.pboNesKirbysAdventure.Visible = false;
            this.pboNesTetris.Visible = false;
            this.pboNesVsSuperMarioBros.Visible = false;
            this.pboSegaGenDoom32.Visible = false;
            this.pboSegaGenMortalKombat5.Visible = false;
            this.pboSegaGenShinobi3.Visible = false;
            this.pboSegaGenSuperStreetFighter2.Visible = false;
            this.pboSegaGenSonicTheHedgehog.Visible = false;
        }

        private void pboStartGame_Click(object sender, EventArgs e)
        {
            EmulatorHandler emuHan = new EmulatorHandler();
            emuHan.StartEmulator(new Game());
            this.lblDebug.Text = emuHan.test;
        }
    }
}
