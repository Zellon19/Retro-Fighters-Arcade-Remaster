namespace Retro_Fighters_Arcade
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            grpTopNavigator = new GroupBox();
            btnRefreshGames = new Button();
            btnSegaSearch = new Button();
            btnNesSearch = new Button();
            btnAtariSearch = new Button();
            btnPsOneSearch = new Button();
            lblSelectEmulator = new Label();
            lblGameSearch = new Label();
            txtSearchGame = new TextBox();
            btnSearchGame = new Button();
            grpArcade = new GroupBox();
            tlpGeneral = new ToolTip(components);
            grpTopNavigator.SuspendLayout();
            SuspendLayout();
            // 
            // grpTopNavigator
            // 
            grpTopNavigator.Controls.Add(btnRefreshGames);
            grpTopNavigator.Controls.Add(btnSegaSearch);
            grpTopNavigator.Controls.Add(btnNesSearch);
            grpTopNavigator.Controls.Add(btnAtariSearch);
            grpTopNavigator.Controls.Add(btnPsOneSearch);
            grpTopNavigator.Controls.Add(lblSelectEmulator);
            grpTopNavigator.Controls.Add(lblGameSearch);
            grpTopNavigator.Controls.Add(txtSearchGame);
            grpTopNavigator.Controls.Add(btnSearchGame);
            grpTopNavigator.Location = new Point(12, 12);
            grpTopNavigator.Name = "grpTopNavigator";
            grpTopNavigator.Size = new Size(1326, 100);
            grpTopNavigator.TabIndex = 0;
            grpTopNavigator.TabStop = false;
            grpTopNavigator.Text = "Navegador";
            // 
            // btnRefreshGames
            // 
            btnRefreshGames.Image = (Image)resources.GetObject("btnRefreshGames.Image");
            btnRefreshGames.Location = new Point(826, 35);
            btnRefreshGames.Name = "btnRefreshGames";
            btnRefreshGames.Size = new Size(44, 44);
            btnRefreshGames.TabIndex = 7;
            tlpGeneral.SetToolTip(btnRefreshGames, "Dale click aqui para refrescar\r\nla lista de juegos.");
            btnRefreshGames.UseVisualStyleBackColor = true;
            // 
            // btnSegaSearch
            // 
            btnSegaSearch.Image = (Image)resources.GetObject("btnSegaSearch.Image");
            btnSegaSearch.Location = new Point(161, 45);
            btnSegaSearch.Name = "btnSegaSearch";
            btnSegaSearch.Size = new Size(44, 44);
            btnSegaSearch.TabIndex = 6;
            tlpGeneral.SetToolTip(btnSegaSearch, "Click aqui para buscar juegos solo de SEGA Genesis");
            btnSegaSearch.UseVisualStyleBackColor = true;
            // 
            // btnNesSearch
            // 
            btnNesSearch.Image = (Image)resources.GetObject("btnNesSearch.Image");
            btnNesSearch.Location = new Point(243, 45);
            btnNesSearch.Name = "btnNesSearch";
            btnNesSearch.Size = new Size(44, 44);
            btnNesSearch.TabIndex = 5;
            tlpGeneral.SetToolTip(btnNesSearch, "Click aqui para buscar solo juegos de Nintendo NES");
            btnNesSearch.UseVisualStyleBackColor = true;
            // 
            // btnAtariSearch
            // 
            btnAtariSearch.Image = (Image)resources.GetObject("btnAtariSearch.Image");
            btnAtariSearch.Location = new Point(331, 45);
            btnAtariSearch.Name = "btnAtariSearch";
            btnAtariSearch.Size = new Size(44, 44);
            btnAtariSearch.TabIndex = 4;
            tlpGeneral.SetToolTip(btnAtariSearch, "Click aqui para buscar solo juegos de Atari 2000");
            btnAtariSearch.UseVisualStyleBackColor = true;
            // 
            // btnPsOneSearch
            // 
            btnPsOneSearch.Image = (Image)resources.GetObject("btnPsOneSearch.Image");
            btnPsOneSearch.Location = new Point(78, 45);
            btnPsOneSearch.Name = "btnPsOneSearch";
            btnPsOneSearch.Size = new Size(44, 44);
            btnPsOneSearch.TabIndex = 3;
            tlpGeneral.SetToolTip(btnPsOneSearch, "Click aqui para buscar juegos solo de PlayStation Uno");
            btnPsOneSearch.UseVisualStyleBackColor = true;
            // 
            // lblSelectEmulator
            // 
            lblSelectEmulator.AutoSize = true;
            lblSelectEmulator.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectEmulator.Location = new Point(78, 19);
            lblSelectEmulator.Name = "lblSelectEmulator";
            lblSelectEmulator.Size = new Size(167, 16);
            lblSelectEmulator.TabIndex = 2;
            lblSelectEmulator.Text = "Seleccionar Emulador";
            // 
            // lblGameSearch
            // 
            lblGameSearch.AutoSize = true;
            lblGameSearch.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGameSearch.Location = new Point(473, 16);
            lblGameSearch.Name = "lblGameSearch";
            lblGameSearch.Size = new Size(103, 16);
            lblGameSearch.TabIndex = 0;
            lblGameSearch.Text = "Buscar Juego";
            // 
            // txtSearchGame
            // 
            txtSearchGame.Location = new Point(473, 35);
            txtSearchGame.MaxLength = 50;
            txtSearchGame.Multiline = true;
            txtSearchGame.Name = "txtSearchGame";
            txtSearchGame.Size = new Size(297, 44);
            txtSearchGame.TabIndex = 0;
            txtSearchGame.TextAlign = HorizontalAlignment.Center;
            tlpGeneral.SetToolTip(txtSearchGame, "Escribe el nombre de un juego y presiona enter/el boton\r\nde la lupa para buscar.");
            // 
            // btnSearchGame
            // 
            btnSearchGame.Image = (Image)resources.GetObject("btnSearchGame.Image");
            btnSearchGame.Location = new Point(776, 35);
            btnSearchGame.Name = "btnSearchGame";
            btnSearchGame.Size = new Size(44, 44);
            btnSearchGame.TabIndex = 0;
            tlpGeneral.SetToolTip(btnSearchGame, "Dale click aqui para buscar el juego.");
            btnSearchGame.UseVisualStyleBackColor = true;
            // 
            // grpArcade
            // 
            grpArcade.Location = new Point(12, 107);
            grpArcade.Name = "grpArcade";
            grpArcade.Size = new Size(1326, 610);
            grpArcade.TabIndex = 1;
            grpArcade.TabStop = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1350, 729);
            Controls.Add(grpArcade);
            Controls.Add(grpTopNavigator);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainPage";
            Text = "Retro Fighters Arcade";
            grpTopNavigator.ResumeLayout(false);
            grpTopNavigator.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTopNavigator;
        private GroupBox grpArcade;
        private TextBox txtSearchGame;
        private Button btnSearchGame;
        private Label lblGameSearch;
        private Label lblSelectEmulator;
        private Button btnSegaSearch;
        private Button btnNesSearch;
        private Button btnAtariSearch;
        private Button btnPsOneSearch;
        private Button btnRefreshGames;
        private ToolTip tlpGeneral;
    }
}
