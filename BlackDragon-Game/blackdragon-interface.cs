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
    public partial class blackdragon_interface : Form
    {
        string baseRoute = "";
        string saves = "";
        string images = "";
        string settings = "";

        public blackdragon_interface()
        {
            InitializeComponent();

            Get_Routes();

            //Setting the clientsize
            ClientSize = new Size(440, 320);

            //Setting the images
            pBox_instructionsGoal.BackgroundImage = new Bitmap(images + @"\dragonEgg_new.png");
            pBox_instructionsGoal.BackgroundImage = new Bitmap(images + @"\arrow_keys.png");

            //Visualising all items of the instruction when starting the interface
            pBox_instructionsControls.Visible = true;
            pBox_instructionsGoal.Visible = true;
            lbl_instructionsGoal.Visible = true;
            lbl_instructionsGoalTxt.Visible = true;
            lbl_instructionsControls.Visible = true;
            lbl_instructionsControlsTxt.Visible = true;
            lbl_instructionsGamemode.Visible = true;
            lbl_instructionsGamemodeTxt.Visible = true;
            cBox_instructions.Visible = true;
        }

        private void Get_Routes()
        {
            baseRoute = Path.GetFullPath(Environment.CurrentDirectory);
            saves = baseRoute + @"\saves";
            images = baseRoute + @"\images";
            settings = baseRoute + @"\settings";
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_Visible_False();

            //Setting the clientsize
            ClientSize = new Size(440, 320);

            //Setting the images
            pBox_instructionsGoal.BackgroundImage = new Bitmap(images + @"\dragonEgg_new.png");
            pBox_instructionsGoal.BackgroundImage = new Bitmap(images + @"\arrow_keys.png");

            //Visualising all items of the instruction
            pBox_instructionsControls.Visible = true;
            pBox_instructionsGoal.Visible = true;
            lbl_instructionsGoal.Visible = true;
            lbl_instructionsGoalTxt.Visible = true;
            lbl_instructionsControls.Visible = true;
            lbl_instructionsControlsTxt.Visible = true;
            lbl_instructionsGamemode.Visible = true;
            lbl_instructionsGamemodeTxt.Visible = true;
            cBox_instructions.Visible = true;
        }

        private void cBox_instructions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If de index of combobox changes, the text also changes to its desciption
            if (cBox_instructions.Text == "Immortality")
            {
                lbl_instructionsGamemodeTxt.Text = "In this gamemode you will be immortal and cannot get killed in any way. \nThe only way to finish this game is to get the maximum size of the snake.";
            }
            else if (cBox_instructions.Text == "Added Treats")
            {
                lbl_instructionsGamemodeTxt.Text = "There will be one added Treat in this gamemode";
            }
            else if (cBox_instructions.Text == "Walls")
            {
                lbl_instructionsGamemodeTxt.Text = "There will be added walls in this gamemode. This should \n be more difficult to play.";
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Checking if the speed and backcolor are set, if not the "Start Game"-button wont enable
            if (Properties.Settings.Default.gamespeed == 0 || Properties.Settings.Default.gamemode == 0 || Properties.Settings.Default.stringBackcolor == "None")
            {
                startGameToolStripMenuItem.Enabled = false;
            }
            else
            {
                startGameToolStripMenuItem.Enabled = true;
            }
        }

        private void speedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_Visible_False();

            //Setting clientsize
            ClientSize = new Size(380, 240);
            
            //By getting the speed from the properties the radiobuttons match to that (example: if the speed is fast the radiobutton should be checked on fast)
            if (Properties.Settings.Default.gamespeed == 1)
            {
                rdB_gameSpeedSlow.Checked = true;
            }
            else if (Properties.Settings.Default.gamespeed == 2)
            {
                rdB_gameSpeedNormal.Checked = true;
            }
            else if (Properties.Settings.Default.gamespeed == 3)
            {
                rdB_gameSpeedFast.Checked = true;
            }
            else
            {
                //Default when you are new
                rdB_gameSpeedSlow.Checked = false;
                rdB_gameSpeedNormal.Checked = false;
                rdB_gameSpeedFast.Checked = false; 
            }

            //Visualise all items from the menuitem "Speed"
            lbl_gamespeed.Visible = true;
            pBox_gamespeed.Visible = true;
            rdB_gameSpeedSlow.Visible = true;
            rdB_gameSpeedNormal.Visible = true;
            rdB_gameSpeedFast.Visible = true;
            btn_gameSpeedApply.Visible = true;

            lbl_gamespeed.ForeColor = Color.Black;
        }

        private void rdB_speedSlow_CheckedChanged(object sender, EventArgs e)
        {
            //When the user already applied a setting the apply-button should get disabled (else enabled)
            if (Properties.Settings.Default.gamespeed == 1)
            {
                btn_gameSpeedApply.Enabled = false;
            }
            else
            {
                btn_gameSpeedApply.Enabled = true;
            }
        }

        private void rdB_speedNormal_CheckedChanged(object sender, EventArgs e)
        {
            //When the user already applied a setting the apply-button should get disabled (else enabled)
            if (Properties.Settings.Default.gamespeed == 2)
            {
                btn_gameSpeedApply.Enabled = false;
            }
            else
            {
                btn_gameSpeedApply.Enabled = true;
            }
        }

        private void rdB_speedFast_CheckedChanged(object sender, EventArgs e)
        {
            //When the user already applied a setting the apply-button should get disabled (else enabled)
            if (Properties.Settings.Default.gamespeed == 3)
            {
                btn_gameSpeedApply.Enabled = false;
            }
            else
            {
                btn_gameSpeedApply.Enabled = true;
            }
        }

        private void btn_speedApply_Click(object sender, EventArgs e)
        {
            //When checked a specific box the gamespeed applies (slow, normal or fast)
            if (rdB_gameSpeedSlow.Checked == true)
            {
                Properties.Settings.Default.gamespeed = 1;
            }
            if (rdB_gameSpeedNormal.Checked == true)
            {
                Properties.Settings.Default.gamespeed = 2;
            }
            if (rdB_gameSpeedFast.Checked == true)
            {
                Properties.Settings.Default.gamespeed = 3;
            }
            //Showing up error if you didnt checked any box
            else if (rdB_gameSpeedSlow.Checked == false && rdB_gameSpeedNormal.Checked == false && rdB_gameSpeedFast.Checked == false)
            {
                lbl_gamespeed.Text = "Please select your gamespeed!";
                lbl_gamespeed.ForeColor = Color.Red;
            }

            //Disbaling the apply-button
            btn_gameSpeedApply.Enabled = false;
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_Visible_False();

            //Setting clientsize for menuitem "Color"
            ClientSize = new Size(350, 280);

            //Getting the color from the properties
            string color = Properties.Settings.Default.stringBackcolor;

            //Defaultsettings (when you are new at the game)
            if (color == "None")
            {
                color = "";
            }

            //Setting the combobox-text
            cBox_color.Text = color;

            if (cBox_color.Text != "")
            {
                //When the text isnt empty then the apply-button should get disabled
                btn_colorApply.Enabled = false;

                SwitchCase_Backcolors();
            }

            //Visualise all items from the menuitem "Color"
            lbl_color.Visible = true;
            lbl_colorPreview.Visible = true;
            cBox_color.Visible = true;
            pBox_colorPreview.Visible = true;
            btn_colorApply.Visible = true;

            lbl_color.ForeColor = Color.Black;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string background = cBox_color.Text;

            SwitchCase_Backcolors();

            if (background == Properties.Settings.Default.stringBackcolor)
            {
                //When the combobox-text equals to the last color in the properties the apply-button gets disabled
                btn_colorApply.Enabled = false;
            }
            else
            {
                //Else the apply-button gets enabled
                btn_colorApply.Enabled = true;
            }
        }

        private void btn_colorApply_Click(object sender, EventArgs e)
        {
            string background = cBox_color.Text;

            if (cBox_color.Text != "")
            {
                //When the text isnt empty the properties change and apply-button gets disabled
                Properties.Settings.Default.stringBackcolor = background;
                btn_colorApply.Enabled = false;

                SwitchCase_Backcolors();
            }
            else
            {
                //The text above should light up in red when the text is empty
                lbl_gamespeed.Text = "Please select your color!";
                lbl_color.ForeColor = Color.Red;
            }
        }

        private void SwitchCase_Backcolors()
        {
            //Switch-Case for the different cases (setting preview color and writing the color in to the properties)
            string background = cBox_color.Text;

            switch (background)
            {
                case "Endstone":
                    pBox_colorPreview.BackColor = Color.FromArgb(251, 251, 210);
                    Properties.Settings.Default.colorBackcolor = Color.FromArgb(251, 251, 210);
                    break;

                case "Stone":
                    pBox_colorPreview.BackColor = Color.FromArgb(117, 116, 117);
                    Properties.Settings.Default.colorBackcolor = Color.FromArgb(117, 116, 117);
                    break;

                case "Mushroom":
                    pBox_colorPreview.BackColor = Color.FromArgb(187, 40, 41);
                    Properties.Settings.Default.colorBackcolor = Color.FromArgb(187, 40, 41);
                    break;

                case "Leaves":
                    pBox_colorPreview.BackColor = Color.FromArgb(72, 165, 46);
                    Properties.Settings.Default.colorBackcolor = Color.FromArgb(72, 165, 46);
                    break;

                case "Diamond":
                    pBox_colorPreview.BackColor = Color.FromArgb(104, 222, 218);
                    Properties.Settings.Default.colorBackcolor = Color.FromArgb(104, 222, 218);
                    break;

                case "Netherite":
                    pBox_colorPreview.BackColor = Color.FromArgb(63, 59, 62);
                    Properties.Settings.Default.colorBackcolor = Color.FromArgb(63, 59, 62);
                    break;

                case "Obsidian":
                    pBox_colorPreview.BackColor = Color.FromArgb(50, 38, 69);
                    Properties.Settings.Default.colorBackcolor = Color.FromArgb(50, 38, 69);
                    break;
            }
        }

        private void gamemodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_Visible_False();

            ClientSize = new Size(290, 380);

            //By getting the speed from the properties the radiobuttons match to that (example: if the gamemode is "Walls" the radiobutton should be checked on "Walls")
            if (Properties.Settings.Default.gamemode == 1)
            {
                rdB_gamemodeNormal.Checked = true;
            }
            else if (Properties.Settings.Default.gamemode == 2)
            {
                rdB_gamemodeWalls.Checked = true;
            }
            else if (Properties.Settings.Default.gamemode == 3)
            {
                rdB_gamemodeAddedTreats.Checked = true;
            }
            else if (Properties.Settings.Default.gamemode == 4)
            {
                rdB_gamemodeImmortality.Checked = true;
            }
            else
            {
                //Default when you are new
                rdB_gameSpeedSlow.Checked = false;
                rdB_gameSpeedNormal.Checked = false;
                rdB_gameSpeedFast.Checked = false;
                rdB_gamemodeImmortality.Checked = false;
            }

            //Visualising all items in "Gamemode"
            lbl_gamemode.Visible = true;
            lbl_gamemodePreview.Visible = true;
            rdB_gamemodeNormal.Visible = true;
            rdB_gamemodeWalls.Visible = true;
            rdB_gamemodeAddedTreats.Visible = true;
            rdB_gamemodeImmortality.Visible = true;
            pBox_gamemodePreview.Visible = true;
            btn_gamemodeApply.Visible = true;

            lbl_gamemode.ForeColor = Color.Black;
        }

        private void btn_gamemodeApply_Click(object sender, EventArgs e)
        {
            //When checked a specific box the gamespeed applies (slow, normal or fast)
            if (rdB_gamemodeNormal.Checked == true)
            {
                Properties.Settings.Default.gamemode = 1;
            }
            else if (rdB_gamemodeWalls.Checked == true)
            {
                Properties.Settings.Default.gamemode = 2;
            }
            else if (rdB_gamemodeAddedTreats.Checked == true)
            {
                Properties.Settings.Default.gamemode = 3;
            }
            else if (rdB_gamemodeImmortality.Checked == true)
            {
                Properties.Settings.Default.gamemode = 4;
            }
            //Showing up error if you didnt checked any box
            else if (rdB_gamemodeNormal.Checked == false && rdB_gamemodeWalls.Checked == false && rdB_gamemodeAddedTreats.Checked == false && rdB_gamemodeImmortality.Checked == false)
            {
                lbl_gamespeed.Text = "Please select your gamemode!";
                lbl_gamespeed.ForeColor = Color.Red;
            }
        }

        private void rdB_gamemodeNormal_CheckedChanged(object sender, EventArgs e)
        {
            //When the user already applied a setting the apply-button should get disabled (else enabled)
            if (Properties.Settings.Default.gamemode == 1)
            {
                btn_gamemodeApply.Enabled = false;
            }
            else
            {
                btn_gamemodeApply.Enabled = true;
            }
        }

        private void rdB_gamemodeWalls_CheckedChanged(object sender, EventArgs e)
        {
            //When the user already applied a setting the apply-button should get disabled (else enabled)
            if (Properties.Settings.Default.gamemode == 2)
            {
                btn_gamemodeApply.Enabled = false;
            }
            else
            {
                btn_gamemodeApply.Enabled = true;
            }
        }

        private void rdB_gamemodeAddedTreats_CheckedChanged(object sender, EventArgs e)
        {
            //When the user already applied a setting the apply-button should get disabled (else enabled)
            if (Properties.Settings.Default.gamemode == 3)
            {
                btn_gamemodeApply.Enabled = false;
            }
            else
            {
                btn_gamemodeApply.Enabled = true;
            }
        }

        private void rdB_gamemodeImmortality_CheckedChanged(object sender, EventArgs e)
        {
            //When the user already applied a setting the apply-button should get disabled (else enabled)
            if (Properties.Settings.Default.gamemode == 4)
            {
                btn_gamemodeApply.Enabled = false;
            }
            else
            {
                btn_gamemodeApply.Enabled = true;
            }
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save_Settings();

            //By starting the game the game shows up
            new blackdragon_game().Show();
            this.Hide();
        }

        private void Set_Visible_False()
        {
            //All items are getting invisible so it is easier to show specific items
            lbl_gamespeed.Visible = false;
            pBox_gamespeed.Visible = false;
            rdB_gameSpeedSlow.Visible = false;
            rdB_gameSpeedNormal.Visible = false;
            rdB_gameSpeedFast.Visible = false;
            btn_gameSpeedApply.Visible = false;

            lbl_color.Visible = false;
            lbl_colorPreview.Visible = false;
            cBox_color.Visible = false;
            pBox_colorPreview.Visible = false;
            btn_colorApply.Visible = false;

            pBox_instructionsControls.Visible = false;
            pBox_instructionsGoal.Visible = false;
            lbl_instructionsGoal.Visible = false;
            lbl_instructionsGoalTxt.Visible = false;
            lbl_instructionsControls.Visible = false;
            lbl_instructionsControlsTxt.Visible = false;
            lbl_instructionsGamemode.Visible = false;
            lbl_instructionsGamemodeTxt.Visible = false;
            cBox_instructions.Visible = false;

            lbl_gamemode.Visible = false;
            lbl_gamemodePreview.Visible = false;
            rdB_gamemodeNormal.Visible = false;
            rdB_gamemodeWalls.Visible = false;
            rdB_gamemodeAddedTreats.Visible = false;
            rdB_gamemodeImmortality.Visible = false;
            pBox_gamemodePreview.Visible = false;
            btn_gamemodeApply.Visible = false;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //By clicking on the category slow (under "Wall of Scores") the highscore-list from its category appears
            new highscore_listSlow().Show();
            this.Hide();
        }

        private void wallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //By clicking on the category normal (under "Wall of Scores") the highscore-list from its category appears
            new highscore_listNormal().Show();
            this.Hide();
        }

        private void added_treatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //By clicking on the category fast (under "Wall of Scores") the highscore-list from its category appears
            new highscore_listFast().Show();
            this.Hide();
        }

        private void immortalityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //By clicking on the category fast (under "Wall of Scores") the highscore-list from its category appears
            new highscore_listFast().Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save_Settings();

            //By pressing "Exit" in the menu the program closes entirely
            Environment.Exit(0);
        }

        private void blackdragon_interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save_Settings();

            //By closing the window the program closes entirely
            Environment.Exit(0);
        }

        private void Save_Settings()
        {
            //Getting username (for playersettings)
            string[] datas = File.ReadAllText(settings + @"\temp.txt").Split(';');

            string username = datas[0];

            //Getting routes
            string playerDirectory = saves + @"\" + username;
            string playerSettings = playerDirectory + @"\settings.txt";

            //Saving properties
            Properties.Settings.Default.Save();

            //Writing into the players settings its backcolor and speed (for remembering the players last settings)
            File.WriteAllText(playerSettings, Properties.Settings.Default.gamespeed.ToString() + ";" + Properties.Settings.Default.gamemode.ToString() + ";" + Properties.Settings.Default.stringBackcolor);
        }
    }
}
