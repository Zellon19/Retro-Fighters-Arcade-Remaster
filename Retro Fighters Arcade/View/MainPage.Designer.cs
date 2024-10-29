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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            btnPrevious = new Button();
            btnNext = new Button();
            btnStartCore = new Button();
            pcbMainCore = new PictureBox();
            pcbPrevCore = new PictureBox();
            pcbNextCore = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbMainCore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbPrevCore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbNextCore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(140, 668);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(188, 49);
            btnPrevious.TabIndex = 0;
            btnPrevious.Text = "<-";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(861, 668);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(188, 49);
            btnNext.TabIndex = 1;
            btnNext.Text = "->";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnStartCore
            // 
            btnStartCore.Location = new Point(470, 637);
            btnStartCore.Name = "btnStartCore";
            btnStartCore.Size = new Size(247, 110);
            btnStartCore.TabIndex = 2;
            btnStartCore.Text = "Iniciar Emulador";
            btnStartCore.UseVisualStyleBackColor = true;
            btnStartCore.Click += btnStartCore_Click;
            // 
            // pcbMainCore
            // 
            pcbMainCore.Location = new Point(449, 138);
            pcbMainCore.Name = "pcbMainCore";
            pcbMainCore.Size = new Size(289, 444);
            pcbMainCore.TabIndex = 3;
            pcbMainCore.TabStop = false;
            // 
            // pcbPrevCore
            // 
            pcbPrevCore.Location = new Point(69, 165);
            pcbPrevCore.Name = "pcbPrevCore";
            pcbPrevCore.Size = new Size(259, 395);
            pcbPrevCore.TabIndex = 4;
            pcbPrevCore.TabStop = false;
            // 
            // pcbNextCore
            // 
            pcbNextCore.Location = new Point(861, 165);
            pcbNextCore.Name = "pcbNextCore";
            pcbNextCore.Size = new Size(259, 395);
            pcbNextCore.TabIndex = 6;
            pcbNextCore.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-4, -2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1276, 770);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 767);
            Controls.Add(pcbNextCore);
            Controls.Add(pcbPrevCore);
            Controls.Add(pcbMainCore);
            Controls.Add(btnStartCore);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(pictureBox5);
            Name = "MainPage";
            Text = "Retro Fighters Arcade";
            ((System.ComponentModel.ISupportInitialize)pcbMainCore).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbPrevCore).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbNextCore).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrevious;
        private Button btnNext;
        private Button btnStartCore;
        private PictureBox pcbMainCore;
        private PictureBox pcbPrevCore;
        private PictureBox pcbNextCore;
        private PictureBox pictureBox5;
    }
}
