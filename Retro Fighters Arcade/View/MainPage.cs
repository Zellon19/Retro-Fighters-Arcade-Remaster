using Retro_Fighters_Arcade.Handler;
using Retro_Fighters_Arcade.Model;
using Retro_Fighters_Arcade.Properties;
using System.Windows.Forms.VisualStyles;

namespace Retro_Fighters_Arcade
{
    public partial class MainPage : Form
    {

        private List<Game> _gameList = new Game().GameList();

        public MainPage()
        {
            InitializeComponent();
        }

        #region EmulatorToggleSearch area     
        private static bool[] toggledSearchButtons = [true, true, true, true];
        // in this order: ps1 - sega - nes - atari

        private void btnPsOneSearch_Click(object sender, EventArgs e)
        {
            this.btnPsOneSearch.Enabled = false;
            this.btnPsOneSearchDisabled.Enabled = true;
            this.btnPsOneSearchDisabled.Focus();
            this.btnPsOneSearchDisabled.BringToFront();
            this.btnPsOneSearch.SendToBack();
            toggledSearchButtons[0] = !toggledSearchButtons[0];
        }

        private void btnPsOneSearchDisabled_Click(object sender, EventArgs e)
        {
            this.btnPsOneSearchDisabled.Enabled = false;
            this.btnPsOneSearch.Enabled = true;
            this.btnPsOneSearch.Focus();
            this.btnPsOneSearchDisabled.SendToBack();
            this.btnPsOneSearch.BringToFront();
            toggledSearchButtons[0] = !toggledSearchButtons[0];
        }

        private void btnSegaSearch_Click(object sender, EventArgs e)
        {
            this.btnSegaSearch.Enabled = false;
            this.btnSegaSearchDisabled.Enabled = true;
            this.btnSegaSearchDisabled.Focus();
            this.btnSegaSearchDisabled.BringToFront();
            this.btnSegaSearch.SendToBack();
            toggledSearchButtons[1] = !toggledSearchButtons[1];
        }

        private void btnSearchSegaDisabled_Click(object sender, EventArgs e)
        {
            this.btnSegaSearchDisabled.Enabled = false;
            this.btnSegaSearch.Enabled = true;
            this.btnSegaSearch.Focus();
            this.btnSegaSearchDisabled.SendToBack();
            this.btnSegaSearch.BringToFront();
            toggledSearchButtons[1] = !toggledSearchButtons[1];
        }

        private void btnNesSearch_Click(object sender, EventArgs e)
        {
            this.btnNesSearch.Enabled = false;
            this.btnNesSearchDisabled.Enabled = true;
            this.btnNesSearchDisabled.Focus();
            this.btnNesSearch.SendToBack();
            this.btnNesSearchDisabled.BringToFront();
            toggledSearchButtons[2] = !toggledSearchButtons[2];
        }

        private void btnNesSearchDisabled_Click(object sender, EventArgs e)
        {
            this.btnNesSearch.Enabled = true;
            this.btnNesSearchDisabled.Enabled = false;
            this.btnNesSearch.Focus();
            this.btnNesSearch.BringToFront();
            this.btnNesSearchDisabled.SendToBack();
            toggledSearchButtons[2] = !toggledSearchButtons[2];
        }

        private void btnAtariSearch_Click(object sender, EventArgs e)
        {
            this.btnAtariSearch.Enabled = false;
            this.btnAtariSearchDisabled.Enabled = true;
            this.btnAtariSearchDisabled.Focus();
            this.btnAtariSearch.BringToFront();
            this.btnAtariSearchDisabled.SendToBack();
            toggledSearchButtons[3] = !toggledSearchButtons[3];
        }

        private void btnAtariSearchDisabled_Click(object sender, EventArgs e)
        {
            this.btnAtariSearch.Enabled = true;
            this.btnAtariSearchDisabled.Enabled = false;
            this.btnAtariSearchDisabled.Focus();
            this.btnAtariSearch.BringToFront();
            this.btnAtariSearchDisabled.SendToBack();
            toggledSearchButtons[3] = !toggledSearchButtons[3];
        }
        #endregion

        private void txtSearchGame_TextChanged(object sender, EventArgs e)
        {

        }

        private void lboGameList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pboStartGame_Click(object sender, EventArgs e)
        {
            EmulatorHandler emuHan = new EmulatorHandler();
            emuHan.StartEmulator(new Game());
            this.lblDebug.Text = emuHan.test;
        }
    }
}
