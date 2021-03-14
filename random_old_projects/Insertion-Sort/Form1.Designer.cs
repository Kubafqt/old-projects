namespace Insertion_Sort
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
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
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAdd = new System.Windows.Forms.Button();
            this.tbVstup = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btRandPole = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.lbSorted = new System.Windows.Forms.Label();
            this.btRadix = new System.Windows.Forms.Button();
            this.btTest = new System.Windows.Forms.Button();
            this.cbQuickBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(482, 71);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbVstup
            // 
            this.tbVstup.Location = new System.Drawing.Point(343, 73);
            this.tbVstup.Name = "tbVstup";
            this.tbVstup.Size = new System.Drawing.Size(133, 20);
            this.tbVstup.TabIndex = 1;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfo.Location = new System.Drawing.Point(12, 74);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(325, 16);
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "Vlož čísla (možno oddělit čárkou, středníkem):";
            // 
            // btRandPole
            // 
            this.btRandPole.Location = new System.Drawing.Point(563, 71);
            this.btRandPole.Name = "btRandPole";
            this.btRandPole.Size = new System.Drawing.Size(75, 23);
            this.btRandPole.TabIndex = 3;
            this.btRandPole.Text = "Random Pole";
            this.btRandPole.UseVisualStyleBackColor = true;
            this.btRandPole.Click += new System.EventHandler(this.btRandPole_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(644, 71);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 4;
            this.btReset.Text = "Reset pole";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSort
            // 
            this.btSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSort.Location = new System.Drawing.Point(482, 111);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(75, 23);
            this.btSort.TabIndex = 5;
            this.btSort.Text = "Sort";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // lbSorted
            // 
            this.lbSorted.AutoSize = true;
            this.lbSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSorted.Location = new System.Drawing.Point(12, 167);
            this.lbSorted.Name = "lbSorted";
            this.lbSorted.Size = new System.Drawing.Size(0, 16);
            this.lbSorted.TabIndex = 6;
            // 
            // btRadix
            // 
            this.btRadix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btRadix.Location = new System.Drawing.Point(563, 111);
            this.btRadix.Name = "btRadix";
            this.btRadix.Size = new System.Drawing.Size(75, 23);
            this.btRadix.TabIndex = 7;
            this.btRadix.Text = "Radix";
            this.btRadix.UseVisualStyleBackColor = true;
            this.btRadix.Click += new System.EventHandler(this.btRadix_Click);
            // 
            // btTest
            // 
            this.btTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btTest.Location = new System.Drawing.Point(644, 111);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(75, 23);
            this.btTest.TabIndex = 8;
            this.btTest.Text = "OOP sort";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // cbQuickBox
            // 
            this.cbQuickBox.AutoSize = true;
            this.cbQuickBox.Location = new System.Drawing.Point(369, 117);
            this.cbQuickBox.Name = "cbQuickBox";
            this.cbQuickBox.Size = new System.Drawing.Size(107, 17);
            this.cbQuickBox.TabIndex = 9;
            this.cbQuickBox.Text = "quickbox (listbox)";
            this.cbQuickBox.UseVisualStyleBackColor = true;
            this.cbQuickBox.CheckedChanged += new System.EventHandler(this.cbQuickBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 648);
            this.Controls.Add(this.cbQuickBox);
            this.Controls.Add(this.btTest);
            this.Controls.Add(this.btRadix);
            this.Controls.Add(this.lbSorted);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btRandPole);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.tbVstup);
            this.Controls.Add(this.btAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sorting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbVstup;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btRandPole;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btSort;
        public System.Windows.Forms.Label lbSorted;
        private System.Windows.Forms.Button btRadix;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.CheckBox cbQuickBox;
    }
}

