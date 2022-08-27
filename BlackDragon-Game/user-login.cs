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
    public partial class user_login : Form
    {
        string baseRoute = "";
        string saves = "";
        string settings = "";

        public user_login()
        {
            InitializeComponent();
            Get_Routes();
        }

        private void Get_Routes()
        {
            baseRoute = Path.GetFullPath(Environment.CurrentDirectory);
            saves = baseRoute + @"\saves";
            settings = baseRoute + @"\settings";
        }

        private void Check_Files()
        {
            //Getting the contents of the textboxes
            string username = txtBox_username.Text;
            string password = txtBox_password.Text;

            //Defining directories
            string playerDirectory = saves + @"\" + username;
            string playerInfo = playerDirectory + @"\playerinfo.txt";
            string playerSettings = playerDirectory + @"\settings.txt";
            string temp = settings + @"\temp.txt";

            //Checking if the player even exists
            if (Directory.Exists(playerDirectory))
            {
                try
                {
                    //Reading the profile-userfile
                    string[] data = File.ReadAllText(playerInfo).Split(';');

                    //If the password doesnt match a messagebox will show up
                    if (data[0] != username || data[1] != password)
                    {
                        MessageBox.Show("Password incorrect!\n\rPlease try again!");

                        //Clearing the content of the textboxes
                        txtBox_username.Clear();
                        txtBox_password.Clear();
                    }
                    else
                    {
                        //If the password matches those dates get written into the temp-file
                        File.WriteAllText(temp, username + ";" + password);

                        //Setting the gamespped and stringBackcolor in the properties to a value from the player-settings-file
                        Properties.Settings.Default.gamespeed = Convert.ToInt32(File.ReadAllText(playerSettings).Split(';')[0]);
                        Properties.Settings.Default.gamemode = Convert.ToInt32(File.ReadAllText(playerSettings).Split(';')[1]);
                        Properties.Settings.Default.stringBackcolor = File.ReadAllText(playerSettings).Split(';')[2];

                        //Clearing the contents of the textboxes
                        txtBox_username.Clear();
                        txtBox_password.Clear();
                    }
                }
                //If there is an unexpected error it will write a messagebox with that error
                catch (Exception ce)
                {
                    MessageBox.Show("An error has occured!\n\r" + ce.Message);

                    txtBox_username.Clear();
                    txtBox_password.Clear();
                }
                finally
                {
                    //Saving the properties
                    Properties.Settings.Default.Save();

                    //After that the interface for the game will show up
                    new blackdragon_interface().Show();
                    this.Hide();
                }
            }
            //If the player doesnt exist an error will appear (in form of a messagebox)
            else
            {
                MessageBox.Show("Username doesn't exist!");

                //Clearing the content of the textboxes
                txtBox_username.Clear();
                txtBox_password.Clear();
            }
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            //Checking if theres any content in the textboxes
            if (txtBox_username.Text != "" && txtBox_password.Text != "")
            {
                Check_Files();
            }
            else
            {
                //Warning to write something into the textboxes
                MessageBox.Show("Please fill up the missing gaps!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //When clicked on the link the user registration will show up (also clearing those contents)
            new user_registration().Show();
            this.Hide();

            txtBox_username.Clear();
            txtBox_password.Clear();
        }

        private void llbl_signUp_MouseEnter(object sender, EventArgs e)
        {
            //By entering the "link-zone" the linkcolor changes to lightsteelblue
            llbl_signUp.LinkColor = Color.LightSteelBlue;
        }

        private void llbl_signUp_MouseLeave(object sender, EventArgs e)
        {
            //By leaving the "link-zone" the linkcolor changes back to blue
            llbl_signUp.LinkColor = Color.Blue;
        }
    }
}
