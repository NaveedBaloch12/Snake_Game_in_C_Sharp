using System;
using System.Windows.Forms;

namespace Snake_Game.UserControls
{
    public partial class UC_Options : UserControl
    {
        public UC_Options()
        {
            InitializeComponent();
            
        }


        // User Control Load Event
        private void UC_Options_Load(object sender, EventArgs e)
        {
            if (Globals_Feilds_Functions.PlaySound == true)
            {
                CBPlaySoundCheck.Text = "Enabled";
            }
            else
            {
                CBPlaySoundCheck.Text = "Disabled";
            }

            if(Globals_Feilds_Functions.SnakeSpeed == 150)
            {
                cbDifficulty.Text = "Easy";
            }
            else if (Globals_Feilds_Functions.SnakeSpeed == 100)
            {
                cbDifficulty.Text = "Medium";
            }
            else if (Globals_Feilds_Functions.SnakeSpeed == 50)
            {
                cbDifficulty.Text = "Hard";
            }
        }

        #region Sound Enable/Disable Code Stuff

        private void CBPlaySoundCheck_Click(object sender, EventArgs e)
        {
            if (Globals_Feilds_Functions.PlaySound == true)
            {
                CBPlaySoundCheck.Text = "Disabled";
                Globals_Feilds_Functions.PlaySound = false; ;
            }
            else
            {
                CBPlaySoundCheck.Text = "Enabled";
                Globals_Feilds_Functions.PlaySound = true;
            }
            Globals_Feilds_Functions.PlaySoundMouseClick();
        }

        #endregion

        #region Mouse Enter Leave and Click Events

        private void lbBack_Click(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.PlaySoundMouseClick();
            this.Parent.Controls.Remove(this);
        }

        private void Font_MouseEnter(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.MouseEnterInLabel(sender, 28F);
        }

        private void Font_MouseLeave(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.ChangeFontSize(sender, 24F);
        }

        #endregion

        #region Game Dificulty Code Stuff
        private void cbDifficulty_MouseCaptureChanged(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.PlaySoundMouseIn();
        }

        private void cbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDifficulty.SelectedIndex == 0)
            {
                Globals_Feilds_Functions.SnakeSpeed = 150;
                Globals_Feilds_Functions.PlaySoundMouseClick();
            }
            if (cbDifficulty.SelectedIndex == 1)
            {
                Globals_Feilds_Functions.SnakeSpeed = 100;
                Globals_Feilds_Functions.PlaySoundMouseClick();
            }
            if (cbDifficulty.SelectedIndex == 2)
            {
                Globals_Feilds_Functions.SnakeSpeed = 50;
                Globals_Feilds_Functions.PlaySoundMouseClick();
            }

        }

        #endregion
    }
}
