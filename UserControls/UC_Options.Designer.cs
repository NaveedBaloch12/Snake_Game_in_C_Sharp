namespace Snake_Game.UserControls
{
    partial class UC_Options
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
            this.lbSelectLevel = new System.Windows.Forms.Label();
            this.lbPlaySound = new System.Windows.Forms.Label();
            this.CBPlaySoundCheck = new System.Windows.Forms.Label();
            this.lbBack = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbSelectLevel
            // 
            this.lbSelectLevel.AutoSize = true;
            this.lbSelectLevel.BackColor = System.Drawing.Color.Transparent;
            this.lbSelectLevel.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.lbSelectLevel.Font = new System.Drawing.Font("Buxton Sketch", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectLevel.Location = new System.Drawing.Point(263, 23);
            this.lbSelectLevel.Name = "lbSelectLevel";
            this.lbSelectLevel.Size = new System.Drawing.Size(209, 74);
            this.lbSelectLevel.TabIndex = 4;
            this.lbSelectLevel.Text = "Options";
            // 
            // lbPlaySound
            // 
            this.lbPlaySound.AutoSize = true;
            this.lbPlaySound.BackColor = System.Drawing.Color.Transparent;
            this.lbPlaySound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPlaySound.Font = new System.Drawing.Font("Buxton Sketch", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaySound.Location = new System.Drawing.Point(188, 146);
            this.lbPlaySound.Name = "lbPlaySound";
            this.lbPlaySound.Size = new System.Drawing.Size(138, 59);
            this.lbPlaySound.TabIndex = 6;
            this.lbPlaySound.Text = "Sound";
            // 
            // CBPlaySoundCheck
            // 
            this.CBPlaySoundCheck.AutoSize = true;
            this.CBPlaySoundCheck.BackColor = System.Drawing.Color.Transparent;
            this.CBPlaySoundCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBPlaySoundCheck.Font = new System.Drawing.Font("Buxton Sketch", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPlaySoundCheck.Location = new System.Drawing.Point(409, 146);
            this.CBPlaySoundCheck.Name = "CBPlaySoundCheck";
            this.CBPlaySoundCheck.Size = new System.Drawing.Size(157, 59);
            this.CBPlaySoundCheck.TabIndex = 7;
            this.CBPlaySoundCheck.Text = "Enabled";
            this.CBPlaySoundCheck.Click += new System.EventHandler(this.CBPlaySoundCheck_Click);
            this.CBPlaySoundCheck.MouseEnter += new System.EventHandler(this.Font_MouseEnter);
            this.CBPlaySoundCheck.MouseLeave += new System.EventHandler(this.Font_MouseLeave);
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.BackColor = System.Drawing.Color.Transparent;
            this.lbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBack.Font = new System.Drawing.Font("Buxton Sketch", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBack.Location = new System.Drawing.Point(452, 364);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(114, 59);
            this.lbBack.TabIndex = 13;
            this.lbBack.Text = "Back";
            this.lbBack.Click += new System.EventHandler(this.lbBack_Click);
            this.lbBack.MouseEnter += new System.EventHandler(this.Font_MouseEnter);
            this.lbBack.MouseLeave += new System.EventHandler(this.Font_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Buxton Sketch", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 59);
            this.label2.TabIndex = 14;
            this.label2.Text = "Difficulty";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.BackColor = System.Drawing.Color.YellowGreen;
            this.cbDifficulty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDifficulty.Font = new System.Drawing.Font("Buxton Sketch", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDifficulty.FormattingEnabled = true;
            this.cbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cbDifficulty.Location = new System.Drawing.Point(413, 232);
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(203, 57);
            this.cbDifficulty.TabIndex = 15;
            this.cbDifficulty.TabStop = false;
            this.cbDifficulty.SelectedIndexChanged += new System.EventHandler(this.cbDifficulty_SelectedIndexChanged);
            this.cbDifficulty.MouseCaptureChanged += new System.EventHandler(this.cbDifficulty_MouseCaptureChanged);
            // 
            // UC_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cbDifficulty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.CBPlaySoundCheck);
            this.Controls.Add(this.lbPlaySound);
            this.Controls.Add(this.lbSelectLevel);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Name = "UC_Options";
            this.Size = new System.Drawing.Size(735, 649);
            this.Load += new System.EventHandler(this.UC_Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSelectLevel;
        private System.Windows.Forms.Label lbPlaySound;
        private System.Windows.Forms.Label CBPlaySoundCheck;
        private System.Windows.Forms.Label lbBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDifficulty;
    }
}
