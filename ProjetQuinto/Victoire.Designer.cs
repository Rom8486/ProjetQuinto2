namespace ProjetQuinto
{
    partial class interface_Victoire
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
            this.btnValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPseudo = new System.Windows.Forms.TextBox();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.btnOuiVictoire = new System.Windows.Forms.Button();
            this.btnNonVictoire = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(300, 41);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(98, 23);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrez votre pseudo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score";
            // 
            // tbPseudo
            // 
            this.tbPseudo.Location = new System.Drawing.Point(12, 44);
            this.tbPseudo.Name = "tbPseudo";
            this.tbPseudo.Size = new System.Drawing.Size(139, 20);
            this.tbPseudo.TabIndex = 3;
            //this.tbPseudo.TextChanged += new System.EventHandler(this.tbPseudo_TextChanged);
            this.tbPseudo.Validating += new System.ComponentModel.CancelEventHandler(this.tbPseudo_Validating);
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(188, 44);
            this.tbScore.Name = "tbScore";
            this.tbScore.ReadOnly = true;
            this.tbScore.Size = new System.Drawing.Size(81, 20);
            this.tbScore.TabIndex = 3;
            // 
            // btnOuiVictoire
            // 
            this.btnOuiVictoire.Location = new System.Drawing.Point(101, 122);
            this.btnOuiVictoire.Name = "btnOuiVictoire";
            this.btnOuiVictoire.Size = new System.Drawing.Size(75, 23);
            this.btnOuiVictoire.TabIndex = 4;
            this.btnOuiVictoire.Text = "Oui";
            this.btnOuiVictoire.UseVisualStyleBackColor = true;
            this.btnOuiVictoire.Click += new System.EventHandler(this.btnOuiVictoire_Click);
            // 
            // btnNonVictoire
            // 
            this.btnNonVictoire.Location = new System.Drawing.Point(233, 122);
            this.btnNonVictoire.Name = "btnNonVictoire";
            this.btnNonVictoire.Size = new System.Drawing.Size(75, 23);
            this.btnNonVictoire.TabIndex = 4;
            this.btnNonVictoire.Text = "Non";
            this.btnNonVictoire.UseVisualStyleBackColor = true;
            this.btnNonVictoire.Click += new System.EventHandler(this.btnNonVictoire_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Souhaitez-vous refaire une partie?";
            // 
            // interface_Victoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 170);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNonVictoire);
            this.Controls.Add(this.btnOuiVictoire);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.tbPseudo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValider);
            this.Name = "interface_Victoire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Victoire";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.interface_Victoire_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPseudo;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.Button btnOuiVictoire;
        private System.Windows.Forms.Button btnNonVictoire;
        private System.Windows.Forms.Label label3;
    }
}