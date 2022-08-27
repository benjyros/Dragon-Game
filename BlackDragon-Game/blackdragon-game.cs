using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackDragon_Game
{
    public partial class blackdragon_game : Form
    {
        string baseRoute = "";
        string saves = "";
        string images = "";
        string settings = "";

        int rememberRow;
        int rememberColumn;
        int rndRow;
        int rndColumn;
        int score = 0;

        bool up, down, left, right;

        Label DragonEgg = new Label();

        Random rndNum = new Random();

        List<Panel> Dragon = new List<Panel>();
        List<TableLayoutPanelCellPosition> cells = new List<TableLayoutPanelCellPosition>();

        private void blackdragon_game_KeyDown(object sender, KeyEventArgs e)
        {
            //Keyevents when pressed
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (!down && tLP_gameField.GetColumn(pnl_head) != rememberColumn)
                    {
                        down = left = right = false;
                        up = true;
                    }
                    if (timer_game.Enabled == false)
                    {
                        Game_Start();
                    }
                    break;

                case Keys.Down:
                    if (!up && tLP_gameField.GetColumn(pnl_head) != rememberColumn)
                    {
                        up = left = right = false;
                        down = true;
                    }
                    if (timer_game.Enabled == false)
                    {
                        Game_Start();
                    }
                    break;

                case Keys.Left:
                    if (!right && tLP_gameField.GetRow(pnl_head) != rememberRow)
                    {
                        up = down = right = false;
                        left = true;
                    }
                    break;

                case Keys.Right:
                    if (!left && tLP_gameField.GetRow(pnl_head) != rememberRow)
                    {
                        up = down = left = false;
                        right = true;
                    }
                    if (timer_game.Enabled == false)
                    {
                        Game_Start();
                    }
                    break;

                default:
                    break;
            }
        }

        public blackdragon_game()
        {
            InitializeComponent();
            Get_BaseRoute();

            //Setting for Clientsize
            ClientSize = new Size(560, 560);

            Set_Backcolor();

            Set_Images();

            Set_Speed();
        }

        private void Get_BaseRoute()
        {
            baseRoute = Path.GetFullPath(Environment.CurrentDirectory);
            saves = baseRoute + @"\saves";
            images = baseRoute + @"\images";
            settings = baseRoute + @"\settings";
        }

        private void Set_Backcolor()
        {
            //Setting backcolor of the game
            tLP_gameField.BackColor = Properties.Settings.Default.colorBackcolor;
        }

        private void Set_Images()
        {
            //Settings for images
            pnl_head.BackgroundImage = new Bitmap(images + @"\head.png");

            DragonEgg.Image = new Bitmap(images + @"\dragonEgg_new.png");
            DragonEgg.Margin = new Padding(0, 0, 0, 0);
            DragonEgg.BackColor = Color.Transparent;
            DragonEgg.Dock = DockStyle.Fill;

            //Adding dragonegg to gamefield
            tLP_gameField.Controls.Add(DragonEgg, 15, 9);
        }

        private void Set_Speed()
        {
            //Speedsettings
            int speed = Properties.Settings.Default.gamespeed;

            if (speed == 1)
            {
                timer_game.Interval = 500;
            }
            else if (speed == 2)
            {
                timer_game.Interval = 200;
            }
            else if (speed == 3)
            {
                timer_game.Interval = 100;
            }
        }

        private void Game_Start()
        {
            Dragon_Bodyparts();

            //Different moves when the boolean returns a value at gamestart
            if (up)
            {
                up = true;
                timer_game.Enabled = true;
            }
            if (down)
            {
                down = true;
                timer_game.Enabled = true;
            }
            if (right)
            {
                right = true;
                timer_game.Enabled = true;
            }
        }

        private void Dragon_Bodyparts()
        {
            //Adding different bodyparts to the dragon- and cells-list
            Dragon.Add(pnl_head);
            Dragon.Add(pnl_body);
            Dragon.Add(pnl_midBody);
            Dragon.Add(pnl_midTail);
            Dragon.Add(pnl_tail);
            cells.Add(tLP_gameField.GetCellPosition(pnl_head));
            cells.Add(tLP_gameField.GetCellPosition(pnl_body));
            cells.Add(tLP_gameField.GetCellPosition(pnl_midBody));
            cells.Add(tLP_gameField.GetCellPosition(pnl_midTail));
            cells.Add(tLP_gameField.GetCellPosition(pnl_tail));
        }

        private void timer_game_Tick(object sender, EventArgs e)
        {
            //Set the first cell for dragonhead
            cells[0] = tLP_gameField.GetCellPosition(pnl_head);

            //remembering turn (bugfix)
            rememberRow = tLP_gameField.GetRow(pnl_body);
            rememberColumn = tLP_gameField.GetColumn(pnl_head);

            Dragon_Turn();

            Body_Align();

            Eat_Event();

            Game_Over();
        }

        private void Dragon_Turn()
        {
            //Event for turn; flipping dragonhead into the right direction
            pnl_head.BackgroundImage = new Bitmap(images + @"\head.png");
            if (up)
            {
                pnl_head.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                tLP_gameField.SetCellPosition(pnl_head, new TableLayoutPanelCellPosition(tLP_gameField.GetColumn(pnl_head), tLP_gameField.GetRow(pnl_head) - 1));
            }
            if (down)
            {
                pnl_head.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                tLP_gameField.SetCellPosition(pnl_head, new TableLayoutPanelCellPosition(tLP_gameField.GetColumn(pnl_head), tLP_gameField.GetRow(pnl_head) + 1));
            }
            if (left)
            {
                pnl_head.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                tLP_gameField.SetCellPosition(pnl_head, new TableLayoutPanelCellPosition(tLP_gameField.GetColumn(pnl_head) - 1, tLP_gameField.GetRow(pnl_head)));
            }
            if (right)
            {
                tLP_gameField.SetCellPosition(pnl_head, new TableLayoutPanelCellPosition(tLP_gameField.GetColumn(pnl_head) + 1, tLP_gameField.GetRow(pnl_head)));
            }
        }

        private void Body_Align()
        {
            //Aligning the body, so the bodyparts move with the dragon
            for (int i = 1; i < Dragon.Count; i++)
            {
                cells[i] = tLP_gameField.GetCellPosition(Dragon[i]);
                tLP_gameField.SetCellPosition(Dragon[i], cells[i - 1]);
            }
        }

        private void Eat_Event()
        {
            //When the dragon is on the dragonegg the following will happen
            if (tLP_gameField.GetCellPosition(pnl_head).Equals(tLP_gameField.GetCellPosition(DragonEgg)))
            {
                //For eating an egg you get a score of 100
                score = score + 100;

                //Creating a new panel and setting the backcolor and margin
                Panel body = new Panel();
                body.BackColor = SystemColors.ControlText;
                body.Margin = new Padding(5, 5, 5, 5);

                //Adding the new panel to the dragonbody and to the cells
                Dragon.Add(body);
                cells.Add(new TableLayoutPanelCellPosition(cells[cells.Count - 1].Column, cells[cells.Count - 1].Row));
                //Adding the panel to the gamefield
                tLP_gameField.Controls.Add(body, cells[cells.Count - 1].Column, cells[cells.Count - 1].Row);

                //Applying the last three bodyparts with margin
                Dragon[Dragon.Count - 1].Margin = new Padding(11, 11, 11, 11);
                Dragon[Dragon.Count - 2].Margin = new Padding(9, 9, 9, 9);
                Dragon[Dragon.Count - 3].Margin = new Padding(7, 7, 7, 7);

                //The rest of the body will have the same margin
                for (int i = 1; i < Dragon.Count - 4; i++)
                {
                    Dragon[i].Margin = new Padding(5, 5, 5, 5);
                }

                //If a dragonegg spawns on the body of the dragon, it will create a new spawnlocation
                do
                {
                    rndColumn = rndNum.Next(0, tLP_gameField.ColumnCount);
                    rndRow = rndNum.Next(0, tLP_gameField.RowCount);

                } while (cells.Exists(x => x.Column == rndColumn && x.Row == rndRow));

                //Adding the dragonegg to the gamefield
                tLP_gameField.SetCellPosition(DragonEgg, new TableLayoutPanelCellPosition(rndColumn, rndRow));
            }
        }

        private void Game_Over()
        {
            //When the dragon hits him self or the wall the following will happen
            if (tLP_gameField.GetColumn(pnl_head) > tLP_gameField.ColumnCount - 1|| tLP_gameField.GetColumn(pnl_head) < 0 || tLP_gameField.GetRow(pnl_head) > tLP_gameField.RowCount - 1 || tLP_gameField.GetRow(pnl_head) < 0 || cells.Contains(tLP_gameField.GetCellPosition(pnl_head)))
            {
                //getting username and speed (for highscore-list category)
                string[] datas = File.ReadAllText(settings + @"\temp.txt").Split(';');

                string username = datas[0];
                string gameSpeed = File.ReadAllText(settings + @"\gamespeed.txt");

                //Getting routes
                string highscorelistSlow = settings + @"\highscorelist-slow.txt";
                string highscorelistNormal = settings + @"\highscorelist-normal.txt";
                string highscorelistFast = settings + @"\highscorelist-fast.txt";
                string playerDirectory = saves + @"\" + username;
                string playerScores = playerDirectory + @"\scores.txt";

                //Adding the scores to the respective category
                if (gameSpeed == "1")
                {
                    File.AppendAllText(highscorelistSlow, username + ";" + score + Environment.NewLine);
                    File.AppendAllText(playerScores, score + Environment.NewLine);
                }
                else if (gameSpeed == "2")
                {
                    File.AppendAllText(highscorelistNormal, username + ";" + score + Environment.NewLine);
                    File.AppendAllText(playerScores, score + Environment.NewLine);
                }
                else if (gameSpeed == "3")
                {
                    File.AppendAllText(highscorelistFast, username + ";" + score + Environment.NewLine);
                    File.AppendAllText(playerScores, score + Environment.NewLine);
                }

                //Disable timer (gametick) and hiding the dragonhead, so the head wont appear on the other side of the field (bugfix)
                timer_game.Enabled = false;
                pnl_head.Visible = false;

                //Disabling the movements
                right = left = up = down = false;

                //Creating a messagebox with a yes- and no-button
                DialogResult dr = MessageBox.Show("Game over!\nYour score was " + score + "\nDo you wanna play again?", "Dragon died", MessageBoxButtons.YesNo);

                //When clicked on yes the following will happen
                if (dr == DialogResult.Yes)
                {
                    //Removing the dragonegg from the gamefield
                    tLP_gameField.Controls.Remove(DragonEgg);

                    //Removing all bodyparts of the dragon
                    foreach (Panel p in Dragon)
                    {
                        tLP_gameField.Controls.Remove(p);
                    }

                    //Setting the score to 0
                    score = 0;

                    //Clearing the dragon- and cells-list
                    Dragon.Clear();
                    cells.Clear();

                    //Adding the start-bodyparts into the gamefield
                    tLP_gameField.Controls.Add(pnl_head);
                    tLP_gameField.Controls.Add(pnl_body);
                    tLP_gameField.Controls.Add(pnl_midBody);
                    tLP_gameField.Controls.Add(pnl_midTail);
                    tLP_gameField.Controls.Add(pnl_tail);

                    //Setting the position of the different bodyparts
                    tLP_gameField.SetCellPosition(pnl_head, new TableLayoutPanelCellPosition(5, 9));
                    tLP_gameField.SetCellPosition(pnl_body, new TableLayoutPanelCellPosition(4, 9));
                    tLP_gameField.SetCellPosition(pnl_midBody, new TableLayoutPanelCellPosition(3, 9));
                    tLP_gameField.SetCellPosition(pnl_midTail, new TableLayoutPanelCellPosition(2, 9));
                    tLP_gameField.SetCellPosition(pnl_tail, new TableLayoutPanelCellPosition(1, 9));

                    Set_Images();

                    //Reappearing the dragonhead
                    pnl_head.Visible = true;
                }
                //When clicked on no the program-interface will show up
                if (dr == DialogResult.No)
                {
                    new blackdragon_interface().Show();
                    this.Hide();
                }
            }
        }

        private void blackdragon_game_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Closing game completely when exit
            Environment.Exit(0);
        }
    }
}
