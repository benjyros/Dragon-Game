
namespace BlackDragon_Game
{
    partial class user_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_userLogin = new System.Windows.Forms.Label();
            this.pnl_username = new System.Windows.Forms.Panel();
            this.txtBox_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.pnl_password = new System.Windows.Forms.Panel();
            this.btn_signIn = new System.Windows.Forms.Button();
            this.llbl_signUp = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_userLogin
            // 
            this.lbl_userLogin.AutoSize = true;
            this.lbl_userLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userLogin.Location = new System.Drawing.Point(73, 44);
            this.lbl_userLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_userLogin.Name = "lbl_userLogin";
            this.lbl_userLogin.Size = new System.Drawing.Size(209, 36);
            this.lbl_userLogin.TabIndex = 0;
            this.lbl_userLogin.Text = "USER LOGIN";
            // 
            // pnl_username
            // 
            this.pnl_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_username.Location = new System.Drawing.Point(20, 178);
            this.pnl_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_username.Name = "pnl_username";
            this.pnl_username.Size = new System.Drawing.Size(346, 1);
            this.pnl_username.TabIndex = 1;
            // 
            // txtBox_username
            // 
            this.txtBox_username.BackColor = System.Drawing.SystemColors.Control;
            this.txtBox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_username.Location = new System.Drawing.Point(20, 155);
            this.txtBox_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_username.Name = "txtBox_username";
            this.txtBox_username.Size = new System.Drawing.Size(347, 15);
            this.txtBox_username.TabIndex = 2;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(28, 124);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(73, 17);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(28, 233);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(69, 17);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Password";
            // 
            // txtBox_password
            // 
            this.txtBox_password.BackColor = System.Drawing.SystemColors.Control;
            this.txtBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_password.Location = new System.Drawing.Point(20, 258);
            this.txtBox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.PasswordChar = '*';
            this.txtBox_password.Size = new System.Drawing.Size(347, 15);
            this.txtBox_password.TabIndex = 5;
            // 
            // pnl_password
            // 
            this.pnl_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_password.Location = new System.Drawing.Point(20, 282);
            this.pnl_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_password.Name = "pnl_password";
            this.pnl_password.Size = new System.Drawing.Size(346, 1);
            this.pnl_password.TabIndex = 4;
            // 
            // btn_signIn
            // 
            this.btn_signIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signIn.Location = new System.Drawing.Point(263, 342);
            this.btn_signIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(104, 39);
            this.btn_signIn.TabIndex = 7;
            this.btn_signIn.Text = "Sign In";
            this.btn_signIn.UseVisualStyleBackColor = true;
            this.btn_signIn.Click += new System.EventHandler(this.btn_signIn_Click);
            // 
            // llbl_signUp
            // 
            this.llbl_signUp.AutoSize = true;
            this.llbl_signUp.Location = new System.Drawing.Point(16, 356);
            this.llbl_signUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_signUp.Name = "llbl_signUp";
            this.llbl_signUp.Size = new System.Drawing.Size(58, 17);
            this.llbl_signUp.TabIndex = 9;
            this.llbl_signUp.TabStop = true;
            this.llbl_signUp.Text = "Sign Up";
            this.llbl_signUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.llbl_signUp.MouseEnter += new System.EventHandler(this.llbl_signUp_MouseEnter);
            this.llbl_signUp.MouseLeave += new System.EventHandler(this.llbl_signUp_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // user_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 416);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llbl_signUp);
            this.Controls.Add(this.btn_signIn);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txtBox_password);
            this.Controls.Add(this.pnl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txtBox_username);
            this.Controls.Add(this.pnl_username);
            this.Controls.Add(this.lbl_userLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "user_login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_userLogin;
        private System.Windows.Forms.Panel pnl_username;
        private System.Windows.Forms.TextBox txtBox_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.Panel pnl_password;
        private System.Windows.Forms.Button btn_signIn;
        private System.Windows.Forms.LinkLabel llbl_signUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

