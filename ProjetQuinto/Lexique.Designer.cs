﻿namespace ProjetQuinto
{
    partial class Lexique
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMot = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nouveau mot:";
            // 
            // tbMot
            // 
            this.tbMot.Location = new System.Drawing.Point(202, 168);
            this.tbMot.Name = "tbMot";
            this.tbMot.Size = new System.Drawing.Size(167, 20);
            this.tbMot.TabIndex = 1;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(403, 168);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(87, 20);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // Lexique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tbMot);
            this.Controls.Add(this.label1);
            this.Name = "Lexique";
            this.Text = "Lexique";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lexique_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMot;
        private System.Windows.Forms.Button btnValider;
    }
}