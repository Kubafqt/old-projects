namespace Ninuki
{
    partial class Konec
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
            this.label = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnPokracovat = new System.Windows.Forms.Button();
            this.btnSaveGame = new System.Windows.Forms.Button();
            this.btnKonec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(80, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(91, 18);
            this.label.TabIndex = 0;
            this.label.Text = "Konec Hry!";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewGame.Location = new System.Drawing.Point(68, 38);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(124, 40);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "Nová hra";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnPokracovat
            // 
            this.btnPokracovat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPokracovat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPokracovat.Location = new System.Drawing.Point(68, 86);
            this.btnPokracovat.Name = "btnPokracovat";
            this.btnPokracovat.Size = new System.Drawing.Size(124, 40);
            this.btnPokracovat.TabIndex = 2;
            this.btnPokracovat.Text = "Pokračovat";
            this.btnPokracovat.UseVisualStyleBackColor = false;
            this.btnPokracovat.Click += new System.EventHandler(this.btnPokracovat_Click);
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveGame.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveGame.Location = new System.Drawing.Point(45, 133);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(165, 45);
            this.btnSaveGame.TabIndex = 3;
            this.btnSaveGame.Text = "Uložit záznam tahů...";
            this.btnSaveGame.UseVisualStyleBackColor = false;
            this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // btnKonec
            // 
            this.btnKonec.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKonec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKonec.Location = new System.Drawing.Point(68, 185);
            this.btnKonec.Name = "btnKonec";
            this.btnKonec.Size = new System.Drawing.Size(122, 40);
            this.btnKonec.TabIndex = 4;
            this.btnKonec.Text = "Konec!";
            this.btnKonec.UseVisualStyleBackColor = false;
            this.btnKonec.Click += new System.EventHandler(this.btnKonec_Click);
            // 
            // Konec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(262, 237);
            this.Controls.Add(this.btnKonec);
            this.Controls.Add(this.btnSaveGame);
            this.Controls.Add(this.btnPokracovat);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Konec";
            this.Text = "Konec hry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnPokracovat;
        private System.Windows.Forms.Button btnSaveGame;
        private System.Windows.Forms.Button btnKonec;
    }
}