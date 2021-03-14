namespace Sudoku
{
    partial class Form1
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
            this.btnGen = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnLang1 = new System.Windows.Forms.Button();
            this.btnLang3 = new System.Windows.Forms.Button();
            this.btnLang2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.lbOdecet = new System.Windows.Forms.Label();
            this.tbOdecet = new System.Windows.Forms.ComboBox();
            this.cbShowMatch = new System.Windows.Forms.CheckBox();
            this.lbNapoveda = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbTimer = new System.Windows.Forms.Label();
            this.rbLevelmode = new System.Windows.Forms.RadioButton();
            this.lbLevel = new System.Windows.Forms.Label();
            this.tbLevel = new System.Windows.Forms.ComboBox();
            this.lbNextLevel = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbLevelMode = new System.Windows.Forms.Label();
            this.lbLevel23 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGen
            // 
            this.btnGen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGen.Location = new System.Drawing.Point(626, 79);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(110, 40);
            this.btnGen.TabIndex = 1;
            this.btnGen.Text = "New game";
            this.btnGen.UseVisualStyleBackColor = false;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHelp.Location = new System.Drawing.Point(628, 365);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(110, 40);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "help me!";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnLang1
            // 
            this.btnLang1.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLang1.Location = new System.Drawing.Point(630, 473);
            this.btnLang1.Name = "btnLang1";
            this.btnLang1.Size = new System.Drawing.Size(110, 27);
            this.btnLang1.TabIndex = 7;
            this.btnLang1.Text = "Čeština";
            this.btnLang1.UseVisualStyleBackColor = false;
            this.btnLang1.Click += new System.EventHandler(this.btnLang1_Click);
            // 
            // btnLang3
            // 
            this.btnLang3.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLang3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLang3.Location = new System.Drawing.Point(630, 541);
            this.btnLang3.Name = "btnLang3";
            this.btnLang3.Size = new System.Drawing.Size(110, 27);
            this.btnLang3.TabIndex = 8;
            this.btnLang3.Text = "Deutsch";
            this.btnLang3.UseVisualStyleBackColor = false;
            this.btnLang3.Click += new System.EventHandler(this.btnLang3_Click);
            // 
            // btnLang2
            // 
            this.btnLang2.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLang2.Location = new System.Drawing.Point(630, 507);
            this.btnLang2.Name = "btnLang2";
            this.btnLang2.Size = new System.Drawing.Size(110, 27);
            this.btnLang2.TabIndex = 9;
            this.btnLang2.Text = "English";
            this.btnLang2.UseVisualStyleBackColor = false;
            this.btnLang2.Click += new System.EventHandler(this.btnLang2_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(628, 418);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 40);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbEasy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbEasy.Location = new System.Drawing.Point(633, 129);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(55, 19);
            this.rbEasy.TabIndex = 11;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbMedium.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbMedium.Location = new System.Drawing.Point(633, 152);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(77, 19);
            this.rbMedium.TabIndex = 12;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbHard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbHard.Location = new System.Drawing.Point(633, 175);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(56, 19);
            this.rbHard.TabIndex = 13;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("PT Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(611, 574);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 32);
            this.label.TabIndex = 15;
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbUser.Location = new System.Drawing.Point(633, 198);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(73, 19);
            this.rbUser.TabIndex = 17;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "Custom";
            this.rbUser.UseVisualStyleBackColor = true;
            this.rbUser.CheckedChanged += new System.EventHandler(this.rbUser_CheckedChanged);
            // 
            // lbOdecet
            // 
            this.lbOdecet.AutoSize = true;
            this.lbOdecet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbOdecet.ForeColor = System.Drawing.Color.White;
            this.lbOdecet.Location = new System.Drawing.Point(567, 252);
            this.lbOdecet.Name = "lbOdecet";
            this.lbOdecet.Size = new System.Drawing.Size(161, 15);
            this.lbOdecet.TabIndex = 19;
            this.lbOdecet.Text = "Počet vymazaných čísel:";
            this.lbOdecet.Visible = false;
            // 
            // tbOdecet
            // 
            this.tbOdecet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbOdecet.FormattingEnabled = true;
            this.tbOdecet.Location = new System.Drawing.Point(734, 250);
            this.tbOdecet.Name = "tbOdecet";
            this.tbOdecet.Size = new System.Drawing.Size(41, 21);
            this.tbOdecet.TabIndex = 20;
            this.tbOdecet.Visible = false;
            // 
            // cbShowMatch
            // 
            this.cbShowMatch.AutoSize = true;
            this.cbShowMatch.Checked = true;
            this.cbShowMatch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cbShowMatch.ForeColor = System.Drawing.Color.White;
            this.cbShowMatch.Location = new System.Drawing.Point(625, 338);
            this.cbShowMatch.Name = "cbShowMatch";
            this.cbShowMatch.Size = new System.Drawing.Size(119, 19);
            this.cbShowMatch.TabIndex = 21;
            this.cbShowMatch.Text = "Show matches";
            this.cbShowMatch.UseVisualStyleBackColor = true;
            this.cbShowMatch.CheckedChanged += new System.EventHandler(this.cbShowMatch_CheckedChanged);
            // 
            // lbNapoveda
            // 
            this.lbNapoveda.AutoSize = true;
            this.lbNapoveda.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNapoveda.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbNapoveda.Location = new System.Drawing.Point(112, 574);
            this.lbNapoveda.Name = "lbNapoveda";
            this.lbNapoveda.Size = new System.Drawing.Size(156, 27);
            this.lbNapoveda.TabIndex = 22;
            this.lbNapoveda.Text = "Počet nápověd:";
            this.lbNapoveda.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTimer.ForeColor = System.Drawing.Color.White;
            this.lbTimer.Location = new System.Drawing.Point(112, 50);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(228, 27);
            this.lbTimer.TabIndex = 23;
            this.lbTimer.Text = "Počet opakování cyklu:";
            this.lbTimer.Visible = false;
            this.lbTimer.Click += new System.EventHandler(this.lbTimer_Click);
            // 
            // rbLevelmode
            // 
            this.rbLevelmode.AutoSize = true;
            this.rbLevelmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbLevelmode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbLevelmode.Location = new System.Drawing.Point(633, 223);
            this.rbLevelmode.Name = "rbLevelmode";
            this.rbLevelmode.Size = new System.Drawing.Size(95, 19);
            this.rbLevelmode.TabIndex = 24;
            this.rbLevelmode.TabStop = true;
            this.rbLevelmode.Text = "LevelMode";
            this.rbLevelmode.UseVisualStyleBackColor = true;
            this.rbLevelmode.CheckedChanged += new System.EventHandler(this.rbLevelmode_CheckedChanged);
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbLevel.ForeColor = System.Drawing.Color.White;
            this.lbLevel.Location = new System.Drawing.Point(630, 251);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(45, 15);
            this.lbLevel.TabIndex = 25;
            this.lbLevel.Text = "Level:";
            this.lbLevel.Visible = false;
            // 
            // tbLevel
            // 
            this.tbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbLevel.FormattingEnabled = true;
            this.tbLevel.Location = new System.Drawing.Point(681, 249);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.Size = new System.Drawing.Size(41, 21);
            this.tbLevel.TabIndex = 26;
            this.tbLevel.Visible = false;
            // 
            // lbNextLevel
            // 
            this.lbNextLevel.AutoSize = true;
            this.lbNextLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbNextLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.lbNextLevel.Location = new System.Drawing.Point(635, 319);
            this.lbNextLevel.Name = "lbNextLevel";
            this.lbNextLevel.Size = new System.Drawing.Size(78, 15);
            this.lbNextLevel.TabIndex = 27;
            this.lbNextLevel.Text = "Next Level!";
            this.lbNextLevel.Visible = false;
            this.lbNextLevel.Click += new System.EventHandler(this.lbNextLevel_Click);
            this.lbNextLevel.MouseHover += new System.EventHandler(this.lbNextLevel_MouseHover);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoad.Location = new System.Drawing.Point(625, 276);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(47, 21);
            this.btnLoad.TabIndex = 28;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(678, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 21);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbLevelMode
            // 
            this.lbLevelMode.AutoSize = true;
            this.lbLevelMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbLevelMode.ForeColor = System.Drawing.Color.White;
            this.lbLevelMode.Location = new System.Drawing.Point(625, 300);
            this.lbLevelMode.Name = "lbLevelMode";
            this.lbLevelMode.Size = new System.Drawing.Size(81, 15);
            this.lbLevelMode.TabIndex = 30;
            this.lbLevelMode.Text = "LevelMode:";
            this.lbLevelMode.Visible = false;
            // 
            // lbLevel23
            // 
            this.lbLevel23.AutoSize = true;
            this.lbLevel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbLevel23.ForeColor = System.Drawing.Color.White;
            this.lbLevel23.Location = new System.Drawing.Point(734, 278);
            this.lbLevel23.Name = "lbLevel23";
            this.lbLevel23.Size = new System.Drawing.Size(41, 15);
            this.lbLevel23.TabIndex = 31;
            this.lbLevel23.Text = "Level";
            this.lbLevel23.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(123)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(813, 650);
            this.Controls.Add(this.lbLevel23);
            this.Controls.Add(this.lbLevelMode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbNextLevel);
            this.Controls.Add(this.tbLevel);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.rbLevelmode);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbNapoveda);
            this.Controls.Add(this.cbShowMatch);
            this.Controls.Add(this.tbOdecet);
            this.Controls.Add(this.lbOdecet);
            this.Controls.Add(this.rbUser);
            this.Controls.Add(this.label);
            this.Controls.Add(this.rbHard);
            this.Controls.Add(this.rbMedium);
            this.Controls.Add(this.rbEasy);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLang2);
            this.Controls.Add(this.btnLang3);
            this.Controls.Add(this.btnLang1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnGen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "KubafSudoku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnLang1;
        private System.Windows.Forms.Button btnLang3;
        private System.Windows.Forms.Button btnLang2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.Label lbOdecet;
        private System.Windows.Forms.ComboBox tbOdecet;
        private System.Windows.Forms.CheckBox cbShowMatch;
        private System.Windows.Forms.Label lbNapoveda;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.RadioButton rbLevelmode;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.ComboBox tbLevel;
        private System.Windows.Forms.Label lbNextLevel;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbLevelMode;
        private System.Windows.Forms.Label lbLevel23;


    }
}

