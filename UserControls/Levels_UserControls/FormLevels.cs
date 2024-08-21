using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_Game.UserControls.Levels_UserControls
{
    public partial class FormLevels : Form
    {
        // Varibales and Objects
        string LevelNumber;
        int Scores = 0; 
        bool goUp, goDown, goRight, goLeft;
        int MaxWidth;
        int MaxHeight;

        Random random = new Random();
        Box Food = new Box();

        List<Box> Snake = new List<Box>();

        

        public FormLevels(string levelNo)
        {
            InitializeComponent();
            LevelNumber = LevelChooesFunction(levelNo);

            // Call Settings Static Class Constructer
            new Settings();
        }


        // Form Load Event
        private void FormLevels_Load(object sender, EventArgs e)
        {
            lbLavelName.Text = LevelNumber;
            MaxWidth = pbGameBoard.Width;
            MaxHeight = pbGameBoard.Height;
            GameTimer.Interval = Globals_Feilds_Functions.SnakeSpeed;
        }

        #region Game Start and Keys Down/Up Events

        // Game Start Button
        private void lbGameStart_Click(object sender, EventArgs e)
        {

            GameTimer.Enabled = true;
            GameStart();
            lbGameOver.Visible = false;
            lbGameStart.Visible = false;
            lbGameStart.Enabled = false;
        }

        private void FormLevels_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.Directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.Directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.Directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.Directions != "up")
            {
                goDown = true;
            }
        }

        private void FormLevels_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        #endregion

        #region Quit Game Code
        private void lbBack_MouseEnter(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.MouseEnterInLabel(sender, 28F);
        }

        private void lbBack_MouseLeave(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.ChangeFontSize(sender, 24F);
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            Globals_Feilds_Functions.PlaySoundMouseClick();
            if (MessageBox.Show("Want to Quit Game?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #endregion

        #region Picture Box Code Stuff

        private void pbGameBoard_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush snakeColor;

            for (int i = 0; i < Snake.Count; i++)
            {
                
                if (i == 0) // Snake Head Condition
                {
                    snakeColor = Brushes.Black;
                }
                else
                {
                    snakeColor = Brushes.DarkGray;
                }

                // to Fill the Snake Body 
                canvas.FillEllipse(snakeColor, new Rectangle(
                        Snake[i].X * Settings.Width,
                        Snake[i].Y * Settings.Height,
                        Settings.Width, Settings.Height
                    ));
            }

            // to fill Food Circle
            canvas.FillEllipse(Brushes.DarkRed, new Rectangle(
                        Food.X * Settings.Width - 1,
                        Food.Y * Settings.Height - 1,
                        Settings.Width - 1, Settings.Height - 1
                    ));
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Chnage Dirction of sanke Code
            if (goLeft)
            {
                Settings.Directions = "left";
            }
            if (goRight)
            {
                Settings.Directions = "right";
            }
            if (goDown)
            {
                Settings.Directions = "down";
            }
            if (goUp)
            {
                Settings.Directions = "up";
            }

            // Move Sanke in Direction
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                // Sanke Head Condition
                if (i == 0)
                {
                    switch (Settings.Directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                    }

                    // Choes Level Conditions
                    LevelCondition(i);

                    // Eat Food Condtion
                    if (Snake[i].X == Food.X && Snake[i].Y == Food.Y)
                    {
                        EatFood();
                    }

                    // Snake Die Condition
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }

                }
                else // to follow the front Circle
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }

            pbGameBoard.Invalidate();
        }

        #endregion

        #region Defined Functions for Game Start Over and Eat Food

        private void GameStart()
        {
            MaxWidth = pbGameBoard.Width / Settings.Width - 1;
            MaxHeight = pbGameBoard.Height / Settings.Height - 1;

            Scores = 0;
            Snake.Clear();
            lbScores.Text = "0";

            Box Head = new Box { X = 10, Y = 5 };
            Snake.Add(Head);

            for (int i = 0; i <= 5; i++)
            {
                Box Body = new Box();
                Snake.Add(Body);
            }

            Food = new Box { X = random.Next(2, MaxWidth), Y = random.Next(2, MaxHeight) };
            GameTimer.Start();
        }

        private void EatFood()
        {
            Scores++;

            lbScores.Text = "0" + Scores;

            Box lastBody = new Box
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(lastBody);
            Globals_Feilds_Functions.SnakeEatSound();
            Food = new Box { X = random.Next(2, MaxWidth), Y = random.Next(2, MaxHeight) };
        }

        private void GameOver()
        {
            GameTimer.Stop();
            lbGameOver.Visible = true;
            lbGameStart.Visible = true;
            lbGameStart.Enabled = true;

            Globals_Feilds_Functions.GameOverSound();
        }

        #endregion

        #region Functions to Decide the Selected Gema Level

        string LevelChooesFunction(string levelNo)
        {
            switch (levelNo)
            {
                case "l1":
                    return "Level 01";
                case "l2":
                    return "Level 02";
                case "l3":
                    return "Level 03";
                case "l4":
                    return "Level 04";
                case "l5":
                    return "Level 05";
                case "l6":
                    return "Level 06";
                case "l7":
                    return "Level 07";
                default:
                    return null;
            }
        }

        void LevelCondition(int PrmI)
        {
            switch (LevelNumber)
            {
                case "Level 01":
                    Level_01(PrmI);
                    break;
                case "Level 02":
                    Level_02(PrmI);
                    break;
                case "Level 03":

                    break;
                case "Level 04":

                    break;
                case "Level 05":

                    break;
                case "Level 06":

                case "Level 07":

                    break;
            }
        }

        #endregion

        #region Levels Functions

        void Level_01(int i)
        {
            if (Snake[i].X < 0)
            {
                Snake[i].X = MaxWidth;
            }
            if (Snake[i].X > MaxWidth)
            {
                Snake[i].X = 0;
            }
            if (Snake[i].Y < 0)
            {
                Snake[i].Y = MaxHeight;
            }
            if (Snake[i].Y > MaxHeight)
            {
                Snake[i].Y = 0;
            }
        }
        void Level_02(int i)
        {
            if (Snake[i].X < 0 || Snake[i].X > MaxWidth || Snake[i].Y < 0 || Snake[i].Y > MaxHeight) 
            {
                GameOver();
            }
        }

        #endregion

    }
}
