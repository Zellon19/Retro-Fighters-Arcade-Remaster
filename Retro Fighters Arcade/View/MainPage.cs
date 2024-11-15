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

        #region Filter Toggles Area     
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

        private void txtSearchGame_TextChanged(object sender, EventArgs e)
        {

        }

        // this order -> ps1 - sega - nes - atari
        private void LoadAllGamesOnList()
        {
            this.lboGameList.Items.Clear();

            if (_gameList == null) return;

            // if all in the array false we make them true and show the activated buttons
            if (toggledSearchButtons.All(b => b == false))
            {
                toggledSearchButtons = [true, true, true, true];

                this.btnAtariSearchDisabled.Visible = false;
                this.btnAtariSearch.Visible = true;

                this.btnPsOneSearchDisabled.Visible = false;
                this.btnPsOneSearch.Visible = true;

                this.btnSegaSearchDisabled.Visible = false;
                this.btnSegaSearch.Visible = true;

                this.btnNesSearchDisabled.Visible = false;
                this.btnNesSearch.Visible = true;

                this.LoadAllGamesOnList();
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

        private void lboGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedListGame = this.lboGameList.SelectedIndex;
            string text = this.lboGameList.Text;
            for (int i = 0; i < _gameList.Count; i++)
            {
                if (text.Equals(_gameList[i].Name))
                {
                    _selectedGame = new Game().SearchGame(_gameList[i]);
                    this.ManageShownGame(this.lboGameList.SelectedItem.ToString(), _selectedGame);
                    break;
                }
            }
        }

        // handles showing the game cover and data based on the selected game
        private void ManageShownGame(string pGame, Game pGameObj)
        {
            this.HideAllImages();

            // this order -> ps1 - sega - nes - atari

            // PS1 if selected game is ps1 then selects the appropiate cover based on its name
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

            // Sega Genesis if selected game is sega gen then selects the appropiate cover based on its name
            if (toggledSearchButtons[1])
            {
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

            // NES if selected game is nes then selects the appropiate cover based on its name
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

            // Atari if selected game is atari then selects the appropiate cover based on its name
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

        // just runs the game lol
        private void pboStartGame_Click(object sender, EventArgs e)
        {
            EmulatorHandler emuHan = new EmulatorHandler();
            emuHan.StartEmulator(_selectedGame);
            this.txtSearchGame.Clear();
        }

        // looks up a game's name to display based on the text input
        private void btnSearchGame_Click(object sender, EventArgs e)
        {
            this.lboGameList.Items.Clear();
            string name = this.txtSearchGame.Text;
            toggledSearchButtons = [true, true, true, true];
            foreach (Game game in _gameList)
            {
                if (game.Name.ToLower().Contains(name))
                {
                    this.lboGameList.Items.Add(game.Name);
                }
            }
        }

        // clears the search game txt and resets the game list, adding all
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.lboGameList.Items.Clear();
            this.txtSearchGame.Clear();
            this.LoadAllGamesOnList();
        }
    }
}
