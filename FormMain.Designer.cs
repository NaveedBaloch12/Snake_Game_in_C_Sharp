namespace Snake_Game
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lbPlayGame = new System.Windows.Forms.Label();
            this.lbOptions = new System.Windows.Forms.Label();
            this.pbSnake = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnake)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPlayGame
            // 
            this.lbPlayGame.AutoSize = true;
            this.lbPlayGame.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPlayGame.Font = new System.Drawing.Font("Buxton Sketch", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayGame.Location = new System.Drawing.Point(140, 47);
            this.lbPlayGame.Name = "lbPlayGame";
            this.lbPlayGame.Size = new System.Drawing.Size(174, 89);
            this.lbPlayGame.TabIndex = 2;
            this.lbPlayGame.Text = "PLAY";
            this.lbPlayGame.Click += new System.EventHandler(this.lbPlayGame_Click);
            this.lbPlayGame.MouseEnter += new System.EventHandler(this.lbPlayGame_MouseEnter);
            this.lbPlayGame.MouseLeave += new System.EventHandler(this.lbPlayGame_MouseLeave);
            // 
            // lbOptions
            // 
            this.lbOptions.AutoSize = true;
            this.lbOptions.BackColor = System.Drawing.Color.Transparent;
            this.lbOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbOptions.Font = new System.Drawing.Font("Buxton Sketch", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOptions.Location = new System.Drawing.Point(132, 141);
            this.lbOptions.Name = "lbOptions";
            this.lbOptions.Size = new System.Drawing.Size(190, 59);
            this.lbOptions.TabIndex = 3;
            this.lbOptions.Text = "OPTIONS";
            this.lbOptions.Click += new System.EventHandler(this.lbOptions_Click);
            this.lbOptions.MouseEnter += new System.EventHandler(this.lbOptions_MouseEnter);
            this.lbOptions.MouseLeave += new System.EventHandler(this.lbOptions_MouseLeave);
            // 
            // pbSnake
            // 
            this.pbSnake.BackColor = System.Drawing.Color.Transparent;
            this.pbSnake.Image = global::Snake_Game.Properties.Resources.Snake_ImageInverted_removebg_preview;
            this.pbSnake.Location = new System.Drawing.Point(-24, 252);
            this.pbSnake.Name = "pbSnake";
            this.pbSnake.Size = new System.Drawing.Size(359, 368);
            this.pbSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSnake.TabIndex = 4;
            this.pbSnake.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.lbPlayGame);
            this.panelMenu.Controls.Add(this.lbOptions);
            this.panelMenu.Location = new System.Drawing.Point(315, 142);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(454, 307);
            this.panelMenu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "EXIT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.lbOptions_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.lbOptions_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(168)))), ((int)(((byte)(6)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 590);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.pbSnake);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Font = new System.Drawing.Font("Buxton Sketch", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbSnake)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbPlayGame;
        private System.Windows.Forms.Label lbOptions;
        private System.Windows.Forms.PictureBox pbSnake;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
    }
}

