using System.Media;
using System.Windows.Forms;

namespace Snake_Game
{
    internal static class Globals_Feilds_Functions
    {

        public static bool PlaySound = true;
        public static int SnakeSpeed = 100;


        // Public Functions Used in This Project
        public static void ChangeFontSize(object sender, float Size)
        {
            var label = (Label)sender;
            label.Font = new System.Drawing.Font("Buxton Sketch", Size, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        public static void PlaySoundMouseIn()
        {
            if (PlaySound)
            {
                using (var soundPlayer = new SoundPlayer(@"D:\Study\My Practice\Projects\Snake_Game\Sounds\menu-selection.wav"))
                {
                    soundPlayer.Play();
                }
            }
        }
        public static void PlaySoundMouseClick()
        {
            if(PlaySound)
            {
                using (var soundPlayer = new SoundPlayer(@"D:\Study\My Practice\Projects\Snake_Game\Sounds\mouse-click.wav"))
                {
                    soundPlayer.Play();
                }
            }
        }

        public static void MouseEnterInLabel(object sender, float size)
        {
            PlaySoundMouseIn();
            ChangeFontSize(sender, size);
        }


        public static void GameOverSound()
        {
            if (Globals_Feilds_Functions.PlaySound)
            {
                using (var soundPlayer = new SoundPlayer(@"D:\Study\My Practice\Projects\Snake_Game\Sounds\game-fail.wav"))
                {
                    soundPlayer.Play();
                }
            }
        }

        public static void SnakeEatSound()
        {
            if (Globals_Feilds_Functions.PlaySound)
            {
                using (var soundPlayer = new SoundPlayer(@"D:\Study\My Practice\Projects\Snake_Game\Sounds\snake-Eat.wav"))
                {
                    soundPlayer.Play();
                }
            }
        }

    }
}
