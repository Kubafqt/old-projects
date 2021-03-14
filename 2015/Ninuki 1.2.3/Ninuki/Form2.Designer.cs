namespace Ninuki
{
    partial class Form2
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
            this.btnngYes = new System.Windows.Forms.Button();
            this.btnngYesSave = new System.Windows.Forms.Button();
            this.btnngNo = new System.Windows.Forms.Button();
            this.lbNewGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnngYes
            // 
            this.btnngYes.Location = new System.Drawing.Point(12, 36);
            this.btnngYes.Name = "btnngYes";
            this.btnngYes.Size = new System.Drawing.Size(75, 23);
            this.btnngYes.TabIndex = 0;
            this.btnngYes.Text = "Ano";
            this.btnngYes.UseVisualStyleBackColor = true;
            this.btnngYes.Click += new System.EventHandler(this.btnngYes_Click);
            // 
            // btnngYesSave
            // 
            this.btnngYesSave.Location = new System.Drawing.Point(103, 36);
            this.btnngYesSave.Name = "btnngYesSave";
            this.btnngYesSave.Size = new System.Drawing.Size(174, 23);
            this.btnngYesSave.TabIndex = 1;
            this.btnngYesSave.Text = "Ano, ale uložit stávající hru...";
            this.btnngYesSave.UseVisualStyleBackColor = true;
            this.btnngYesSave.Click += new System.EventHandler(this.btnngYesSave_Click);
            // 
            // btnngNo
            // 
            this.btnngNo.Location = new System.Drawing.Point(289, 36);
            this.btnngNo.Name = "btnngNo";
            this.btnngNo.Size = new System.Drawing.Size(75, 23);
            this.btnngNo.TabIndex = 2;
            this.btnngNo.Text = "Ne";
            this.btnngNo.UseVisualStyleBackColor = true;
            this.btnngNo.Click += new System.EventHandler(this.btnngNo_Click);
            // 
            // lbNewGame
            // 
            this.lbNewGame.AutoSize = true;
            this.lbNewGame.Location = new System.Drawing.Point(54, 14);
            this.lbNewGame.Name = "lbNewGame";
            this.lbNewGame.Size = new System.Drawing.Size(168, 13);
            this.lbNewGame.TabIndex = 3;
            this.lbNewGame.Text = "Opravdu chcete začít novou hru?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 74);
            this.Controls.Add(this.lbNewGame);
            this.Controls.Add(this.btnngNo);
            this.Controls.Add(this.btnngYesSave);
            this.Controls.Add(this.btnngYes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Nová hra?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnngYes;
        private System.Windows.Forms.Button btnngYesSave;
        private System.Windows.Forms.Button btnngNo;
        private System.Windows.Forms.Label lbNewGame;
    }
}