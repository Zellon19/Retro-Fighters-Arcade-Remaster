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
            tlpGeneral = new ToolTip(components);
            btnSearchGame = new Button();
            txtSearchGame = new TextBox();
            btnPsOneSearch = new Button();
            btnAtariSearch = new Button();
            btnNesSearch = new Button();
            btnSegaSearch = new Button();
            btnRefreshGames = new Button();
            btnPsOneSearchDisabled = new Button();
            btnSegaSearchDisabled = new Button();
            btnNesSearchDisabled = new Button();
            btnAtariSearchDisabled = new Button();
            panel1 = new Panel();
            lblGameSearch = new Label();
            lblSelectEmulator = new Label();
            pbxGame1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxGame1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearchGame
            // 
            btnSearchGame.Image = (Image)resources.GetObject("btnSearchGame.Image");
            btnSearchGame.Location = new Point(776, 33);
            btnSearchGame.Name = "btnSearchGame";
            btnSearchGame.Size = new Size(44, 44);
            btnSearchGame.TabIndex = 0;
            tlpGeneral.SetToolTip(btnSearchGame, "Dale click aqui para buscar el juego.");
            btnSearchGame.UseVisualStyleBackColor = true;
            // 
            // txtSearchGame
            // 
            txtSearchGame.Location = new Point(473, 33);
            txtSearchGame.MaxLength = 50;
            txtSearchGame.Multiline = true;
            txtSearchGame.Name = "txtSearchGame";
            txtSearchGame.Size = new Size(297, 44);
            txtSearchGame.TabIndex = 0;
            txtSearchGame.TextAlign = HorizontalAlignment.Center;
            tlpGeneral.SetToolTip(txtSearchGame, "Escribe el nombre de un juego y presiona enter/el boton\r\nde la lupa para buscar.");
            // 
            // btnPsOneSearch
            // 
            btnPsOneSearch.Cursor = Cursors.Hand;
            btnPsOneSearch.Image = (Image)resources.GetObject("btnPsOneSearch.Image");
            btnPsOneSearch.Location = new Point(36, 33);
            btnPsOneSearch.Name = "btnPsOneSearch";
            btnPsOneSearch.Size = new Size(44, 44);
            btnPsOneSearch.TabIndex = 3;
            tlpGeneral.SetToolTip(btnPsOneSearch, "Click aqui para filtrar juegos solo de PlayStation Uno");
            btnPsOneSearch.UseVisualStyleBackColor = true;
            btnPsOneSearch.Click += btnPsOneSearch_Click;
            // 
            // btnAtariSearch
            // 
            btnAtariSearch.Cursor = Cursors.Hand;
            btnAtariSearch.Image = (Image)resources.GetObject("btnAtariSearch.Image");
            btnAtariSearch.Location = new Point(289, 33);
            btnAtariSearch.Name = "btnAtariSearch";
            btnAtariSearch.Size = new Size(44, 44);
            btnAtariSearch.TabIndex = 4;
            tlpGeneral.SetToolTip(btnAtariSearch, "Click aqui para filtrar juegos de Atari 2000");
            btnAtariSearch.UseVisualStyleBackColor = true;
            btnAtariSearch.Click += btnAtariSearch_Click;
            // 
            // btnNesSearch
            // 
            btnNesSearch.Cursor = Cursors.Hand;
            btnNesSearch.Image = (Image)resources.GetObject("btnNesSearch.Image");
            btnNesSearch.Location = new Point(201, 33);
            btnNesSearch.Name = "btnNesSearch";
            btnNesSearch.Size = new Size(44, 44);
            btnNesSearch.TabIndex = 5;
            tlpGeneral.SetToolTip(btnNesSearch, "Click aqui para buscar filtrar juegos de Nintendo NES");
            btnNesSearch.UseVisualStyleBackColor = true;
            btnNesSearch.Click += btnNesSearch_Click;
            // 
            // btnSegaSearch
            // 
            btnSegaSearch.Cursor = Cursors.Hand;
            btnSegaSearch.Image = (Image)resources.GetObject("btnSegaSearch.Image");
            btnSegaSearch.Location = new Point(119, 33);
            btnSegaSearch.Name = "btnSegaSearch";
            btnSegaSearch.Size = new Size(44, 44);
            btnSegaSearch.TabIndex = 6;
            tlpGeneral.SetToolTip(btnSegaSearch, "Click aqui para filtrar juegos solo de SEGA Genesis");
            btnSegaSearch.UseVisualStyleBackColor = true;
            btnSegaSearch.Click += btnSegaSearch_Click;
            // 
            // btnRefreshGames
            // 
            btnRefreshGames.Image = (Image)resources.GetObject("btnRefreshGames.Image");
            btnRefreshGames.Location = new Point(826, 33);
            btnRefreshGames.Name = "btnRefreshGames";
            btnRefreshGames.Size = new Size(44, 44);
            btnRefreshGames.TabIndex = 7;
            tlpGeneral.SetToolTip(btnRefreshGames, "Dale click aqui para refrescar\r\nla lista de juegos.");
            btnRefreshGames.UseVisualStyleBackColor = true;
            // 
            // btnPsOneSearchDisabled
            // 
            btnPsOneSearchDisabled.Image = (Image)resources.GetObject("btnPsOneSearchDisabled.Image");
            btnPsOneSearchDisabled.Location = new Point(36, 33);
            btnPsOneSearchDisabled.Name = "btnPsOneSearchDisabled";
            btnPsOneSearchDisabled.Size = new Size(44, 44);
            btnPsOneSearchDisabled.TabIndex = 8;
            tlpGeneral.SetToolTip(btnPsOneSearchDisabled, "Click aqui para filtrar juegos solo de PlayStation Uno");
            btnPsOneSearchDisabled.UseVisualStyleBackColor = true;
            btnPsOneSearchDisabled.Click += btnPsOneSearchDisabled_Click;
            // 
            // btnSegaSearchDisabled
            // 
            btnSegaSearchDisabled.Image = (Image)resources.GetObject("btnSegaSearchDisabled.Image");
            btnSegaSearchDisabled.Location = new Point(119, 33);
            btnSegaSearchDisabled.Name = "btnSegaSearchDisabled";
            btnSegaSearchDisabled.Size = new Size(44, 44);
            btnSegaSearchDisabled.TabIndex = 9;
            tlpGeneral.SetToolTip(btnSegaSearchDisabled, "Click aqui para filtrar juegos solo de SEGA Genesis");
            btnSegaSearchDisabled.UseVisualStyleBackColor = true;
            btnSegaSearchDisabled.Click += btnSearchSegaDisabled_Click;
            // 
            // btnNesSearchDisabled
            // 
            btnNesSearchDisabled.Cursor = Cursors.Hand;
            btnNesSearchDisabled.Image = (Image)resources.GetObject("btnNesSearchDisabled.Image");
            btnNesSearchDisabled.Location = new Point(201, 33);
            btnNesSearchDisabled.Name = "btnNesSearchDisabled";
            btnNesSearchDisabled.Size = new Size(44, 44);
            btnNesSearchDisabled.TabIndex = 10;
            tlpGeneral.SetToolTip(btnNesSearchDisabled, "Click aqui para buscar filtrar juegos de Nintendo NES");
            btnNesSearchDisabled.UseVisualStyleBackColor = true;
            btnNesSearchDisabled.Click += btnNesSearchDisabled_Click;
            // 
            // btnAtariSearchDisabled
            // 
            btnAtariSearchDisabled.Cursor = Cursors.Hand;
            btnAtariSearchDisabled.Image = (Image)resources.GetObject("btnAtariSearchDisabled.Image");
            btnAtariSearchDisabled.Location = new Point(289, 33);
            btnAtariSearchDisabled.Name = "btnAtariSearchDisabled";
            btnAtariSearchDisabled.Size = new Size(44, 44);
            btnAtariSearchDisabled.TabIndex = 11;
            tlpGeneral.SetToolTip(btnAtariSearchDisabled, "Click aqui para filtrar juegos de Atari 2000");
            btnAtariSearchDisabled.UseVisualStyleBackColor = true;
            btnAtariSearchDisabled.Click += btnAtariSearchDisabled_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnRefreshGames);
            panel1.Controls.Add(txtSearchGame);
            panel1.Controls.Add(lblGameSearch);
            panel1.Controls.Add(lblSelectEmulator);
            panel1.Controls.Add(btnSearchGame);
            panel1.Controls.Add(btnPsOneSearch);
            panel1.Controls.Add(btnPsOneSearchDisabled);
            panel1.Controls.Add(btnSegaSearch);
            panel1.Controls.Add(btnSegaSearchDisabled);
            panel1.Controls.Add(btnNesSearch);
            panel1.Controls.Add(btnNesSearchDisabled);
            panel1.Controls.Add(btnAtariSearch);
            panel1.Controls.Add(btnAtariSearchDisabled);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1326, 89);
            panel1.TabIndex = 1;
            // 
            // lblGameSearch
            // 
            lblGameSearch.AutoSize = true;
            lblGameSearch.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGameSearch.ForeColor = Color.Red;
            lblGameSearch.Location = new Point(473, 5);
            lblGameSearch.Name = "lblGameSearch";
            lblGameSearch.Size = new Size(144, 25);
            lblGameSearch.TabIndex = 0;
            lblGameSearch.Text = "Buscar Juego";
            // 
            // lblSelectEmulator
            // 
            lblSelectEmulator.AutoSize = true;
            lblSelectEmulator.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectEmulator.ForeColor = Color.Red;
            lblSelectEmulator.Location = new Point(24, 5);
            lblSelectEmulator.Name = "lblSelectEmulator";
            lblSelectEmulator.Size = new Size(222, 25);
            lblSelectEmulator.TabIndex = 2;
            lblSelectEmulator.Text = "Seleccionar Emulador";
            // 
            // pbxGame1
            // 
            pbxGame1.Cursor = Cursors.Hand;
            pbxGame1.Image = Properties.Resources.atariSpaceInvadersLogo;
            pbxGame1.Location = new Point(24, 83);
            pbxGame1.Name = "pbxGame1";
            pbxGame1.Size = new Size(221, 304);
            pbxGame1.TabIndex = 0;
            pbxGame1.TabStop = false;
            pbxGame1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pbxGame1);
            panel2.Location = new Point(12, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(1326, 610);
            panel2.TabIndex = 2;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.WindowFrame;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1350, 729);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1278, 726);
            Name = "MainPage";
            Text = "Retro Fighters Arcade";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxGame1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ToolTip tlpGeneral;
        private Panel panel1;
        private Button btnSegaSearch;
        private Button btnRefreshGames;
        private Button btnNesSearch;
        private TextBox txtSearchGame;
        private Button btnAtariSearch;
        private Label lblGameSearch;
        private Label lblSelectEmulator;
        private Button btnSearchGame;
        private Button btnPsOneSearch;
        private PictureBox pbxGame1;
        private Panel panel2;
        private Button btnPsOneSearchDisabled;
        private Button btnSegaSearchDisabled;
        private Button btnNesSearchDisabled;
        private Button btnAtariSearchDisabled;
    }
}
