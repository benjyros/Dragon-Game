
namespace BlackDragon_Game
{
    partial class blackdragon_interface
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamemodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.slowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.immortalityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_gameSpeedApply = new System.Windows.Forms.Button();
            this.lbl_gamespeed = new System.Windows.Forms.Label();
            this.rdB_gameSpeedFast = new System.Windows.Forms.RadioButton();
            this.rdB_gameSpeedNormal = new System.Windows.Forms.RadioButton();
            this.rdB_gameSpeedSlow = new System.Windows.Forms.RadioButton();
            this.lbl_colorPreview = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.cBox_color = new System.Windows.Forms.ComboBox();
            this.btn_colorApply = new System.Windows.Forms.Button();
            this.lbl_instructionsGoal = new System.Windows.Forms.Label();
            this.lbl_instructionsGoalTxt = new System.Windows.Forms.Label();
            this.lbl_instructionsControls = new System.Windows.Forms.Label();
            this.lbl_instructionsControlsTxt = new System.Windows.Forms.Label();
            this.lbl_instructionsGamemode = new System.Windows.Forms.Label();
            this.cBox_instructions = new System.Windows.Forms.ComboBox();
            this.pBox_instructionsGoal = new System.Windows.Forms.PictureBox();
            this.pBox_instructionsControls = new System.Windows.Forms.PictureBox();
            this.pBox_colorPreview = new System.Windows.Forms.PictureBox();
            this.pBox_gamespeed = new System.Windows.Forms.PictureBox();
            this.lbl_instructionsGamemodeTxt = new System.Windows.Forms.Label();
            this.rdB_gamemodeNormal = new System.Windows.Forms.RadioButton();
            this.lbl_gamemode = new System.Windows.Forms.Label();
            this.rdB_gamemodeWalls = new System.Windows.Forms.RadioButton();
            this.rdB_gamemodeAddedTreats = new System.Windows.Forms.RadioButton();
            this.rdB_gamemodeImmortality = new System.Windows.Forms.RadioButton();
            this.pBox_gamemodePreview = new System.Windows.Forms.PictureBox();
            this.lbl_gamemodePreview = new System.Windows.Forms.Label();
            this.btn_gamemodeApply = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_instructionsGoal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_instructionsControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_colorPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_gamespeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_gamemodePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(409, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speedToolStripMenuItem,
            this.colourToolStripMenuItem,
            this.gamemodeToolStripMenuItem,
            this.startGameToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 24);
            this.toolStripMenuItem1.Text = "Game";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.speedToolStripMenuItem.Text = "Speed";
            this.speedToolStripMenuItem.Click += new System.EventHandler(this.speedToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.colourToolStripMenuItem.Text = "Colour";
            this.colourToolStripMenuItem.Click += new System.EventHandler(this.colourToolStripMenuItem_Click);
            // 
            // gamemodeToolStripMenuItem
            // 
            this.gamemodeToolStripMenuItem.Name = "gamemodeToolStripMenuItem";
            this.gamemodeToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.gamemodeToolStripMenuItem.Text = "Gamemode";
            this.gamemodeToolStripMenuItem.Click += new System.EventHandler(this.gamemodeToolStripMenuItem_Click);
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.startGameToolStripMenuItem.Text = "Start Game";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.startGameToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slowToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.fastToolStripMenuItem,
            this.immortalityToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(117, 24);
            this.toolStripMenuItem2.Text = "Wall of Scores";
            // 
            // slowToolStripMenuItem
            // 
            this.slowToolStripMenuItem.Name = "slowToolStripMenuItem";
            this.slowToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.slowToolStripMenuItem.Text = "Normal";
            this.slowToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.normalToolStripMenuItem.Text = "Walls";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.wallsToolStripMenuItem_Click);
            // 
            // fastToolStripMenuItem
            // 
            this.fastToolStripMenuItem.Name = "fastToolStripMenuItem";
            this.fastToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fastToolStripMenuItem.Text = "Added Treats";
            this.fastToolStripMenuItem.Click += new System.EventHandler(this.added_treatsToolStripMenuItem_Click);
            // 
            // immortalityToolStripMenuItem
            // 
            this.immortalityToolStripMenuItem.Name = "immortalityToolStripMenuItem";
            this.immortalityToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.immortalityToolStripMenuItem.Text = "Immortality";
            this.immortalityToolStripMenuItem.Click += new System.EventHandler(this.immortalityToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btn_gameSpeedApply
            // 
            this.btn_gameSpeedApply.Location = new System.Drawing.Point(373, 166);
            this.btn_gameSpeedApply.Name = "btn_gameSpeedApply";
            this.btn_gameSpeedApply.Size = new System.Drawing.Size(108, 33);
            this.btn_gameSpeedApply.TabIndex = 4;
            this.btn_gameSpeedApply.Text = "Apply";
            this.btn_gameSpeedApply.UseVisualStyleBackColor = true;
            this.btn_gameSpeedApply.Visible = false;
            this.btn_gameSpeedApply.Click += new System.EventHandler(this.btn_speedApply_Click);
            // 
            // lbl_gamespeed
            // 
            this.lbl_gamespeed.AutoSize = true;
            this.lbl_gamespeed.Location = new System.Drawing.Point(157, 72);
            this.lbl_gamespeed.Name = "lbl_gamespeed";
            this.lbl_gamespeed.Size = new System.Drawing.Size(157, 17);
            this.lbl_gamespeed.TabIndex = 5;
            this.lbl_gamespeed.Text = "Select your gamespeed";
            this.lbl_gamespeed.Visible = false;
            // 
            // rdB_gameSpeedFast
            // 
            this.rdB_gameSpeedFast.AutoSize = true;
            this.rdB_gameSpeedFast.Location = new System.Drawing.Point(204, 229);
            this.rdB_gameSpeedFast.Name = "rdB_gameSpeedFast";
            this.rdB_gameSpeedFast.Size = new System.Drawing.Size(52, 21);
            this.rdB_gameSpeedFast.TabIndex = 3;
            this.rdB_gameSpeedFast.Text = "fast";
            this.rdB_gameSpeedFast.UseVisualStyleBackColor = true;
            this.rdB_gameSpeedFast.Visible = false;
            this.rdB_gameSpeedFast.CheckedChanged += new System.EventHandler(this.rdB_speedFast_CheckedChanged);
            // 
            // rdB_gameSpeedNormal
            // 
            this.rdB_gameSpeedNormal.AutoSize = true;
            this.rdB_gameSpeedNormal.Location = new System.Drawing.Point(204, 172);
            this.rdB_gameSpeedNormal.Name = "rdB_gameSpeedNormal";
            this.rdB_gameSpeedNormal.Size = new System.Drawing.Size(72, 21);
            this.rdB_gameSpeedNormal.TabIndex = 2;
            this.rdB_gameSpeedNormal.Text = "normal";
            this.rdB_gameSpeedNormal.UseVisualStyleBackColor = true;
            this.rdB_gameSpeedNormal.Visible = false;
            this.rdB_gameSpeedNormal.CheckedChanged += new System.EventHandler(this.rdB_speedNormal_CheckedChanged);
            // 
            // rdB_gameSpeedSlow
            // 
            this.rdB_gameSpeedSlow.AutoSize = true;
            this.rdB_gameSpeedSlow.Checked = true;
            this.rdB_gameSpeedSlow.Location = new System.Drawing.Point(204, 112);
            this.rdB_gameSpeedSlow.Name = "rdB_gameSpeedSlow";
            this.rdB_gameSpeedSlow.Size = new System.Drawing.Size(56, 21);
            this.rdB_gameSpeedSlow.TabIndex = 1;
            this.rdB_gameSpeedSlow.TabStop = true;
            this.rdB_gameSpeedSlow.Text = "slow";
            this.rdB_gameSpeedSlow.UseVisualStyleBackColor = true;
            this.rdB_gameSpeedSlow.Visible = false;
            this.rdB_gameSpeedSlow.CheckedChanged += new System.EventHandler(this.rdB_speedSlow_CheckedChanged);
            // 
            // lbl_colorPreview
            // 
            this.lbl_colorPreview.AutoSize = true;
            this.lbl_colorPreview.Location = new System.Drawing.Point(269, 72);
            this.lbl_colorPreview.Name = "lbl_colorPreview";
            this.lbl_colorPreview.Size = new System.Drawing.Size(61, 17);
            this.lbl_colorPreview.TabIndex = 10;
            this.lbl_colorPreview.Text = "Preview:";
            this.lbl_colorPreview.Visible = false;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(29, 72);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(114, 17);
            this.lbl_color.TabIndex = 9;
            this.lbl_color.Text = "Select your color";
            this.lbl_color.Visible = false;
            // 
            // cBox_color
            // 
            this.cBox_color.FormattingEnabled = true;
            this.cBox_color.Items.AddRange(new object[] {
            "Endstone",
            "Stone",
            "Mushroom",
            "Leaves",
            "Diamond",
            "Netherite",
            "Obsidian"});
            this.cBox_color.Location = new System.Drawing.Point(33, 111);
            this.cBox_color.Margin = new System.Windows.Forms.Padding(4);
            this.cBox_color.Name = "cBox_color";
            this.cBox_color.Size = new System.Drawing.Size(160, 24);
            this.cBox_color.TabIndex = 13;
            this.cBox_color.Visible = false;
            this.cBox_color.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_colorApply
            // 
            this.btn_colorApply.Location = new System.Drawing.Point(185, 269);
            this.btn_colorApply.Margin = new System.Windows.Forms.Padding(4);
            this.btn_colorApply.Name = "btn_colorApply";
            this.btn_colorApply.Size = new System.Drawing.Size(108, 33);
            this.btn_colorApply.TabIndex = 14;
            this.btn_colorApply.Text = "Apply";
            this.btn_colorApply.UseVisualStyleBackColor = true;
            this.btn_colorApply.Visible = false;
            this.btn_colorApply.Click += new System.EventHandler(this.btn_colorApply_Click);
            // 
            // lbl_instructionsGoal
            // 
            this.lbl_instructionsGoal.AutoSize = true;
            this.lbl_instructionsGoal.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instructionsGoal.Location = new System.Drawing.Point(354, 61);
            this.lbl_instructionsGoal.Name = "lbl_instructionsGoal";
            this.lbl_instructionsGoal.Size = new System.Drawing.Size(56, 19);
            this.lbl_instructionsGoal.TabIndex = 17;
            this.lbl_instructionsGoal.Text = "GOAL";
            this.lbl_instructionsGoal.Visible = false;
            // 
            // lbl_instructionsGoalTxt
            // 
            this.lbl_instructionsGoalTxt.AutoSize = true;
            this.lbl_instructionsGoalTxt.Location = new System.Drawing.Point(230, 88);
            this.lbl_instructionsGoalTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_instructionsGoalTxt.Name = "lbl_instructionsGoalTxt";
            this.lbl_instructionsGoalTxt.Size = new System.Drawing.Size(316, 34);
            this.lbl_instructionsGoalTxt.TabIndex = 18;
            this.lbl_instructionsGoalTxt.Text = "The goal is to collect as many enderdragon eggs\r\n as you can, to get the highest " +
    "score.";
            this.lbl_instructionsGoalTxt.Visible = false;
            // 
            // lbl_instructionsControls
            // 
            this.lbl_instructionsControls.AutoSize = true;
            this.lbl_instructionsControls.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instructionsControls.Location = new System.Drawing.Point(102, 163);
            this.lbl_instructionsControls.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_instructionsControls.Name = "lbl_instructionsControls";
            this.lbl_instructionsControls.Size = new System.Drawing.Size(94, 18);
            this.lbl_instructionsControls.TabIndex = 19;
            this.lbl_instructionsControls.Text = "CONTROLS";
            this.lbl_instructionsControls.Visible = false;
            // 
            // lbl_instructionsControlsTxt
            // 
            this.lbl_instructionsControlsTxt.AutoSize = true;
            this.lbl_instructionsControlsTxt.Location = new System.Drawing.Point(28, 188);
            this.lbl_instructionsControlsTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_instructionsControlsTxt.Name = "lbl_instructionsControlsTxt";
            this.lbl_instructionsControlsTxt.Size = new System.Drawing.Size(280, 34);
            this.lbl_instructionsControlsTxt.TabIndex = 20;
            this.lbl_instructionsControlsTxt.Text = "You can move horizontally and vertically by\r\n using the arrow-keys.";
            this.lbl_instructionsControlsTxt.Visible = false;
            // 
            // lbl_instructionsGamemode
            // 
            this.lbl_instructionsGamemode.AutoSize = true;
            this.lbl_instructionsGamemode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instructionsGamemode.Location = new System.Drawing.Point(39, 264);
            this.lbl_instructionsGamemode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_instructionsGamemode.Name = "lbl_instructionsGamemode";
            this.lbl_instructionsGamemode.Size = new System.Drawing.Size(108, 18);
            this.lbl_instructionsGamemode.TabIndex = 21;
            this.lbl_instructionsGamemode.Text = "GAMEMODES";
            this.lbl_instructionsGamemode.Visible = false;
            // 
            // cBox_instructions
            // 
            this.cBox_instructions.FormattingEnabled = true;
            this.cBox_instructions.Items.AddRange(new object[] {
            "Immortality",
            "Added Treats",
            "Walls"});
            this.cBox_instructions.Location = new System.Drawing.Point(161, 264);
            this.cBox_instructions.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_instructions.Name = "cBox_instructions";
            this.cBox_instructions.Size = new System.Drawing.Size(156, 24);
            this.cBox_instructions.TabIndex = 22;
            this.cBox_instructions.Visible = false;
            this.cBox_instructions.SelectedIndexChanged += new System.EventHandler(this.cBox_instructions_SelectedIndexChanged);
            // 
            // pBox_instructionsGoal
            // 
            this.pBox_instructionsGoal.Image = global::BlackDragon_Game.Properties.Resources.dragonEgg_new;
            this.pBox_instructionsGoal.Location = new System.Drawing.Point(81, 72);
            this.pBox_instructionsGoal.Margin = new System.Windows.Forms.Padding(2);
            this.pBox_instructionsGoal.Name = "pBox_instructionsGoal";
            this.pBox_instructionsGoal.Size = new System.Drawing.Size(83, 49);
            this.pBox_instructionsGoal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_instructionsGoal.TabIndex = 23;
            this.pBox_instructionsGoal.TabStop = false;
            this.pBox_instructionsGoal.Visible = false;
            // 
            // pBox_instructionsControls
            // 
            this.pBox_instructionsControls.BackColor = System.Drawing.SystemColors.Control;
            this.pBox_instructionsControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pBox_instructionsControls.Image = global::BlackDragon_Game.Properties.Resources.arrow_keys;
            this.pBox_instructionsControls.Location = new System.Drawing.Point(347, 157);
            this.pBox_instructionsControls.Name = "pBox_instructionsControls";
            this.pBox_instructionsControls.Size = new System.Drawing.Size(179, 84);
            this.pBox_instructionsControls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_instructionsControls.TabIndex = 16;
            this.pBox_instructionsControls.TabStop = false;
            this.pBox_instructionsControls.Visible = false;
            // 
            // pBox_colorPreview
            // 
            this.pBox_colorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_colorPreview.Location = new System.Drawing.Point(272, 112);
            this.pBox_colorPreview.Margin = new System.Windows.Forms.Padding(4);
            this.pBox_colorPreview.Name = "pBox_colorPreview";
            this.pBox_colorPreview.Size = new System.Drawing.Size(133, 122);
            this.pBox_colorPreview.TabIndex = 12;
            this.pBox_colorPreview.TabStop = false;
            this.pBox_colorPreview.Visible = false;
            // 
            // pBox_gamespeed
            // 
            this.pBox_gamespeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_gamespeed.Location = new System.Drawing.Point(161, 92);
            this.pBox_gamespeed.Margin = new System.Windows.Forms.Padding(4);
            this.pBox_gamespeed.Name = "pBox_gamespeed";
            this.pBox_gamespeed.Size = new System.Drawing.Size(153, 181);
            this.pBox_gamespeed.TabIndex = 6;
            this.pBox_gamespeed.TabStop = false;
            this.pBox_gamespeed.Visible = false;
            // 
            // lbl_instructionsGamemodeTxt
            // 
            this.lbl_instructionsGamemodeTxt.AutoSize = true;
            this.lbl_instructionsGamemodeTxt.Location = new System.Drawing.Point(44, 307);
            this.lbl_instructionsGamemodeTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_instructionsGamemodeTxt.Name = "lbl_instructionsGamemodeTxt";
            this.lbl_instructionsGamemodeTxt.Size = new System.Drawing.Size(144, 34);
            this.lbl_instructionsGamemodeTxt.TabIndex = 26;
            this.lbl_instructionsGamemodeTxt.Text = "choose a gamemode.\r\n\r\n";
            this.lbl_instructionsGamemodeTxt.Visible = false;
            // 
            // rdB_gamemodeNormal
            // 
            this.rdB_gamemodeNormal.AutoSize = true;
            this.rdB_gamemodeNormal.Location = new System.Drawing.Point(33, 126);
            this.rdB_gamemodeNormal.Name = "rdB_gamemodeNormal";
            this.rdB_gamemodeNormal.Size = new System.Drawing.Size(74, 21);
            this.rdB_gamemodeNormal.TabIndex = 27;
            this.rdB_gamemodeNormal.TabStop = true;
            this.rdB_gamemodeNormal.Text = "Normal";
            this.rdB_gamemodeNormal.UseVisualStyleBackColor = true;
            this.rdB_gamemodeNormal.Visible = false;
            this.rdB_gamemodeNormal.CheckedChanged += new System.EventHandler(this.rdB_gamemodeNormal_CheckedChanged);
            // 
            // lbl_gamemode
            // 
            this.lbl_gamemode.AutoSize = true;
            this.lbl_gamemode.Location = new System.Drawing.Point(28, 72);
            this.lbl_gamemode.Name = "lbl_gamemode";
            this.lbl_gamemode.Size = new System.Drawing.Size(153, 17);
            this.lbl_gamemode.TabIndex = 28;
            this.lbl_gamemode.Text = "Select your gamemode";
            this.lbl_gamemode.Visible = false;
            // 
            // rdB_gamemodeWalls
            // 
            this.rdB_gamemodeWalls.AutoSize = true;
            this.rdB_gamemodeWalls.Location = new System.Drawing.Point(34, 172);
            this.rdB_gamemodeWalls.Name = "rdB_gamemodeWalls";
            this.rdB_gamemodeWalls.Size = new System.Drawing.Size(63, 21);
            this.rdB_gamemodeWalls.TabIndex = 29;
            this.rdB_gamemodeWalls.TabStop = true;
            this.rdB_gamemodeWalls.Text = "Walls";
            this.rdB_gamemodeWalls.UseVisualStyleBackColor = true;
            this.rdB_gamemodeWalls.Visible = false;
            this.rdB_gamemodeWalls.CheckedChanged += new System.EventHandler(this.rdB_gamemodeWalls_CheckedChanged);
            // 
            // rdB_gamemodeAddedTreats
            // 
            this.rdB_gamemodeAddedTreats.AutoSize = true;
            this.rdB_gamemodeAddedTreats.Location = new System.Drawing.Point(252, 130);
            this.rdB_gamemodeAddedTreats.Name = "rdB_gamemodeAddedTreats";
            this.rdB_gamemodeAddedTreats.Size = new System.Drawing.Size(115, 21);
            this.rdB_gamemodeAddedTreats.TabIndex = 30;
            this.rdB_gamemodeAddedTreats.TabStop = true;
            this.rdB_gamemodeAddedTreats.Text = "Added Treats";
            this.rdB_gamemodeAddedTreats.UseVisualStyleBackColor = true;
            this.rdB_gamemodeAddedTreats.Visible = false;
            this.rdB_gamemodeAddedTreats.CheckedChanged += new System.EventHandler(this.rdB_gamemodeAddedTreats_CheckedChanged);
            // 
            // rdB_gamemodeImmortality
            // 
            this.rdB_gamemodeImmortality.AutoSize = true;
            this.rdB_gamemodeImmortality.Location = new System.Drawing.Point(252, 172);
            this.rdB_gamemodeImmortality.Name = "rdB_gamemodeImmortality";
            this.rdB_gamemodeImmortality.Size = new System.Drawing.Size(96, 21);
            this.rdB_gamemodeImmortality.TabIndex = 31;
            this.rdB_gamemodeImmortality.TabStop = true;
            this.rdB_gamemodeImmortality.Text = "Immortality";
            this.rdB_gamemodeImmortality.UseVisualStyleBackColor = true;
            this.rdB_gamemodeImmortality.Visible = false;
            this.rdB_gamemodeImmortality.CheckedChanged += new System.EventHandler(this.rdB_gamemodeImmortality_CheckedChanged);
            // 
            // pBox_gamemodePreview
            // 
            this.pBox_gamemodePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_gamemodePreview.Location = new System.Drawing.Point(33, 269);
            this.pBox_gamemodePreview.Name = "pBox_gamemodePreview";
            this.pBox_gamemodePreview.Size = new System.Drawing.Size(329, 113);
            this.pBox_gamemodePreview.TabIndex = 32;
            this.pBox_gamemodePreview.TabStop = false;
            this.pBox_gamemodePreview.Visible = false;
            // 
            // lbl_gamemodePreview
            // 
            this.lbl_gamemodePreview.AutoSize = true;
            this.lbl_gamemodePreview.Location = new System.Drawing.Point(30, 247);
            this.lbl_gamemodePreview.Name = "lbl_gamemodePreview";
            this.lbl_gamemodePreview.Size = new System.Drawing.Size(61, 17);
            this.lbl_gamemodePreview.TabIndex = 33;
            this.lbl_gamemodePreview.Text = "Preview:";
            this.lbl_gamemodePreview.Visible = false;
            // 
            // btn_gamemodeApply
            // 
            this.btn_gamemodeApply.Location = new System.Drawing.Point(148, 417);
            this.btn_gamemodeApply.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gamemodeApply.Name = "btn_gamemodeApply";
            this.btn_gamemodeApply.Size = new System.Drawing.Size(108, 33);
            this.btn_gamemodeApply.TabIndex = 34;
            this.btn_gamemodeApply.Text = "Apply";
            this.btn_gamemodeApply.UseVisualStyleBackColor = true;
            this.btn_gamemodeApply.Visible = false;
            this.btn_gamemodeApply.Click += new System.EventHandler(this.btn_gamemodeApply_Click);
            // 
            // blackdragon_interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 508);
            this.Controls.Add(this.btn_gamemodeApply);
            this.Controls.Add(this.lbl_gamemodePreview);
            this.Controls.Add(this.pBox_gamemodePreview);
            this.Controls.Add(this.rdB_gamemodeImmortality);
            this.Controls.Add(this.rdB_gamemodeAddedTreats);
            this.Controls.Add(this.rdB_gamemodeWalls);
            this.Controls.Add(this.lbl_gamemode);
            this.Controls.Add(this.rdB_gamemodeNormal);
            this.Controls.Add(this.lbl_instructionsGamemodeTxt);
            this.Controls.Add(this.pBox_instructionsGoal);
            this.Controls.Add(this.cBox_instructions);
            this.Controls.Add(this.lbl_instructionsGamemode);
            this.Controls.Add(this.lbl_instructionsControlsTxt);
            this.Controls.Add(this.lbl_instructionsControls);
            this.Controls.Add(this.lbl_instructionsGoalTxt);
            this.Controls.Add(this.lbl_instructionsGoal);
            this.Controls.Add(this.pBox_instructionsControls);
            this.Controls.Add(this.btn_colorApply);
            this.Controls.Add(this.cBox_color);
            this.Controls.Add(this.pBox_colorPreview);
            this.Controls.Add(this.lbl_colorPreview);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.rdB_gameSpeedSlow);
            this.Controls.Add(this.rdB_gameSpeedNormal);
            this.Controls.Add(this.rdB_gameSpeedFast);
            this.Controls.Add(this.lbl_gamespeed);
            this.Controls.Add(this.btn_gameSpeedApply);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pBox_gamespeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "blackdragon_interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.blackdragon_interface_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_instructionsGoal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_instructionsControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_colorPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_gamespeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_gamemodePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btn_gameSpeedApply;
        private System.Windows.Forms.Label lbl_gamespeed;
        private System.Windows.Forms.ToolStripMenuItem slowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamemodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdB_gameSpeedFast;
        private System.Windows.Forms.RadioButton rdB_gameSpeedNormal;
        private System.Windows.Forms.RadioButton rdB_gameSpeedSlow;
        private System.Windows.Forms.PictureBox pBox_gamespeed;
        private System.Windows.Forms.Label lbl_colorPreview;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.PictureBox pBox_colorPreview;
        private System.Windows.Forms.ComboBox cBox_color;
        private System.Windows.Forms.Button btn_colorApply;
        private System.Windows.Forms.PictureBox pBox_instructionsControls;
        private System.Windows.Forms.Label lbl_instructionsGoal;
        private System.Windows.Forms.Label lbl_instructionsGoalTxt;
        private System.Windows.Forms.Label lbl_instructionsControls;
        private System.Windows.Forms.Label lbl_instructionsControlsTxt;
        private System.Windows.Forms.Label lbl_instructionsGamemode;
        private System.Windows.Forms.ComboBox cBox_instructions;
        private System.Windows.Forms.PictureBox pBox_instructionsGoal;
        private System.Windows.Forms.Label lbl_instructionsGamemodeTxt;
        private System.Windows.Forms.RadioButton rdB_gamemodeNormal;
        private System.Windows.Forms.Label lbl_gamemode;
        private System.Windows.Forms.RadioButton rdB_gamemodeWalls;
        private System.Windows.Forms.RadioButton rdB_gamemodeAddedTreats;
        private System.Windows.Forms.RadioButton rdB_gamemodeImmortality;
        private System.Windows.Forms.PictureBox pBox_gamemodePreview;
        private System.Windows.Forms.Label lbl_gamemodePreview;
        private System.Windows.Forms.Button btn_gamemodeApply;
        private System.Windows.Forms.ToolStripMenuItem immortalityToolStripMenuItem;
    }
}