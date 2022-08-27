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
    public partial class user_registration : Form
    {
        string baseRoute = "";
        string saves = "";
        string settings = "";

        public user_registration()
        {
            InitializeComponent();
            Get_BaseRoute();
        }

        private void Get_BaseRoute()
        {
            baseRoute = Path.GetFullPath(Environment.CurrentDirectory);
            saves = baseRoute + @"\saves";
            settings = baseRoute + @"\settings";
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            //Getting the contents of the textboxes
            string username = txtBox_username.Text;
            string password1 = txtBox_password1.Text;
            string password2 = txtBox_password2.Text;

            //Defining directory where the profile should be saved
            string playerDirectory = saves + @"\" + username;

            //Checking if theres any content in the textboxes
            if (txtBox_username.Text != "" && txtBox_password1.Text != "" && txtBox_password2.Text != "")
            {
                //If the first password matches with second one it will check if there is already a profile with the same username
                if (password1 == password2)
                {
                    //A messagebox will appear if there is already a profile with the same username
                    if (Directory.Exists(playerDirectory))
                    {
                        MessageBox.Show("Username already exists!\n\rPlease enter another username.");

                        //Clearing the contents of the textboxes
                        txtBox_username.Clear();
                        txtBox_password1.Clear();
                        txtBox_password2.Clear();
                    }
                    //If there isnt any problem the saving-event will run
                    else
                    {
                        Save_File();
                    }
                }
                //If those two passwords dont match a messagebox will appear (and clears the contents of the textboxes)
                else
                {
                    MessageBox.Show("Passwords do not match!\n\rPlease try again!");

                    txtBox_username.Clear();
                    txtBox_password1.Clear();
                    txtBox_password2.Clear();
                }
            }
            //If there are missing gaps a messagebox will appear
            else
            {
                MessageBox.Show("Please fill up the missing gaps!");
            }
        }

        private void Save_File()
        {
            //Getting username and password for string
            string username = txtBox_username.Text;
            string password = txtBox_password1.Text;

            //Defining directories
            string playerDirectory = saves + @"\" + username;
            string playerInfo = playerDirectory + @"\playerinfo.txt";
            string playerScore = playerDirectory + @"\scores.txt";
            string playerSettings = playerDirectory + @"\settings.txt";
            string temp = settings + @"\temp.txt";

            try
            {
                //Creating new directory for user
                Directory.CreateDirectory(playerDirectory);
                //Using streamwriter to create three new files (playerinfo, score and settings)
                StreamWriter newFile1 = new StreamWriter(playerInfo);
                StreamWriter newFile2 = new StreamWriter(playerScore);
                StreamWriter newFile3 = new StreamWriter(playerSettings);

                //Writing the username and password into the playerinfo and gamespeed + backcolor into playersettings
                newFile1.Write(username + ";" + password);
                newFile2.Write("");
                newFile3.Write("0;0;None");
                //Closing those two new files
                newFile1.Close();
                newFile2.Close();
                newFile3.Close();

                //Setting the properties to its default values
                Properties.Settings.Default.gamespeed = 0;
                Properties.Settings.Default.gamemode = 0;
                Properties.Settings.Default.stringBackcolor = "None";

                //Writing into the temp-file the userdatas
                File.WriteAllText(temp, username + ";" + password);
            }
            //If there is an unexpected error a messagebox will appear with that specific error
            catch (IOException ce)
            {
                MessageBox.Show("An error has occured!" + ce.Message);

                txtBox_username.Clear();
                txtBox_password1.Clear();
                txtBox_password2.Clear();
            }
            //If there were no errors in the process a messagebox will appear with confirmation that the registration was successful
            finally
            {
                MessageBox.Show("Registration was successful!");

                //Saving the properties
                Properties.Settings.Default.Save();

                //The gameinterface will show up after that
                new blackdragon_interface().Show();
                this.Hide();

                //Clearing contents
                txtBox_username.Clear();
                txtBox_password1.Clear();
                txtBox_password2.Clear();
            }
        }

        private void llbl_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //When clicked on the link the user login will show up (also clearing those contents)
            new user_login().Show();
            this.Hide();
        }

        private void llbl_back_MouseEnter(object sender, EventArgs e)
        {
            //By entering the "link-zone" the linkcolor changes to lightsteelblue
            llbl_back.LinkColor = Color.LightSteelBlue;
        }

        private void llbl_back_MouseLeave(object sender, EventArgs e)
        {
            //By leaving the "link-zone" the linkcolor changes back to blue
            llbl_back.LinkColor = Color.Blue;
        }

        private void user_registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Closes the programm (so it doesnt run in the background)
            Environment.Exit(0);
        }
    }
}
