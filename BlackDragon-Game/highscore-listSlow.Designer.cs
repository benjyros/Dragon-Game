
namespace BlackDragon_Game
{
    partial class highscore_listSlow
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
            this.tlp_list = new System.Windows.Forms.TableLayoutPanel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_bestenliste = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tlp_list
            // 
            this.tlp_list.BackColor = System.Drawing.Color.LightCyan;
            this.tlp_list.ColumnCount = 3;
            this.tlp_list.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_list.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlp_list.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlp_list.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlp_list.Location = new System.Drawing.Point(85, 54);
            this.tlp_list.Margin = new System.Windows.Forms.Padding(2);
            this.tlp_list.Name = "tlp_list";
            this.tlp_list.RowCount = 10;
            this.tlp_list.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_list.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_list.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_list.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_list.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_list.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_list.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_list.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_list.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_list.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_list.Size = new System.Drawing.Size(284, 281);
            this.tlp_list.TabIndex = 12;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(401, 160);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(77, 33);
            this.btn_refresh.TabIndex = 11;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_bestenliste
            // 
            this.lbl_bestenliste.AutoSize = true;
            this.lbl_bestenliste.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bestenliste.ForeColor = System.Drawing.Color.White;
            this.lbl_bestenliste.Location = new System.Drawing.Point(172, 13);
            this.lbl_bestenliste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bestenliste.Name = "lbl_bestenliste";
            this.lbl_bestenliste.Size = new System.Drawing.Size(126, 22);
            this.lbl_bestenliste.TabIndex = 10;
            this.lbl_bestenliste.Text = "Wall of Scores";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(432, 350);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(49, 23);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // highscore_listSlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(487, 379);
            this.Controls.Add(this.tlp_list);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.lbl_bestenliste);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "highscore_listSlow";
            this.Text = "Wall of Scores / Slow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.highscore_listSlow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_list;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_bestenliste;
        private System.Windows.Forms.Button btn_exit;
    }
}