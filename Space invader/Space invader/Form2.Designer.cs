﻿namespace Space_invader
{
    partial class Form2
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
            this.txtScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.healthBarImage = new System.Windows.Forms.PictureBox();
            this.SpaceShip = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.healthBarImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(12, 622);
            this.txtScore.MinimumSize = new System.Drawing.Size(90, 50);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(90, 50);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "score :0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // healthBarImage
            // 
            this.healthBarImage.Image = global::Space_invader.Properties.Resources.full_health_bar;
            this.healthBarImage.Location = new System.Drawing.Point(947, 599);
            this.healthBarImage.Name = "healthBarImage";
            this.healthBarImage.Size = new System.Drawing.Size(305, 70);
            this.healthBarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.healthBarImage.TabIndex = 2;
            this.healthBarImage.TabStop = false;
            // 
            // SpaceShip
            // 
            this.SpaceShip.BackColor = System.Drawing.Color.Transparent;
            this.SpaceShip.Location = new System.Drawing.Point(527, 594);
            this.SpaceShip.Name = "SpaceShip";
            this.SpaceShip.Size = new System.Drawing.Size(75, 75);
            this.SpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpaceShip.TabIndex = 0;
            this.SpaceShip.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Space_invader.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.SpaceShip);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.healthBarImage);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.healthBarImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SpaceShip;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox healthBarImage;
    }
}
