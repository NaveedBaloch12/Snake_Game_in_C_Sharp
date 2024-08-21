namespace Snake_Game.UserControls.Levels_UserControls
{
    partial class FormLevels
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLevels));
            this.panelGameBoard = new System.Windows.Forms.Panel();
            this.pbGameBoard = new System.Windows.Forms.PictureBox();
            this.lbLavelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbScores = new System.Windows.Forms.Label();
            this.lbBack = new System.Windows.Forms.Label();
            this.lbGameOver = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbGameStart = new System.Windows.Forms.Label();
            this.panelGameBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGameBoard
            // 
            this.panelGameBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGameBoard.Controls.Add(this.pbGameBoard);
            this.panelGameBoard.Location = new System.Drawing.Point(9, 19);
            this.panelGameBoard.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelGameBoard.Name = "panelGameBoard";
            this.panelGameBoard.Size = new System.Drawing.Size(789, 556);
            this.panelGameBoard.TabIndex = 0;
            // 
            // pbGameBoard
            // 
            this.pbGameBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGameBoard.Location = new System.Drawing.Point(0, 0);
            this.pbGameBoard.Name = "pbGameBoard";
            this.pbGameBoard.Size = new System.Drawing.Size(785, 552);
            this.pbGameBoard.TabIndex = 0;
            this.pbGameBoard.TabStop = false;
            this.pbGameBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGameBoard_Paint);
            // 
            // lbLavelName
            // 
            this.lbLavelName.AutoSize = true;
            this.lbLavelName.BackColor = System.Drawing.Color.Transparent;
            this.lbLavelName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLavelName.Font = new System.Drawing.Font("Buxton Sketch", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLavelName.Location = new System.Drawing.Point(836, 26);
            this.lbLavelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLavelName.Name = "lbLavelName";
            this.lbLavelName.Size = new System.Drawing.Size(219, 74);
            this.lbLavelName.TabIndex = 3;
            this.lbLavelName.Text = "Level 02";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(813, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scores";
            // 
            // lbScores
            // 
            this.lbScores.AutoSize = true;
            this.lbScores.BackColor = System.Drawing.Color.Transparent;
            this.lbScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbScores.Font = new System.Drawing.Font("Buxton Sketch", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScores.Location = new System.Drawing.Point(973, 98);
            this.lbScores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbScores.Name = "lbScores";
            this.lbScores.Size = new System.Drawing.Size(69, 54);
            this.lbScores.TabIndex = 5;
            this.lbScores.Text = "00";
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.BackColor = System.Drawing.Color.Transparent;
            this.lbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBack.Font = new System.Drawing.Font("Buxton Sketch", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBack.Location = new System.Drawing.Point(962, 382);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(107, 59);
            this.lbBack.TabIndex = 13;
            this.lbBack.Text = "Quit";
            this.lbBack.Click += new System.EventHandler(this.lbBack_Click);
            this.lbBack.MouseEnter += new System.EventHandler(this.lbBack_MouseEnter);
            this.lbBack.MouseLeave += new System.EventHandler(this.lbBack_MouseLeave);
            // 
            // lbGameOver
            // 
            this.lbGameOver.AutoSize = true;
            this.lbGameOver.BackColor = System.Drawing.Color.White;
            this.lbGameOver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbGameOver.Font = new System.Drawing.Font("Buxton Sketch", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameOver.ForeColor = System.Drawing.Color.Red;
            this.lbGameOver.Location = new System.Drawing.Point(412, 260);
            this.lbGameOver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGameOver.Name = "lbGameOver";
            this.lbGameOver.Size = new System.Drawing.Size(264, 74);
            this.lbGameOver.TabIndex = 15;
            this.lbGameOver.Text = "Game Over";
            this.lbGameOver.Visible = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // lbGameStart
            // 
            this.lbGameStart.AutoSize = true;
            this.lbGameStart.BackColor = System.Drawing.Color.Transparent;
            this.lbGameStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbGameStart.Font = new System.Drawing.Font("Buxton Sketch", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameStart.Location = new System.Drawing.Point(822, 169);
            this.lbGameStart.Name = "lbGameStart";
            this.lbGameStart.Size = new System.Drawing.Size(233, 59);
            this.lbGameStart.TabIndex = 16;
            this.lbGameStart.Text = "Start Game";
            this.lbGameStart.Click += new System.EventHandler(this.lbGameStart_Click);
            this.lbGameStart.MouseEnter += new System.EventHandler(this.lbBack_MouseEnter);
            this.lbGameStart.MouseLeave += new System.EventHandler(this.lbBack_MouseLeave);
            // 
            // FormLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(168)))), ((int)(((byte)(6)))));
            this.BackgroundImage = global::Snake_Game.Properties.Resources._8552475;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1088, 594);
            this.Controls.Add(this.lbGameStart);
            this.Controls.Add(this.lbGameOver);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.lbScores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLavelName);
            this.Controls.Add(this.panelGameBoard);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Font = new System.Drawing.Font("Buxton Sketch", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "FormLevels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Levels";
            this.Load += new System.EventHandler(this.FormLevels_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLevels_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormLevels_KeyUp);
            this.panelGameBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGameBoard;
        private System.Windows.Forms.Label lbLavelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbScores;
        private System.Windows.Forms.Label lbBack;
        private System.Windows.Forms.PictureBox pbGameBoard;
        private System.Windows.Forms.Label lbGameOver;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label lbGameStart;
    }
}