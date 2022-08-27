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
    public partial class highscore_listSlow : Form
    {
        string baseRoute = "";
        string highscoreListSlow = "";

        string[] stringArray;

        public highscore_listSlow()
        {
            InitializeComponent();
            Get_Routes();
            Set_HighscoreList();
        }

        private void Get_Routes()
        {
            baseRoute = Path.GetFullPath(Environment.CurrentDirectory);
            highscoreListSlow = baseRoute + @"\settings\highscorelist-slow.txt";
        }

        private void Set_HighscoreList()
        {
            //Reading highscore-list file (.txt)
            string[] zeilen = File.ReadAllLines(highscoreListSlow);
            stringArray = new string[zeilen.Length + 1];

            //Copying the textfile into an array
            for (int i = 0; i < zeilen.Length; i++)
            {
                stringArray[i + 1] = zeilen[i];
            }

            //Sorting the array (if the upper value is smaller than the lower value of the array they change position)
            for (int j = 0; j < zeilen.Length; j++)
            {
                for (int k = 1; k < zeilen.Length; k++)
                {
                    if (Convert.ToInt32(stringArray[k].Split(';')[1]) < Convert.ToInt32(stringArray[k + 1].Split(';')[1]))
                    {
                        string temp = stringArray[k];
                        stringArray[k] = stringArray[k + 1];
                        stringArray[k + 1] = temp;
                    }
                }
            }

            label_Assign();
        }

        private void label_Assign()
        {
            string[] zeilen = File.ReadAllLines(highscoreListSlow);

            //Clearing the TableLayoutPanel (for the refreshing event)
            tlp_list.Controls.Clear();

            //If there are more than 10 values it should only take the first 10 values of the array
            if (zeilen.Length > 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    //Creating new labels
                    Label position = new Label();
                    Label name = new Label();
                    Label score = new Label();

                    //Settings for the labels
                    position.TextAlign = ContentAlignment.MiddleCenter;
                    name.TextAlign = ContentAlignment.MiddleCenter;
                    score.TextAlign = ContentAlignment.MiddleCenter;

                    //Defining the text of those labels out of the array
                    position.Text = (i + 1) + ".";
                    name.Text = stringArray[i + 1].Split(';')[0];
                    score.Text = stringArray[i + 1].Split(';')[1];

                    //Adding those labels to the TableLayoutPanel
                    tlp_list.Controls.Add(position, 0, i);
                    tlp_list.Controls.Add(name, 1, i);
                    tlp_list.Controls.Add(score, 2, i);
                }
            }
            //If there are less than 10 values it should take the following amount of it
            else
            {
                //(Same as above)
                for (int i = 0; i < zeilen.Length; i++)
                {
                    Label position = new Label();
                    Label name = new Label();
                    Label score = new Label();

                    position.TextAlign = ContentAlignment.MiddleCenter;
                    name.TextAlign = ContentAlignment.MiddleCenter;
                    score.TextAlign = ContentAlignment.MiddleCenter;

                    position.Text = (i + 1) + ".";
                    name.Text = stringArray[i + 1].Split(';')[0];
                    score.Text = stringArray[i + 1].Split(';')[1];

                    tlp_list.Controls.Add(position, 0, i);
                    tlp_list.Controls.Add(name, 1, i);
                    tlp_list.Controls.Add(score, 2, i);
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //By pressing the exit button the interface reappears
            new blackdragon_interface().Show();
            this.Hide();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //Refreshing highscorelist
            Set_HighscoreList();
        }

        private void highscore_listSlow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //By closing this window (without pressing exit) the interface should come back up
            new blackdragon_interface().Show();
        }
    }
}
