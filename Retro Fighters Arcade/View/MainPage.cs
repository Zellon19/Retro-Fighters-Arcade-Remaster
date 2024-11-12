using System.Windows.Forms.VisualStyles;

namespace Retro_Fighters_Arcade
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            this.grpTopNavigator.
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
            toggledSearchButtons[0] = !toggledSearchButtons[0];
            this.UpdateDisplayedEmulators();
        }

        private void btnSegaSearch_Click(object sender, EventArgs e)
        {
            toggledSearchButtons[1] = !toggledSearchButtons[1];
            this.UpdateDisplayedEmulators();
        }

        private void btnNesSearch_Click(object sender, EventArgs e)
        {
            toggledSearchButtons[2] = !toggledSearchButtons[2];
            this.UpdateDisplayedEmulators();
        }

        private void btnAtariSearch_Click(object sender, EventArgs e)
        {
            toggledSearchButtons[3] = !toggledSearchButtons[3];
            this.UpdateDisplayedEmulators();
        }

        private void UpdateDisplayedEmulators()
        {
            for (int i = 0; i < toggledSearchButtons.Length; i++)
            {
                if (!toggledSearchButtons[i])
                {
                    // here we deactivate the games that belong to the emulator in that pos
                    // but since we broke asf we just show a dialogue lol
                    MessageBox.Show("Desactivado emulador: " + i);
                }
            }
        }

        #endregion

        private void grpArcade_Enter(object sender, EventArgs e)
        {

        }

        private void lblGameSearch_Click(object sender, EventArgs e)
        {

        }

        private void grpTopNavigator_Enter(object sender, EventArgs e)
        {

        }
    }
}
