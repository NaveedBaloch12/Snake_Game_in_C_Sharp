using Snake_Game.UserControls.Levels_UserControls;
using System;
using System.Windows.Forms;


namespace Snake_Game.UserControls
{
    public partial class UC_Play : UserControl
    {
        public UC_Play()
        {
            InitializeComponent();
        }


        #region Defined Functions
        void ShowLevelForm(string LevelNumber)
        {
            this.Parent.Hide();

            var form_Level = new FormLevels(LevelNumber);
            form_Level.Closed += (s, args) => this.Parent.Show();
            form_Level.Show();
        }

        void ChangePBLevelImage(object sender)
        {
            Label lb = (Label)sender;
            switch (lb.Name)
            {
                case "lbLevel1":
                    pbLevels.Image = Snake_Game.Properties.Resources.Level_00;
                    break;
                case "lbLevel2":
                    pbLevels.Image = Snake_Game.Properties.Resources.Level_01;
                    break;
                case "lbLevel3":
                    pbLevels.Image = Snake_Game.Properties.Resources.Level_01;
                    break;
                case "lbLevel4":
                    pbLevels.Image = Snake_Game.Properties.Resources.Level_01;
                    break;
                case "lbLevel5":
                    pbLevels.Image = Snake_Game.Properties.Resources.Level_01;
                    break;
                case "lbLevel6":
                    pbLevels.Image = Snake_Game.Properties.Resources.Level_01;
                    break;
                case "lbLevel7":
                    pbLevels.Image = Snake_Game.Properties.Resources.Level_01;
                    break;

                default:
                    pbLevels.Image = null;
                    break;
            }
        }

        #endregion


        #region Mouse Enter/Leave Events
        private void lbLevels_MouseEnter(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.MouseEnterInLabel(sender, 28F);
            ChangePBLevelImage(sender);
        }

        private void lbLevels_MouseLeave(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.ChangeFontSize(sender, 24F);
            pbLevels.Image = null;
        }

        #endregion 

        #region Levels Label Click Events

        private void lbLevel1_Click(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.PlaySoundMouseClick();
            ShowLevelForm("l1");

        }

        private void lbLevel2_Click(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.PlaySoundMouseClick();
            ShowLevelForm("l2");

        }

        private void lbLevel3_Click(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.PlaySoundMouseClick();
            ShowLevelForm("l3");
        }

        private void lbLevel4_Click(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.PlaySoundMouseClick();
            ShowLevelForm("l4");
        }

        private void lbLevel5_Click(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.PlaySoundMouseClick();
            ShowLevelForm("l6");
        }

        private void lbLevel6_Click(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.PlaySoundMouseClick();
            ShowLevelForm("l6");
        }

        private void lbLevel7_Click(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.PlaySoundMouseClick();
            ShowLevelForm("l7");
        }

        #endregion


        // Click Back Events
        private void lbBack_Click(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.PlaySoundMouseClick();
            this.Parent.Controls.Remove(this);
        }

    }
}
