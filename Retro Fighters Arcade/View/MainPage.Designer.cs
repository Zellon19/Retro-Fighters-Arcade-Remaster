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
            btnPsOneSearchDisabled = new Button();
            btnSegaSearchDisabled = new Button();
            btnNesSearchDisabled = new Button();
            btnAtariSearchDisabled = new Button();
            pboStartGame = new PictureBox();
            panel1 = new Panel();
            lblGameSearch = new Label();
            lblSelectEmulator = new Label();
            panel2 = new Panel();
            pboSegaGenSuperStreetFighter2 = new PictureBox();
            pboSegaGenSonicTheHedgehog = new PictureBox();
            pboSegaGenShinobi3 = new PictureBox();
            pboSegaGenMortalKombat5 = new PictureBox();
            pboSegaGenDoom32 = new PictureBox();
            pboPsOneMarvelVsCapcom = new PictureBox();
            pboPsOnePepsiman = new PictureBox();
            pboPsOneGranTurismo2 = new PictureBox();
            pboPsOneCrashBandicoot = new PictureBox();
            pboNesVsSuperMarioBros = new PictureBox();
            pboNesTetris = new PictureBox();
            pboNesKirbysAdventure = new PictureBox();
            pboNesExciteBike = new PictureBox();
            pboNesDKongClassic = new PictureBox();
            pboAtariFrogger = new PictureBox();
            lblDebug = new Label();
            lblGameName = new Label();
            lblGameConsole = new Label();
            lblGameLaunch = new Label();
            lblGameDeveloper = new Label();
            lblGameDescription = new Label();
            lboGameList = new ListBox();
            pboAtariAsteroids = new PictureBox();
            pboAtariEt = new PictureBox();
            pboAtariSpaceInvaders = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboStartGame).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboSegaGenSuperStreetFighter2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboSegaGenSonicTheHedgehog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboSegaGenShinobi3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboSegaGenMortalKombat5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboSegaGenDoom32).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboPsOneMarvelVsCapcom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboPsOnePepsiman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboPsOneGranTurismo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboPsOneCrashBandicoot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboNesVsSuperMarioBros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboNesTetris).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboNesKirbysAdventure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboNesExciteBike).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboNesDKongClassic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboAtariFrogger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboAtariAsteroids).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboAtariEt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboAtariSpaceInvaders).BeginInit();
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
            txtSearchGame.TextChanged += txtSearchGame_TextChanged;
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
            // pboStartGame
            // 
            pboStartGame.BackgroundImage = (Image)resources.GetObject("pboStartGame.BackgroundImage");
            pboStartGame.Location = new Point(878, 353);
            pboStartGame.Name = "pboStartGame";
            pboStartGame.Size = new Size(200, 91);
            pboStartGame.TabIndex = 7;
            pboStartGame.TabStop = false;
            tlpGeneral.SetToolTip(pboStartGame, "Click aqui para iniciar el juego seleccionado.");
            pboStartGame.Click += pboStartGame_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
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
            lblGameSearch.BackColor = Color.WhiteSmoke;
            lblGameSearch.Font = new Font("ArcadeClassic", 15.7499981F);
            lblGameSearch.ForeColor = Color.Red;
            lblGameSearch.Location = new Point(473, 5);
            lblGameSearch.Name = "lblGameSearch";
            lblGameSearch.Size = new Size(305, 21);
            lblGameSearch.TabIndex = 0;
            lblGameSearch.Text = "Buscar Juego (No disponible)";
            // 
            // lblSelectEmulator
            // 
            lblSelectEmulator.AutoSize = true;
            lblSelectEmulator.BackColor = Color.WhiteSmoke;
            lblSelectEmulator.Font = new Font("ArcadeClassic", 15.7499981F);
            lblSelectEmulator.ForeColor = Color.Red;
            lblSelectEmulator.Location = new Point(24, 5);
            lblSelectEmulator.Name = "lblSelectEmulator";
            lblSelectEmulator.Size = new Size(401, 21);
            lblSelectEmulator.TabIndex = 2;
            lblSelectEmulator.Text = "Seleccionar Emulador (No disponible)";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pboSegaGenSuperStreetFighter2);
            panel2.Controls.Add(pboSegaGenSonicTheHedgehog);
            panel2.Controls.Add(pboSegaGenShinobi3);
            panel2.Controls.Add(pboSegaGenMortalKombat5);
            panel2.Controls.Add(pboSegaGenDoom32);
            panel2.Controls.Add(pboPsOneMarvelVsCapcom);
            panel2.Controls.Add(pboPsOnePepsiman);
            panel2.Controls.Add(pboPsOneGranTurismo2);
            panel2.Controls.Add(pboPsOneCrashBandicoot);
            panel2.Controls.Add(pboNesVsSuperMarioBros);
            panel2.Controls.Add(pboNesTetris);
            panel2.Controls.Add(pboNesKirbysAdventure);
            panel2.Controls.Add(pboNesExciteBike);
            panel2.Controls.Add(pboNesDKongClassic);
            panel2.Controls.Add(pboAtariFrogger);
            panel2.Controls.Add(lblDebug);
            panel2.Controls.Add(pboStartGame);
            panel2.Controls.Add(lblGameName);
            panel2.Controls.Add(lblGameConsole);
            panel2.Controls.Add(lblGameLaunch);
            panel2.Controls.Add(lblGameDeveloper);
            panel2.Controls.Add(lblGameDescription);
            panel2.Controls.Add(lboGameList);
            panel2.Controls.Add(pboAtariAsteroids);
            panel2.Controls.Add(pboAtariEt);
            panel2.Controls.Add(pboAtariSpaceInvaders);
            panel2.Location = new Point(12, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(1326, 610);
            panel2.TabIndex = 2;
            // 
            // pboSegaGenSuperStreetFighter2
            // 
            pboSegaGenSuperStreetFighter2.BackgroundImage = (Image)resources.GetObject("pboSegaGenSuperStreetFighter2.BackgroundImage");
            pboSegaGenSuperStreetFighter2.Location = new Point(459, 92);
            pboSegaGenSuperStreetFighter2.Name = "pboSegaGenSuperStreetFighter2";
            pboSegaGenSuperStreetFighter2.Size = new Size(219, 309);
            pboSegaGenSuperStreetFighter2.TabIndex = 25;
            pboSegaGenSuperStreetFighter2.TabStop = false;
            // 
            // pboSegaGenSonicTheHedgehog
            // 
            pboSegaGenSonicTheHedgehog.BackgroundImage = (Image)resources.GetObject("pboSegaGenSonicTheHedgehog.BackgroundImage");
            pboSegaGenSonicTheHedgehog.Location = new Point(459, 92);
            pboSegaGenSonicTheHedgehog.Name = "pboSegaGenSonicTheHedgehog";
            pboSegaGenSonicTheHedgehog.Size = new Size(219, 309);
            pboSegaGenSonicTheHedgehog.TabIndex = 24;
            pboSegaGenSonicTheHedgehog.TabStop = false;
            // 
            // pboSegaGenShinobi3
            // 
            pboSegaGenShinobi3.BackgroundImage = (Image)resources.GetObject("pboSegaGenShinobi3.BackgroundImage");
            pboSegaGenShinobi3.Location = new Point(458, 92);
            pboSegaGenShinobi3.Name = "pboSegaGenShinobi3";
            pboSegaGenShinobi3.Size = new Size(219, 309);
            pboSegaGenShinobi3.TabIndex = 23;
            pboSegaGenShinobi3.TabStop = false;
            // 
            // pboSegaGenMortalKombat5
            // 
            pboSegaGenMortalKombat5.BackgroundImage = (Image)resources.GetObject("pboSegaGenMortalKombat5.BackgroundImage");
            pboSegaGenMortalKombat5.Location = new Point(459, 92);
            pboSegaGenMortalKombat5.Name = "pboSegaGenMortalKombat5";
            pboSegaGenMortalKombat5.Size = new Size(219, 309);
            pboSegaGenMortalKombat5.TabIndex = 22;
            pboSegaGenMortalKombat5.TabStop = false;
            // 
            // pboSegaGenDoom32
            // 
            pboSegaGenDoom32.BackgroundImage = (Image)resources.GetObject("pboSegaGenDoom32.BackgroundImage");
            pboSegaGenDoom32.Location = new Point(458, 92);
            pboSegaGenDoom32.Name = "pboSegaGenDoom32";
            pboSegaGenDoom32.Size = new Size(219, 309);
            pboSegaGenDoom32.TabIndex = 21;
            pboSegaGenDoom32.TabStop = false;
            // 
            // pboPsOneMarvelVsCapcom
            // 
            pboPsOneMarvelVsCapcom.BackgroundImage = (Image)resources.GetObject("pboPsOneMarvelVsCapcom.BackgroundImage");
            pboPsOneMarvelVsCapcom.Location = new Point(458, 92);
            pboPsOneMarvelVsCapcom.Name = "pboPsOneMarvelVsCapcom";
            pboPsOneMarvelVsCapcom.Size = new Size(219, 309);
            pboPsOneMarvelVsCapcom.TabIndex = 20;
            pboPsOneMarvelVsCapcom.TabStop = false;
            // 
            // pboPsOnePepsiman
            // 
            pboPsOnePepsiman.BackgroundImage = (Image)resources.GetObject("pboPsOnePepsiman.BackgroundImage");
            pboPsOnePepsiman.Location = new Point(459, 92);
            pboPsOnePepsiman.Name = "pboPsOnePepsiman";
            pboPsOnePepsiman.Size = new Size(219, 309);
            pboPsOnePepsiman.TabIndex = 19;
            pboPsOnePepsiman.TabStop = false;
            // 
            // pboPsOneGranTurismo2
            // 
            pboPsOneGranTurismo2.BackgroundImage = (Image)resources.GetObject("pboPsOneGranTurismo2.BackgroundImage");
            pboPsOneGranTurismo2.Location = new Point(458, 92);
            pboPsOneGranTurismo2.Name = "pboPsOneGranTurismo2";
            pboPsOneGranTurismo2.Size = new Size(219, 309);
            pboPsOneGranTurismo2.TabIndex = 18;
            pboPsOneGranTurismo2.TabStop = false;
            // 
            // pboPsOneCrashBandicoot
            // 
            pboPsOneCrashBandicoot.BackgroundImage = (Image)resources.GetObject("pboPsOneCrashBandicoot.BackgroundImage");
            pboPsOneCrashBandicoot.Location = new Point(458, 92);
            pboPsOneCrashBandicoot.Name = "pboPsOneCrashBandicoot";
            pboPsOneCrashBandicoot.Size = new Size(219, 309);
            pboPsOneCrashBandicoot.TabIndex = 17;
            pboPsOneCrashBandicoot.TabStop = false;
            // 
            // pboNesVsSuperMarioBros
            // 
            pboNesVsSuperMarioBros.BackgroundImage = (Image)resources.GetObject("pboNesVsSuperMarioBros.BackgroundImage");
            pboNesVsSuperMarioBros.Location = new Point(458, 92);
            pboNesVsSuperMarioBros.Name = "pboNesVsSuperMarioBros";
            pboNesVsSuperMarioBros.Size = new Size(219, 309);
            pboNesVsSuperMarioBros.TabIndex = 16;
            pboNesVsSuperMarioBros.TabStop = false;
            // 
            // pboNesTetris
            // 
            pboNesTetris.BackgroundImage = (Image)resources.GetObject("pboNesTetris.BackgroundImage");
            pboNesTetris.Location = new Point(459, 92);
            pboNesTetris.Name = "pboNesTetris";
            pboNesTetris.Size = new Size(219, 309);
            pboNesTetris.TabIndex = 15;
            pboNesTetris.TabStop = false;
            // 
            // pboNesKirbysAdventure
            // 
            pboNesKirbysAdventure.BackgroundImage = (Image)resources.GetObject("pboNesKirbysAdventure.BackgroundImage");
            pboNesKirbysAdventure.Location = new Point(459, 92);
            pboNesKirbysAdventure.Name = "pboNesKirbysAdventure";
            pboNesKirbysAdventure.Size = new Size(219, 309);
            pboNesKirbysAdventure.TabIndex = 14;
            pboNesKirbysAdventure.TabStop = false;
            // 
            // pboNesExciteBike
            // 
            pboNesExciteBike.BackgroundImage = (Image)resources.GetObject("pboNesExciteBike.BackgroundImage");
            pboNesExciteBike.Location = new Point(458, 92);
            pboNesExciteBike.Name = "pboNesExciteBike";
            pboNesExciteBike.Size = new Size(219, 309);
            pboNesExciteBike.TabIndex = 13;
            pboNesExciteBike.TabStop = false;
            // 
            // pboNesDKongClassic
            // 
            pboNesDKongClassic.BackgroundImage = (Image)resources.GetObject("pboNesDKongClassic.BackgroundImage");
            pboNesDKongClassic.Location = new Point(459, 92);
            pboNesDKongClassic.Name = "pboNesDKongClassic";
            pboNesDKongClassic.Size = new Size(219, 309);
            pboNesDKongClassic.TabIndex = 12;
            pboNesDKongClassic.TabStop = false;
            // 
            // pboAtariFrogger
            // 
            pboAtariFrogger.BackgroundImage = (Image)resources.GetObject("pboAtariFrogger.BackgroundImage");
            pboAtariFrogger.Location = new Point(459, 92);
            pboAtariFrogger.Name = "pboAtariFrogger";
            pboAtariFrogger.Size = new Size(219, 309);
            pboAtariFrogger.TabIndex = 11;
            pboAtariFrogger.TabStop = false;
            // 
            // lblDebug
            // 
            lblDebug.AutoSize = true;
            lblDebug.ForeColor = SystemColors.ControlLightLight;
            lblDebug.Location = new Point(643, 466);
            lblDebug.Name = "lblDebug";
            lblDebug.Size = new Size(0, 15);
            lblDebug.TabIndex = 8;
            // 
            // lblGameName
            // 
            lblGameName.AutoSize = true;
            lblGameName.Font = new Font("ArcadeClassic", 11.999999F);
            lblGameName.ForeColor = SystemColors.ControlLightLight;
            lblGameName.Location = new Point(459, 404);
            lblGameName.Name = "lblGameName";
            lblGameName.Size = new Size(187, 16);
            lblGameName.TabIndex = 6;
            lblGameName.Text = "Nombre:  Space Invaders";
            // 
            // lblGameConsole
            // 
            lblGameConsole.AutoSize = true;
            lblGameConsole.Font = new Font("ArcadeClassic", 11.999999F);
            lblGameConsole.ForeColor = SystemColors.ControlLightLight;
            lblGameConsole.Location = new Point(459, 428);
            lblGameConsole.Name = "lblGameConsole";
            lblGameConsole.Size = new Size(160, 16);
            lblGameConsole.TabIndex = 5;
            lblGameConsole.Text = "Consola:  Atari 2600";
            // 
            // lblGameLaunch
            // 
            lblGameLaunch.AutoSize = true;
            lblGameLaunch.Font = new Font("ArcadeClassic", 11.999999F);
            lblGameLaunch.ForeColor = SystemColors.ControlLightLight;
            lblGameLaunch.Location = new Point(459, 454);
            lblGameLaunch.Name = "lblGameLaunch";
            lblGameLaunch.Size = new Size(147, 16);
            lblGameLaunch.TabIndex = 4;
            lblGameLaunch.Text = "Lanzamiento: 1978";
            // 
            // lblGameDeveloper
            // 
            lblGameDeveloper.AutoSize = true;
            lblGameDeveloper.Font = new Font("ArcadeClassic", 11.999999F);
            lblGameDeveloper.ForeColor = SystemColors.ControlLightLight;
            lblGameDeveloper.Location = new Point(459, 483);
            lblGameDeveloper.Name = "lblGameDeveloper";
            lblGameDeveloper.Size = new Size(295, 16);
            lblGameDeveloper.TabIndex = 3;
            lblGameDeveloper.Text = "Desarrollador:  Toshihiro Nishikado";
            // 
            // lblGameDescription
            // 
            lblGameDescription.AutoSize = true;
            lblGameDescription.Font = new Font("ArcadeClassic", 11.999999F);
            lblGameDescription.ForeColor = SystemColors.ControlLightLight;
            lblGameDescription.Location = new Point(693, 116);
            lblGameDescription.MaximumSize = new Size(400, 0);
            lblGameDescription.Name = "lblGameDescription";
            lblGameDescription.Size = new Size(390, 128);
            lblGameDescription.TabIndex = 2;
            lblGameDescription.Text = resources.GetString("lblGameDescription.Text");
            // 
            // lboGameList
            // 
            lboGameList.BackColor = SystemColors.MenuText;
            lboGameList.Font = new Font("ArcadeClassic", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lboGameList.ForeColor = SystemColors.Window;
            lboGameList.FormattingEnabled = true;
            lboGameList.ItemHeight = 18;
            lboGameList.Location = new Point(24, 92);
            lboGameList.Name = "lboGameList";
            lboGameList.Size = new Size(353, 472);
            lboGameList.TabIndex = 0;
            lboGameList.SelectedIndexChanged += lboGameList_SelectedIndexChanged;
            // 
            // pboAtariAsteroids
            // 
            pboAtariAsteroids.BackgroundImage = (Image)resources.GetObject("pboAtariAsteroids.BackgroundImage");
            pboAtariAsteroids.Location = new Point(458, 92);
            pboAtariAsteroids.Name = "pboAtariAsteroids";
            pboAtariAsteroids.Size = new Size(219, 309);
            pboAtariAsteroids.TabIndex = 9;
            pboAtariAsteroids.TabStop = false;
            // 
            // pboAtariEt
            // 
            pboAtariEt.BackgroundImage = (Image)resources.GetObject("pboAtariEt.BackgroundImage");
            pboAtariEt.Location = new Point(458, 92);
            pboAtariEt.Name = "pboAtariEt";
            pboAtariEt.Size = new Size(219, 309);
            pboAtariEt.TabIndex = 10;
            pboAtariEt.TabStop = false;
            // 
            // pboAtariSpaceInvaders
            // 
            pboAtariSpaceInvaders.BackgroundImage = Properties.Resources.atariSpaceInvadersLogo;
            pboAtariSpaceInvaders.Location = new Point(458, 92);
            pboAtariSpaceInvaders.Name = "pboAtariSpaceInvaders";
            pboAtariSpaceInvaders.Size = new Size(219, 309);
            pboAtariSpaceInvaders.TabIndex = 1;
            pboAtariSpaceInvaders.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pboStartGame).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboSegaGenSuperStreetFighter2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboSegaGenSonicTheHedgehog).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboSegaGenShinobi3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboSegaGenMortalKombat5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboSegaGenDoom32).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboPsOneMarvelVsCapcom).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboPsOnePepsiman).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboPsOneGranTurismo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboPsOneCrashBandicoot).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboNesVsSuperMarioBros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboNesTetris).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboNesKirbysAdventure).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboNesExciteBike).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboNesDKongClassic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboAtariFrogger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboAtariAsteroids).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboAtariEt).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboAtariSpaceInvaders).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ToolTip tlpGeneral;
        private Panel panel1;
        private Button btnSegaSearch;
        private Button btnNesSearch;
        private TextBox txtSearchGame;
        private Button btnAtariSearch;
        private Label lblGameSearch;
        private Label lblSelectEmulator;
        private Button btnSearchGame;
        private Button btnPsOneSearch;
        private Panel panel2;
        private Button btnPsOneSearchDisabled;
        private Button btnSegaSearchDisabled;
        private Button btnNesSearchDisabled;
        private Button btnAtariSearchDisabled;
        private ListBox lboGameList;
        private Label lblGameName;
        private Label lblGameConsole;
        private Label lblGameLaunch;
        private Label lblGameDeveloper;
        private PictureBox pboAtariSpaceInvaders;
        private PictureBox pboStartGame;
        private Label lblDebug;
        private Label lblGameDescription;
        private PictureBox pboAtariAsteroids;
        private PictureBox pboAtariEt;
        private PictureBox pboAtariFrogger;
        private PictureBox pboNesDKongClassic;
        private PictureBox pboNesExciteBike;
        private PictureBox pboNesKirbysAdventure;
        private PictureBox pboNesTetris;
        private PictureBox pboNesVsSuperMarioBros;
        private PictureBox pboPsOneCrashBandicoot;
        private PictureBox pboPsOneGranTurismo2;
        private PictureBox pboPsOnePepsiman;
        private PictureBox pboPsOneMarvelVsCapcom;
        private PictureBox pboSegaGenSonicTheHedgehog;
        private PictureBox pboSegaGenShinobi3;
        private PictureBox pboSegaGenMortalKombat5;
        private PictureBox pboSegaGenDoom32;
        private PictureBox pboSegaGenSuperStreetFighter2;
    }
}
