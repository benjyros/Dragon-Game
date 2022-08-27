
namespace BlackDragon_Game
{
    partial class user_registration
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
            this.components = new System.ComponentModel.Container();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.llbl_back = new System.Windows.Forms.LinkLabel();
            this.lbl_password1 = new System.Windows.Forms.Label();
            this.txtBox_password1 = new System.Windows.Forms.TextBox();
            this.pnl_password1 = new System.Windows.Forms.Panel();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txtBox_username = new System.Windows.Forms.TextBox();
            this.pnl_username = new System.Windows.Forms.Panel();
            this.lbl_signUp = new System.Windows.Forms.Label();
            this.lbl_password2 = new System.Windows.Forms.Label();
            this.txtBox_password2 = new System.Windows.Forms.TextBox();
            this.pnl_password2 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_signUp
            // 
            this.btn_signUp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signUp.Location = new System.Drawing.Point(263, 434);
            this.btn_signUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(104, 39);
            this.btn_signUp.TabIndex = 8;
            this.btn_signUp.Text = "Sign Up";
            this.btn_signUp.UseVisualStyleBackColor = true;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // llbl_back
            // 
            this.llbl_back.AutoSize = true;
            this.llbl_back.Location = new System.Drawing.Point(16, 448);
            this.llbl_back.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_back.Name = "llbl_back";
            this.llbl_back.Size = new System.Drawing.Size(39, 17);
            this.llbl_back.TabIndex = 17;
            this.llbl_back.TabStop = true;
            this.llbl_back.Text = "Back";
            this.llbl_back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_back_LinkClicked);
            this.llbl_back.MouseEnter += new System.EventHandler(this.llbl_back_MouseEnter);
            this.llbl_back.MouseLeave += new System.EventHandler(this.llbl_back_MouseLeave);
            // 
            // lbl_password1
            // 
            this.lbl_password1.AutoSize = true;
            this.lbl_password1.Location = new System.Drawing.Point(24, 228);
            this.lbl_password1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password1.Name = "lbl_password1";
            this.lbl_password1.Size = new System.Drawing.Size(69, 17);
            this.lbl_password1.TabIndex = 16;
            this.lbl_password1.Text = "Password";
            // 
            // txtBox_password1
            // 
            this.txtBox_password1.BackColor = System.Drawing.SystemColors.Control;
            this.txtBox_password1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_password1.Location = new System.Drawing.Point(16, 254);
            this.txtBox_password1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_password1.Name = "txtBox_password1";
            this.txtBox_password1.PasswordChar = '*';
            this.txtBox_password1.Size = new System.Drawing.Size(347, 15);
            this.txtBox_password1.TabIndex = 15;
            // 
            // pnl_password1
            // 
            this.pnl_password1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_password1.Location = new System.Drawing.Point(16, 277);
            this.pnl_password1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_password1.Name = "pnl_password1";
            this.pnl_password1.Size = new System.Drawing.Size(346, 1);
            this.pnl_password1.TabIndex = 14;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(24, 119);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(73, 17);
            this.lbl_username.TabIndex = 13;
            this.lbl_username.Text = "Username";
            // 
            // txtBox_username
            // 
            this.txtBox_username.BackColor = System.Drawing.SystemColors.Control;
            this.txtBox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_username.Location = new System.Drawing.Point(16, 150);
            this.txtBox_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_username.Name = "txtBox_username";
            this.txtBox_username.Size = new System.Drawing.Size(347, 15);
            this.txtBox_username.TabIndex = 12;
            // 
            // pnl_username
            // 
            this.pnl_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_username.Location = new System.Drawing.Point(16, 174);
            this.pnl_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_username.Name = "pnl_username";
            this.pnl_username.Size = new System.Drawing.Size(346, 1);
            this.pnl_username.TabIndex = 11;
            // 
            // lbl_signUp
            // 
            this.lbl_signUp.AutoSize = true;
            this.lbl_signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signUp.Location = new System.Drawing.Point(105, 38);
            this.lbl_signUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_signUp.Name = "lbl_signUp";
            this.lbl_signUp.Size = new System.Drawing.Size(145, 36);
            this.lbl_signUp.TabIndex = 10;
            this.lbl_signUp.Text = "SIGN UP";
            // 
            // lbl_password2
            // 
            this.lbl_password2.AutoSize = true;
            this.lbl_password2.Location = new System.Drawing.Point(24, 336);
            this.lbl_password2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password2.Name = "lbl_password2";
            this.lbl_password2.Size = new System.Drawing.Size(118, 17);
            this.lbl_password2.TabIndex = 20;
            this.lbl_password2.Text = "Repeat password";
            // 
            // txtBox_password2
            // 
            this.txtBox_password2.BackColor = System.Drawing.SystemColors.Control;
            this.txtBox_password2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_password2.Location = new System.Drawing.Point(16, 362);
            this.txtBox_password2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_password2.Name = "txtBox_password2";
            this.txtBox_password2.PasswordChar = '*';
            this.txtBox_password2.Size = new System.Drawing.Size(347, 15);
            this.txtBox_password2.TabIndex = 19;
            // 
            // pnl_password2
            // 
            this.pnl_password2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_password2.Location = new System.Drawing.Point(16, 385);
            this.pnl_password2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_password2.Name = "pnl_password2";
            this.pnl_password2.Size = new System.Drawing.Size(346, 1);
            this.pnl_password2.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // user_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 492);
            this.Controls.Add(this.lbl_password2);
            this.Controls.Add(this.txtBox_password2);
            this.Controls.Add(this.pnl_password2);
            this.Controls.Add(this.llbl_back);
            this.Controls.Add(this.lbl_password1);
            this.Controls.Add(this.txtBox_password1);
            this.Controls.Add(this.pnl_password1);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txtBox_username);
            this.Controls.Add(this.pnl_username);
            this.Controls.Add(this.lbl_signUp);
            this.Controls.Add(this.btn_signUp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "user_registration";
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.user_registration_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.LinkLabel llbl_back;
        private System.Windows.Forms.Label lbl_password1;
        private System.Windows.Forms.TextBox txtBox_password1;
        private System.Windows.Forms.Panel pnl_password1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txtBox_username;
        private System.Windows.Forms.Panel pnl_username;
        private System.Windows.Forms.Label lbl_signUp;
        private System.Windows.Forms.Label lbl_password2;
        private System.Windows.Forms.TextBox txtBox_password2;
        private System.Windows.Forms.Panel pnl_password2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}