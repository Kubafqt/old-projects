namespace Passwords
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
            this.lbPocet = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.rbMD5 = new System.Windows.Forms.RadioButton();
            this.rbSHA256 = new System.Windows.Forms.RadioButton();
            this.rbSHA512 = new System.Windows.Forms.RadioButton();
            this.rbSHA1 = new System.Windows.Forms.RadioButton();
            this.tbPocet = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPocet
            // 
            this.lbPocet.AutoSize = true;
            this.lbPocet.Location = new System.Drawing.Point(25, 26);
            this.lbPocet.Name = "lbPocet";
            this.lbPocet.Size = new System.Drawing.Size(148, 13);
            this.lbPocet.TabIndex = 0;
            this.lbPocet.Text = "Počet vygenerovaných hesel:";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(48, 176);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(82, 38);
            this.btnGen.TabIndex = 1;
            this.btnGen.Text = "Vygenerovat";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(187, 176);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(84, 38);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Projít soubor";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // rbMD5
            // 
            this.rbMD5.AutoSize = true;
            this.rbMD5.Location = new System.Drawing.Point(59, 72);
            this.rbMD5.Name = "rbMD5";
            this.rbMD5.Size = new System.Drawing.Size(48, 17);
            this.rbMD5.TabIndex = 3;
            this.rbMD5.TabStop = true;
            this.rbMD5.Text = "MD5";
            this.rbMD5.UseVisualStyleBackColor = true;
            // 
            // rbSHA256
            // 
            this.rbSHA256.AutoSize = true;
            this.rbSHA256.Location = new System.Drawing.Point(59, 118);
            this.rbSHA256.Name = "rbSHA256";
            this.rbSHA256.Size = new System.Drawing.Size(65, 17);
            this.rbSHA256.TabIndex = 4;
            this.rbSHA256.TabStop = true;
            this.rbSHA256.Text = "SHA256";
            this.rbSHA256.UseVisualStyleBackColor = true;
            // 
            // rbSHA512
            // 
            this.rbSHA512.AutoSize = true;
            this.rbSHA512.Location = new System.Drawing.Point(188, 118);
            this.rbSHA512.Name = "rbSHA512";
            this.rbSHA512.Size = new System.Drawing.Size(65, 17);
            this.rbSHA512.TabIndex = 5;
            this.rbSHA512.TabStop = true;
            this.rbSHA512.Text = "SHA512";
            this.rbSHA512.UseVisualStyleBackColor = true;
            // 
            // rbSHA1
            // 
            this.rbSHA1.AutoSize = true;
            this.rbSHA1.Location = new System.Drawing.Point(188, 72);
            this.rbSHA1.Name = "rbSHA1";
            this.rbSHA1.Size = new System.Drawing.Size(53, 17);
            this.rbSHA1.TabIndex = 6;
            this.rbSHA1.TabStop = true;
            this.rbSHA1.Text = "SHA1";
            this.rbSHA1.UseVisualStyleBackColor = true;
            // 
            // tbPocet
            // 
            this.tbPocet.Location = new System.Drawing.Point(179, 23);
            this.tbPocet.Name = "tbPocet";
            this.tbPocet.Size = new System.Drawing.Size(100, 20);
            this.tbPocet.TabIndex = 7;
            this.tbPocet.Text = "100";
            this.tbPocet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(48, 255);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(223, 32);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Otevřít soubor";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(48, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(223, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 10;
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath.Location = new System.Drawing.Point(25, 226);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(0, 15);
            this.lbPath.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 343);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.tbPocet);
            this.Controls.Add(this.rbSHA1);
            this.Controls.Add(this.rbSHA512);
            this.Controls.Add(this.rbSHA256);
            this.Controls.Add(this.rbMD5);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.lbPocet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Heslo generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPocet;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.RadioButton rbMD5;
        private System.Windows.Forms.RadioButton rbSHA256;
        private System.Windows.Forms.RadioButton rbSHA512;
        private System.Windows.Forms.RadioButton rbSHA1;
        private System.Windows.Forms.TextBox tbPocet;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPath;
    }
}

