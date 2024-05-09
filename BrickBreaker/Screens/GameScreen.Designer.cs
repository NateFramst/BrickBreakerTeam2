﻿namespace BrickBreaker
{
    partial class GameScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.power1Label = new System.Windows.Forms.Label();
            this.power2Label = new System.Windows.Forms.Label();
            this.power3Label = new System.Windows.Forms.Label();
            this.power4Label = new System.Windows.Forms.Label();
            this.power5Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // power1Label
            // 
            this.power1Label.BackColor = System.Drawing.Color.Silver;
            this.power1Label.Location = new System.Drawing.Point(4, 114);
            this.power1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.power1Label.Name = "power1Label";
            this.power1Label.Size = new System.Drawing.Size(102, 96);
            this.power1Label.TabIndex = 6;
            // 
            // power2Label
            // 
            this.power2Label.BackColor = System.Drawing.Color.Silver;
            this.power2Label.Location = new System.Drawing.Point(4, 264);
            this.power2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.power2Label.Name = "power2Label";
            this.power2Label.Size = new System.Drawing.Size(102, 96);
            this.power2Label.TabIndex = 6;
            // 
            // power3Label
            // 
            this.power3Label.BackColor = System.Drawing.Color.Silver;
            this.power3Label.Location = new System.Drawing.Point(4, 406);
            this.power3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.power3Label.Name = "power3Label";
            this.power3Label.Size = new System.Drawing.Size(102, 96);
            this.power3Label.TabIndex = 6;
            // 
            // power4Label
            // 
            this.power4Label.BackColor = System.Drawing.Color.Silver;
            this.power4Label.Location = new System.Drawing.Point(4, 552);
            this.power4Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.power4Label.Name = "power4Label";
            this.power4Label.Size = new System.Drawing.Size(102, 96);
            this.power4Label.TabIndex = 6;
            // 
            // power5Label
            // 
            this.power5Label.BackColor = System.Drawing.Color.Silver;
            this.power5Label.Location = new System.Drawing.Point(4, 702);
            this.power5Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.power5Label.Name = "power5Label";
            this.power5Label.Size = new System.Drawing.Size(102, 96);
            this.power5Label.TabIndex = 6;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.power5Label);
            this.Controls.Add(this.power4Label);
            this.Controls.Add(this.power3Label);
            this.Controls.Add(this.power2Label);
            this.Controls.Add(this.power1Label);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1708, 960);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameScreen_MouseDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label power1Label;
        private System.Windows.Forms.Label power2Label;
        private System.Windows.Forms.Label power3Label;
        private System.Windows.Forms.Label power4Label;
        private System.Windows.Forms.Label power5Label;
    }
}
