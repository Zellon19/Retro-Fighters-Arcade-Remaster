using Retro_Fighters_Arcade.Properties;
using System.Windows.Forms.VisualStyles;

namespace Retro_Fighters_Arcade
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto te va a abrir el juego xd");
        }

        #region EmulatorToggleSearch area     
        private static bool[] toggledSearchButtons = [true, true, true, true];
        // in this order: ps1 - sega - nes - atari

        private void btnPsOneSearch_Click(object sender, EventArgs e)
        {
            if (toggledSearchButtons[0])
            {
                this.btnPsOneSearch.Enabled = false;
            }
            else
            {
                this.btnPsOneSearch.Enabled = true;
            }
            toggledSearchButtons[0] = !toggledSearchButtons[0];
        }

        private void btnSegaSearch_Click(object sender, EventArgs e)
        {
            toggledSearchButtons[1] = !toggledSearchButtons[1];
            if (toggledSearchButtons[1])
            {

            }
        }

        private void btnNesSearch_Click(object sender, EventArgs e)
        {
            toggledSearchButtons[2] = !toggledSearchButtons[2];
            if (toggledSearchButtons[2])
            {

            }
        }

        private void btnAtariSearch_Click(object sender, EventArgs e)
        {
            toggledSearchButtons[3] = !toggledSearchButtons[3];
            if (toggledSearchButtons[3])
            {
                
            }
        }  
        #endregion

    }
}
