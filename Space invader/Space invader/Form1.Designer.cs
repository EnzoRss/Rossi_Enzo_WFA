namespace Space_invader
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radioBtnModel2 = new System.Windows.Forms.RadioButton();
            this.radioBtnModel1 = new System.Windows.Forms.RadioButton();
            this.radioBtnModel3 = new System.Windows.Forms.RadioButton();
            this.radioBtnModel4 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnRed = new System.Windows.Forms.RadioButton();
            this.radioBtnGreen = new System.Windows.Forms.RadioButton();
            this.radioBtnOrange = new System.Windows.Forms.RadioButton();
            this.radioBtnBlue = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBtnModel2
            // 
            this.radioBtnModel2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBtnModel2.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnModel2.BackgroundImage = global::Space_invader.Properties.Resources.background;
            this.radioBtnModel2.Checked = true;
            this.radioBtnModel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioBtnModel2.ForeColor = System.Drawing.Color.Transparent;
            this.radioBtnModel2.Image = global::Space_invader.Properties.Resources.playerShip2_blue;
            this.radioBtnModel2.Location = new System.Drawing.Point(460, 297);
            this.radioBtnModel2.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnModel2.Name = "radioBtnModel2";
            this.radioBtnModel2.Size = new System.Drawing.Size(182, 104);
            this.radioBtnModel2.TabIndex = 6;
            this.radioBtnModel2.TabStop = true;
            this.radioBtnModel2.UseVisualStyleBackColor = false;
            this.radioBtnModel2.CheckedChanged += new System.EventHandler(this.radioBtnModel2_CheckedChanged);
            // 
            // radioBtnModel1
            // 
            this.radioBtnModel1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBtnModel1.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnModel1.BackgroundImage = global::Space_invader.Properties.Resources.background;
            this.radioBtnModel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioBtnModel1.ForeColor = System.Drawing.Color.Transparent;
            this.radioBtnModel1.Image = global::Space_invader.Properties.Resources.playerShip1_blue;
            this.radioBtnModel1.Location = new System.Drawing.Point(1227, 297);
            this.radioBtnModel1.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnModel1.Name = "radioBtnModel1";
            this.radioBtnModel1.Size = new System.Drawing.Size(177, 104);
            this.radioBtnModel1.TabIndex = 7;
            this.radioBtnModel1.UseVisualStyleBackColor = false;
            this.radioBtnModel1.CheckedChanged += new System.EventHandler(this.radioBtnModel1_CheckedChanged);
            // 
            // radioBtnModel3
            // 
            this.radioBtnModel3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBtnModel3.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnModel3.BackgroundImage = global::Space_invader.Properties.Resources.background;
            this.radioBtnModel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioBtnModel3.ForeColor = System.Drawing.Color.Black;
            this.radioBtnModel3.Image = global::Space_invader.Properties.Resources.playerShip3_blue;
            this.radioBtnModel3.Location = new System.Drawing.Point(833, 297);
            this.radioBtnModel3.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnModel3.Name = "radioBtnModel3";
            this.radioBtnModel3.Size = new System.Drawing.Size(182, 104);
            this.radioBtnModel3.TabIndex = 8;
            this.radioBtnModel3.UseVisualStyleBackColor = false;
            this.radioBtnModel3.CheckedChanged += new System.EventHandler(this.radioBtnModel3_CheckedChanged);
            // 
            // radioBtnModel4
            // 
            this.radioBtnModel4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBtnModel4.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnModel4.BackgroundImage = global::Space_invader.Properties.Resources.background;
            this.radioBtnModel4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioBtnModel4.ForeColor = System.Drawing.Color.Transparent;
            this.radioBtnModel4.Image = global::Space_invader.Properties.Resources.ufoBlue;
            this.radioBtnModel4.Location = new System.Drawing.Point(1636, 297);
            this.radioBtnModel4.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnModel4.Name = "radioBtnModel4";
            this.radioBtnModel4.Size = new System.Drawing.Size(182, 104);
            this.radioBtnModel4.TabIndex = 9;
            this.radioBtnModel4.UseVisualStyleBackColor = false;
            this.radioBtnModel4.CheckedChanged += new System.EventHandler(this.radioBtnModel4_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Space_invader.Properties.Resources.logo_space_invader;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(833, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Space_invader.Properties.Resources.background;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(1008, 905);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 80);
            this.button1.TabIndex = 11;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.radioBtnRed);
            this.panel1.Controls.Add(this.radioBtnGreen);
            this.panel1.Controls.Add(this.radioBtnOrange);
            this.panel1.Controls.Add(this.radioBtnBlue);
            this.panel1.Location = new System.Drawing.Point(438, 520);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1398, 131);
            this.panel1.TabIndex = 12;
            // 
            // radioBtnRed
            // 
            this.radioBtnRed.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBtnRed.AutoSize = true;
            this.radioBtnRed.BackColor = System.Drawing.Color.DarkRed;
            this.radioBtnRed.BackgroundImage = global::Space_invader.Properties.Resources.metal_frame_1_;
            this.radioBtnRed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radioBtnRed.FlatAppearance.BorderSize = 10;
            this.radioBtnRed.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.radioBtnRed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioBtnRed.Location = new System.Drawing.Point(1258, 23);
            this.radioBtnRed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBtnRed.MinimumSize = new System.Drawing.Size(88, 75);
            this.radioBtnRed.Name = "radioBtnRed";
            this.radioBtnRed.Size = new System.Drawing.Size(88, 75);
            this.radioBtnRed.TabIndex = 3;
            this.radioBtnRed.TabStop = true;
            this.radioBtnRed.UseVisualStyleBackColor = false;
            this.radioBtnRed.CheckedChanged += new System.EventHandler(this.radioBtnRed_CheckedChanged);
            // 
            // radioBtnGreen
            // 
            this.radioBtnGreen.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBtnGreen.AutoSize = true;
            this.radioBtnGreen.BackColor = System.Drawing.Color.Lime;
            this.radioBtnGreen.BackgroundImage = global::Space_invader.Properties.Resources.metal_frame_1_;
            this.radioBtnGreen.Location = new System.Drawing.Point(832, 23);
            this.radioBtnGreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBtnGreen.MinimumSize = new System.Drawing.Size(88, 75);
            this.radioBtnGreen.Name = "radioBtnGreen";
            this.radioBtnGreen.Size = new System.Drawing.Size(88, 75);
            this.radioBtnGreen.TabIndex = 2;
            this.radioBtnGreen.TabStop = true;
            this.radioBtnGreen.UseVisualStyleBackColor = false;
            this.radioBtnGreen.CheckedChanged += new System.EventHandler(this.radioBtnGreen_CheckedChanged);
            // 
            // radioBtnOrange
            // 
            this.radioBtnOrange.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBtnOrange.AutoSize = true;
            this.radioBtnOrange.BackColor = System.Drawing.Color.Orange;
            this.radioBtnOrange.BackgroundImage = global::Space_invader.Properties.Resources.metal_frame_1_;
            this.radioBtnOrange.Location = new System.Drawing.Point(448, 23);
            this.radioBtnOrange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBtnOrange.MinimumSize = new System.Drawing.Size(88, 75);
            this.radioBtnOrange.Name = "radioBtnOrange";
            this.radioBtnOrange.Size = new System.Drawing.Size(88, 75);
            this.radioBtnOrange.TabIndex = 1;
            this.radioBtnOrange.TabStop = true;
            this.radioBtnOrange.UseVisualStyleBackColor = false;
            this.radioBtnOrange.CheckedChanged += new System.EventHandler(this.radioBtnOrange_CheckedChanged);
            // 
            // radioBtnBlue
            // 
            this.radioBtnBlue.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBtnBlue.AutoSize = true;
            this.radioBtnBlue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.radioBtnBlue.BackgroundImage = global::Space_invader.Properties.Resources.metal_frame_1_;
            this.radioBtnBlue.Location = new System.Drawing.Point(41, 23);
            this.radioBtnBlue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBtnBlue.MinimumSize = new System.Drawing.Size(88, 75);
            this.radioBtnBlue.Name = "radioBtnBlue";
            this.radioBtnBlue.Size = new System.Drawing.Size(88, 75);
            this.radioBtnBlue.TabIndex = 0;
            this.radioBtnBlue.TabStop = true;
            this.radioBtnBlue.UseVisualStyleBackColor = false;
            this.radioBtnBlue.CheckedChanged += new System.EventHandler(this.radioBtnBlue_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Location = new System.Drawing.Point(438, 728);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1398, 131);
            this.panel2.TabIndex = 13;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.BackgroundImage = global::Space_invader.Properties.Resources.background;
            this.radioButton3.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(222, 40);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.radioButton3.Size = new System.Drawing.Size(97, 58);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Facile";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.BackgroundImage = global::Space_invader.Properties.Resources.background;
            this.radioButton1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(628, 40);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.radioButton1.Size = new System.Drawing.Size(109, 58);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dificile";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.BackgroundImage = global::Space_invader.Properties.Resources.background;
            this.radioButton2.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(1010, 40);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.radioButton2.Size = new System.Drawing.Size(143, 58);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Impossible";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Space_invader.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(2221, 1041);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioBtnModel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioBtnModel2);
            this.Controls.Add(this.radioBtnModel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioBtnModel3);
            this.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2237, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1226, 602);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "&";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton radioBtnModel2;
        private System.Windows.Forms.RadioButton radioBtnModel1;
        private System.Windows.Forms.RadioButton radioBtnModel3;
        private System.Windows.Forms.RadioButton radioBtnModel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtnBlue;
        private System.Windows.Forms.RadioButton radioBtnRed;
        private System.Windows.Forms.RadioButton radioBtnGreen;
        private System.Windows.Forms.RadioButton radioBtnOrange;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

