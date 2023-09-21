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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.radioBtnGreen = new System.Windows.Forms.RadioButton();
            this.radioBtnBlue = new System.Windows.Forms.RadioButton();
            this.radioBtnOrange = new System.Windows.Forms.RadioButton();
            this.radioBtnRed = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTImer);
            // 
            // radioBtnGreen
            // 
            this.radioBtnGreen.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBtnGreen.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnGreen.BackgroundImage = global::Space_invader.Properties.Resources.background;
            this.radioBtnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioBtnGreen.ForeColor = System.Drawing.Color.Transparent;
            this.radioBtnGreen.Image = global::Space_invader.Properties.Resources.playerShip1_green;
            this.radioBtnGreen.Location = new System.Drawing.Point(662, 508);
            this.radioBtnGreen.Name = "radioBtnGreen";
            this.radioBtnGreen.Size = new System.Drawing.Size(172, 113);
            this.radioBtnGreen.TabIndex = 6;
            this.radioBtnGreen.TabStop = true;
            this.radioBtnGreen.UseVisualStyleBackColor = false;
            this.radioBtnGreen.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioBtnBlue
            // 
            this.radioBtnBlue.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBtnBlue.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnBlue.BackgroundImage = global::Space_invader.Properties.Resources.background;
            this.radioBtnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioBtnBlue.ForeColor = System.Drawing.Color.Transparent;
            this.radioBtnBlue.Image = global::Space_invader.Properties.Resources.playerShip1_blue;
            this.radioBtnBlue.Location = new System.Drawing.Point(1013, 333);
            this.radioBtnBlue.Name = "radioBtnBlue";
            this.radioBtnBlue.Size = new System.Drawing.Size(172, 113);
            this.radioBtnBlue.TabIndex = 7;
            this.radioBtnBlue.TabStop = true;
            this.radioBtnBlue.UseVisualStyleBackColor = false;
            this.radioBtnBlue.CheckedChanged += new System.EventHandler(this.radioBtn_blue_CheckedChanged);
            // 
            // radioBtnOrange
            // 
            this.radioBtnOrange.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBtnOrange.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnOrange.BackgroundImage = global::Space_invader.Properties.Resources.background;
            this.radioBtnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioBtnOrange.ForeColor = System.Drawing.Color.Black;
            this.radioBtnOrange.Image = global::Space_invader.Properties.Resources.playerShip1_orange;
            this.radioBtnOrange.Location = new System.Drawing.Point(662, 333);
            this.radioBtnOrange.Name = "radioBtnOrange";
            this.radioBtnOrange.Size = new System.Drawing.Size(172, 113);
            this.radioBtnOrange.TabIndex = 8;
            this.radioBtnOrange.TabStop = true;
            this.radioBtnOrange.UseVisualStyleBackColor = false;
            // 
            // radioBtnRed
            // 
            this.radioBtnRed.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBtnRed.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnRed.BackgroundImage = global::Space_invader.Properties.Resources.background;
            this.radioBtnRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioBtnRed.ForeColor = System.Drawing.Color.Transparent;
            this.radioBtnRed.Image = global::Space_invader.Properties.Resources.playerShip1_red;
            this.radioBtnRed.Location = new System.Drawing.Point(1013, 530);
            this.radioBtnRed.Name = "radioBtnRed";
            this.radioBtnRed.Size = new System.Drawing.Size(172, 113);
            this.radioBtnRed.TabIndex = 9;
            this.radioBtnRed.TabStop = true;
            this.radioBtnRed.UseVisualStyleBackColor = false;
            this.radioBtnRed.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Space_invader.Properties.Resources.logo_space_invader;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(662, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 197);
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
            this.button1.Location = new System.Drawing.Point(849, 750);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 84);
            this.button1.TabIndex = 11;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Space_invader.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1896, 1016);
            this.Controls.Add(this.radioBtnBlue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioBtnGreen);
            this.Controls.Add(this.radioBtnRed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioBtnOrange);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.RadioButton radioBtnGreen;
        private System.Windows.Forms.RadioButton radioBtnBlue;
        private System.Windows.Forms.RadioButton radioBtnOrange;
        private System.Windows.Forms.RadioButton radioBtnRed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button1;
    }
}

