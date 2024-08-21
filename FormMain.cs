using Snake_Game.UserControls;
using System;
using System.Media;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.ControlRemoved += FormMain_ControlRemoved;
        }

        private void FormMain_ControlRemoved(object sender, ControlEventArgs e)
        {
            panelMenu.Visible = true;
        }

        #region Label Play and Options and Exit Code Stuff
        // Label Play
        private void lbPlayGame_MouseEnter(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.MouseEnterInLabel(sender, 48F);
        }

        private void lbPlayGame_Click(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.PlaySoundMouseClick();
            var UC = new UC_Play();
            ShowUserControl(UC);
        }

        private void lbPlayGame_MouseLeave(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.ChangeFontSize(sender, 36F);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (Globals_Feilds_Functions.PlaySound)
            {
                using (var soundPlayer = new SoundPlayer(@"D:\Study\My Practice\Projects\Snake_Game\Sounds\Door-opening.wav"))
                {
                    soundPlayer.Play();
                }
            }

            if (MessageBox.Show("Want to Exit Game?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                Application.Exit();
            }
        }


        // Label Options

        private void lbOptions_MouseEnter(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.MouseEnterInLabel(sender, 28F);
        }

        private void lbOptions_Click(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.PlaySoundMouseClick();
            var UC = new UC_Options();
            ShowUserControl(UC);
        }

        private void lbOptions_MouseLeave(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.ChangeFontSize(sender, 24F);
        }

        #endregion

        #region Defined Funtions

        void ShowUserControl(UserControl UC)
        {
            UC.Anchor = AnchorStyles.None;
            UC.Location = new System.Drawing.Point(380, 50);
            this.Controls.Add(UC);
            panelMenu.Visible = false;
        }

        #endregion
    }
}
