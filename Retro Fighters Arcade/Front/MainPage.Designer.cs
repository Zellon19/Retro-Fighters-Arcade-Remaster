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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            // 
            // btnNext
            // 
            btnNext.Location = new Point(861, 668);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(188, 49);
            btnNext.TabIndex = 1;
            btnNext.Text = "->";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnStartCore
            // 
            btnStartCore.Location = new Point(474, 637);
            btnStartCore.Name = "btnStartCore";
            btnStartCore.Size = new Size(247, 110);
            btnStartCore.TabIndex = 2;
            btnStartCore.Text = "Iniciar Emulador";
            btnStartCore.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(449, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 444);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(69, 165);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(259, 395);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(861, 165);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(259, 395);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
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
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnStartCore);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(pictureBox5);
            Name = "MainPage";
            Text = "Retro Fighters Arcade";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrevious;
        private Button btnNext;
        private Button btnStartCore;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
