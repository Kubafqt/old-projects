namespace Ninuki
{
    partial class Form1
    {
        /// <summary>
        /// Vyžadovaná proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolnit všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by měl být spravovaný prostředek odstraněn, jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Panel = new System.Windows.Forms.Panel();
            this.btnBug = new System.Windows.Forms.Button();
            this.labelB = new System.Windows.Forms.Label();
            this.labelW = new System.Windows.Forms.Label();
            this.cbPole = new System.Windows.Forms.CheckBox();
            this.cbMys = new System.Windows.Forms.CheckBox();
            this.lbSourPole = new System.Windows.Forms.Label();
            this.lbSourMys = new System.Windows.Forms.Label();
            this.lbSour = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbHistorie = new System.Windows.Forms.Label();
            this.Zaznam = new System.Windows.Forms.RichTextBox();
            this.lbNaTahu = new System.Windows.Forms.Label();
            this.NaTahu = new System.Windows.Forms.Panel();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rozlišeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoDetectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.x768ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x864ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x960ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x1050ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x1080ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x1200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.x1024ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.x720ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x768ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.x900ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x1080ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.x800ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x900ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.x1050ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.x1200ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jazykLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.českyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.Hra = new System.Windows.Forms.Panel();
            this.Panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Hra.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.SaddleBrown;
            this.Panel.Controls.Add(this.btnBug);
            this.Panel.Controls.Add(this.labelB);
            this.Panel.Controls.Add(this.labelW);
            this.Panel.Controls.Add(this.cbPole);
            this.Panel.Controls.Add(this.cbMys);
            this.Panel.Controls.Add(this.lbSourPole);
            this.Panel.Controls.Add(this.lbSourMys);
            this.Panel.Controls.Add(this.lbSour);
            this.Panel.Controls.Add(this.btnSave);
            this.Panel.Controls.Add(this.lbHistorie);
            this.Panel.Controls.Add(this.Zaznam);
            this.Panel.Controls.Add(this.lbNaTahu);
            this.Panel.Controls.Add(this.NaTahu);
            this.Panel.Controls.Add(this.btnEnd);
            this.Panel.Controls.Add(this.btnStart);
            this.Panel.Controls.Add(this.menuStrip1);
            this.Panel.Location = new System.Drawing.Point(665, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(202, 665);
            this.Panel.TabIndex = 0;
            // 
            // btnBug
            // 
            this.btnBug.BackColor = System.Drawing.Color.DarkRed;
            this.btnBug.Font = new System.Drawing.Font("Felix Titling", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBug.ForeColor = System.Drawing.Color.Black;
            this.btnBug.Location = new System.Drawing.Point(125, 606);
            this.btnBug.Name = "btnBug";
            this.btnBug.Size = new System.Drawing.Size(64, 36);
            this.btnBug.TabIndex = 13;
            this.btnBug.Text = "BUG";
            this.btnBug.UseVisualStyleBackColor = false;
            this.btnBug.Click += new System.EventHandler(this.btnBug_Click);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelB.Location = new System.Drawing.Point(5, 240);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(184, 16);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "Počet zabraných bílých: 0";
            // 
            // labelW
            // 
            this.labelW.AutoSize = true;
            this.labelW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelW.Location = new System.Drawing.Point(5, 256);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(197, 16);
            this.labelW.TabIndex = 5;
            this.labelW.Text = "Počet zabraných černých: 0";
            // 
            // cbPole
            // 
            this.cbPole.AutoSize = true;
            this.cbPole.Location = new System.Drawing.Point(96, 628);
            this.cbPole.Name = "cbPole";
            this.cbPole.Size = new System.Drawing.Size(15, 14);
            this.cbPole.TabIndex = 12;
            this.cbPole.UseVisualStyleBackColor = true;
            this.cbPole.CheckedChanged += new System.EventHandler(this.cbPole_CheckedChanged);
            // 
            // cbMys
            // 
            this.cbMys.AutoSize = true;
            this.cbMys.Location = new System.Drawing.Point(96, 608);
            this.cbMys.Name = "cbMys";
            this.cbMys.Size = new System.Drawing.Size(15, 14);
            this.cbMys.TabIndex = 11;
            this.cbMys.UseVisualStyleBackColor = true;
            this.cbMys.CheckedChanged += new System.EventHandler(this.cbMys_CheckedChanged);
            // 
            // lbSourPole
            // 
            this.lbSourPole.AutoSize = true;
            this.lbSourPole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSourPole.ForeColor = System.Drawing.Color.Black;
            this.lbSourPole.Location = new System.Drawing.Point(32, 626);
            this.lbSourPole.Name = "lbSourPole";
            this.lbSourPole.Size = new System.Drawing.Size(58, 15);
            this.lbSourPole.TabIndex = 10;
            this.lbSourPole.Text = "- U polí:";
            // 
            // lbSourMys
            // 
            this.lbSourMys.AutoSize = true;
            this.lbSourMys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSourMys.ForeColor = System.Drawing.Color.Black;
            this.lbSourMys.Location = new System.Drawing.Point(27, 606);
            this.lbSourMys.Name = "lbSourMys";
            this.lbSourMys.Size = new System.Drawing.Size(63, 15);
            this.lbSourMys.TabIndex = 9;
            this.lbSourMys.Text = "- U myši:";
            // 
            // lbSour
            // 
            this.lbSour.AutoSize = true;
            this.lbSour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSour.ForeColor = System.Drawing.Color.Black;
            this.lbSour.Location = new System.Drawing.Point(27, 585);
            this.lbSour.Name = "lbSour";
            this.lbSour.Size = new System.Drawing.Size(154, 18);
            this.lbSour.TabIndex = 8;
            this.lbSour.Text = "Zobraz souřadnice:";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleName = "btnSave";
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.CausesValidation = false;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(49, 71);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save Game!";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbHistorie
            // 
            this.lbHistorie.AutoSize = true;
            this.lbHistorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbHistorie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbHistorie.Location = new System.Drawing.Point(31, 281);
            this.lbHistorie.Name = "lbHistorie";
            this.lbHistorie.Size = new System.Drawing.Size(117, 20);
            this.lbHistorie.TabIndex = 7;
            this.lbHistorie.Text = "Historie tahů:";
            // 
            // Zaznam
            // 
            this.Zaznam.Location = new System.Drawing.Point(16, 304);
            this.Zaznam.Name = "Zaznam";
            this.Zaznam.ReadOnly = true;
            this.Zaznam.Size = new System.Drawing.Size(171, 266);
            this.Zaznam.TabIndex = 6;
            this.Zaznam.Text = "";
            this.Zaznam.TextChanged += new System.EventHandler(this.Zaznam_TextChanged);
            // 
            // lbNaTahu
            // 
            this.lbNaTahu.AutoSize = true;
            this.lbNaTahu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNaTahu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNaTahu.Location = new System.Drawing.Point(61, 132);
            this.lbNaTahu.Name = "lbNaTahu";
            this.lbNaTahu.Size = new System.Drawing.Size(89, 18);
            this.lbNaTahu.TabIndex = 3;
            this.lbNaTahu.Text = "Na tahu je:";
            // 
            // NaTahu
            // 
            this.NaTahu.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.NaTahu.Location = new System.Drawing.Point(74, 153);
            this.NaTahu.Name = "NaTahu";
            this.NaTahu.Size = new System.Drawing.Size(76, 76);
            this.NaTahu.TabIndex = 2;
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnd.ForeColor = System.Drawing.Color.Black;
            this.btnEnd.Location = new System.Drawing.Point(49, 102);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(132, 25);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "End!";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(49, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start new game!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rozlišeníToolStripMenuItem,
            this.jazykLanguageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rozlišeníToolStripMenuItem
            // 
            this.rozlišeníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoDetectToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.rozlišeníToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rozlišeníToolStripMenuItem.Name = "rozlišeníToolStripMenuItem";
            this.rozlišeníToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.rozlišeníToolStripMenuItem.Text = "Rozlišení";
            this.rozlišeníToolStripMenuItem.Click += new System.EventHandler(this.rozlišeníToolStripMenuItem_Click);
            // 
            // autoDetectToolStripMenuItem
            // 
            this.autoDetectToolStripMenuItem.Name = "autoDetectToolStripMenuItem";
            this.autoDetectToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.autoDetectToolStripMenuItem.Text = "Auto-Detect";
            this.autoDetectToolStripMenuItem.Click += new System.EventHandler(this.autoDetectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x768ToolStripMenuItem,
            this.x864ToolStripMenuItem,
            this.x960ToolStripMenuItem,
            this.x1050ToolStripMenuItem,
            this.x1080ToolStripMenuItem,
            this.x1200ToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem2.Text = "4:3";
            // 
            // x768ToolStripMenuItem
            // 
            this.x768ToolStripMenuItem.Name = "x768ToolStripMenuItem";
            this.x768ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.x768ToolStripMenuItem.Text = "1024x768";
            this.x768ToolStripMenuItem.Click += new System.EventHandler(this.x768ToolStripMenuItem_Click);
            // 
            // x864ToolStripMenuItem
            // 
            this.x864ToolStripMenuItem.Name = "x864ToolStripMenuItem";
            this.x864ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.x864ToolStripMenuItem.Text = "1152x864";
            this.x864ToolStripMenuItem.Click += new System.EventHandler(this.x864ToolStripMenuItem_Click);
            // 
            // x960ToolStripMenuItem
            // 
            this.x960ToolStripMenuItem.Name = "x960ToolStripMenuItem";
            this.x960ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.x960ToolStripMenuItem.Text = "1280x960";
            this.x960ToolStripMenuItem.Click += new System.EventHandler(this.x960ToolStripMenuItem_Click);
            // 
            // x1050ToolStripMenuItem
            // 
            this.x1050ToolStripMenuItem.Name = "x1050ToolStripMenuItem";
            this.x1050ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.x1050ToolStripMenuItem.Text = "1400x1050";
            this.x1050ToolStripMenuItem.Click += new System.EventHandler(this.x1050ToolStripMenuItem_Click);
            // 
            // x1080ToolStripMenuItem
            // 
            this.x1080ToolStripMenuItem.Name = "x1080ToolStripMenuItem";
            this.x1080ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.x1080ToolStripMenuItem.Text = "1440x1080";
            this.x1080ToolStripMenuItem.Click += new System.EventHandler(this.x1080ToolStripMenuItem_Click);
            // 
            // x1200ToolStripMenuItem
            // 
            this.x1200ToolStripMenuItem.Name = "x1200ToolStripMenuItem";
            this.x1200ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.x1200ToolStripMenuItem.Text = "1600x1200";
            this.x1200ToolStripMenuItem.Click += new System.EventHandler(this.x1200ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x1024ToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem3.Text = "5:4";
            // 
            // x1024ToolStripMenuItem
            // 
            this.x1024ToolStripMenuItem.Name = "x1024ToolStripMenuItem";
            this.x1024ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.x1024ToolStripMenuItem.Text = "1280x1024";
            this.x1024ToolStripMenuItem.Click += new System.EventHandler(this.x1024ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x720ToolStripMenuItem,
            this.x768ToolStripMenuItem1,
            this.x900ToolStripMenuItem,
            this.x1080ToolStripMenuItem1});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem4.Text = "16:9";
            // 
            // x720ToolStripMenuItem
            // 
            this.x720ToolStripMenuItem.Name = "x720ToolStripMenuItem";
            this.x720ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.x720ToolStripMenuItem.Text = "1280x720";
            this.x720ToolStripMenuItem.Click += new System.EventHandler(this.x720ToolStripMenuItem_Click);
            // 
            // x768ToolStripMenuItem1
            // 
            this.x768ToolStripMenuItem1.Name = "x768ToolStripMenuItem1";
            this.x768ToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.x768ToolStripMenuItem1.Text = "1366x768";
            this.x768ToolStripMenuItem1.Click += new System.EventHandler(this.x768ToolStripMenuItem1_Click);
            // 
            // x900ToolStripMenuItem
            // 
            this.x900ToolStripMenuItem.Name = "x900ToolStripMenuItem";
            this.x900ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.x900ToolStripMenuItem.Text = "1600x900";
            this.x900ToolStripMenuItem.Click += new System.EventHandler(this.x900ToolStripMenuItem_Click);
            // 
            // x1080ToolStripMenuItem1
            // 
            this.x1080ToolStripMenuItem1.Name = "x1080ToolStripMenuItem1";
            this.x1080ToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.x1080ToolStripMenuItem1.Text = "1920x1080";
            this.x1080ToolStripMenuItem1.Click += new System.EventHandler(this.x1080ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x800ToolStripMenuItem,
            this.x900ToolStripMenuItem1,
            this.x1050ToolStripMenuItem1,
            this.x1200ToolStripMenuItem1});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem5.Text = "16:10";
            // 
            // x800ToolStripMenuItem
            // 
            this.x800ToolStripMenuItem.Name = "x800ToolStripMenuItem";
            this.x800ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.x800ToolStripMenuItem.Text = "1280x800";
            this.x800ToolStripMenuItem.Click += new System.EventHandler(this.x800ToolStripMenuItem_Click);
            // 
            // x900ToolStripMenuItem1
            // 
            this.x900ToolStripMenuItem1.Name = "x900ToolStripMenuItem1";
            this.x900ToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.x900ToolStripMenuItem1.Text = "1400x900";
            this.x900ToolStripMenuItem1.Click += new System.EventHandler(this.x900ToolStripMenuItem1_Click);
            // 
            // x1050ToolStripMenuItem1
            // 
            this.x1050ToolStripMenuItem1.Name = "x1050ToolStripMenuItem1";
            this.x1050ToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.x1050ToolStripMenuItem1.Text = "1680x1050";
            this.x1050ToolStripMenuItem1.Click += new System.EventHandler(this.x1050ToolStripMenuItem1_Click);
            // 
            // x1200ToolStripMenuItem1
            // 
            this.x1200ToolStripMenuItem1.Name = "x1200ToolStripMenuItem1";
            this.x1200ToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.x1200ToolStripMenuItem1.Text = "1920x1200";
            this.x1200ToolStripMenuItem1.Click += new System.EventHandler(this.x1200ToolStripMenuItem1_Click);
            // 
            // jazykLanguageToolStripMenuItem
            // 
            this.jazykLanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.českyToolStripMenuItem,
            this.englishToolStripMenuItem,
            this.deutschToolStripMenuItem});
            this.jazykLanguageToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.jazykLanguageToolStripMenuItem.Name = "jazykLanguageToolStripMenuItem";
            this.jazykLanguageToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.jazykLanguageToolStripMenuItem.Text = "Jazyk/Language";
            // 
            // českyToolStripMenuItem
            // 
            this.českyToolStripMenuItem.Name = "českyToolStripMenuItem";
            this.českyToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.českyToolStripMenuItem.Text = "Česky";
            this.českyToolStripMenuItem.Click += new System.EventHandler(this.českyToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // deutschToolStripMenuItem
            // 
            this.deutschToolStripMenuItem.Name = "deutschToolStripMenuItem";
            this.deutschToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.deutschToolStripMenuItem.Text = "Deutsch";
            this.deutschToolStripMenuItem.Click += new System.EventHandler(this.deutschToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.BackColor = System.Drawing.Color.Transparent;
            this.lbX.CausesValidation = false;
            this.lbX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbX.Location = new System.Drawing.Point(12, 9);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(13, 20);
            this.lbX.TabIndex = 10;
            this.lbX.Text = "0";
            this.lbX.UseCompatibleTextRendering = true;
            this.lbX.UseMnemonic = false;
            // 
            // lbY
            // 
            this.lbY.AllowDrop = true;
            this.lbY.AutoSize = true;
            this.lbY.CausesValidation = false;
            this.lbY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbY.Location = new System.Drawing.Point(12, 25);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(13, 20);
            this.lbY.TabIndex = 10;
            this.lbY.Text = "0";
            this.lbY.UseCompatibleTextRendering = true;
            this.lbY.UseMnemonic = false;
            // 
            // Hra
            // 
            this.Hra.BackColor = System.Drawing.Color.Peru;
            this.Hra.Controls.Add(this.lbY);
            this.Hra.Controls.Add(this.lbX);
            this.Hra.Location = new System.Drawing.Point(0, 0);
            this.Hra.Name = "Hra";
            this.Hra.Size = new System.Drawing.Size(665, 665);
            this.Hra.TabIndex = 1;
            this.Hra.Paint += new System.Windows.Forms.PaintEventHandler(this.hra_Paint);
            this.Hra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Hra_MouseClick);
            this.Hra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hra_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(866, 665);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Hra);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ninuki";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Hra.ResumeLayout(false);
            this.Hra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel NaTahu;
        private System.Windows.Forms.Label lbNaTahu;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label lbHistorie;
        private System.Windows.Forms.CheckBox cbPole;
        private System.Windows.Forms.CheckBox cbMys;
        private System.Windows.Forms.Label lbSourPole;
        private System.Windows.Forms.Label lbSourMys;
        private System.Windows.Forms.Label lbSour;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Panel Hra;
        private System.Windows.Forms.Button btnBug;
        private System.Windows.Forms.Label lbX;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.RichTextBox Zaznam;
        public System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rozlišeníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoDetectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem x768ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x864ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x960ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x1050ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x1080ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x1200ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem x1024ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem x720ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x768ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x900ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x1080ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x800ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x900ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x1050ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x1200ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jazykLanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem českyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutschToolStripMenuItem;

    }
}

