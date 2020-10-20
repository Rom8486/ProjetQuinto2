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
            this.components = new System.ComponentModel.Container();
            this.btnValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPseudo = new System.Windows.Forms.TextBox();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(300, 64);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(98, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrez votre pseudo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score";
            // 
            // tbPseudo
            // 
            this.tbPseudo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPseudo.Location = new System.Drawing.Point(12, 67);
            this.tbPseudo.Name = "tbPseudo";
            this.tbPseudo.Size = new System.Drawing.Size(139, 20);
            this.tbPseudo.TabIndex = 1;
            this.tbPseudo.Validating += new System.ComponentModel.CancelEventHandler(this.tbPseudo_Validating);
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(188, 67);
            this.tbScore.Name = "tbScore";
            this.tbScore.ReadOnly = true;
            this.tbScore.Size = new System.Drawing.Size(81, 20);
            this.tbScore.TabIndex = 0;
            this.tbScore.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // interface_Victoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 170);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.tbPseudo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValider);
            this.Name = "interface_Victoire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Victoire";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.interface_Victoire_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPseudo;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}