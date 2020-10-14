namespace ProjetQuinto
{
    partial class MdiMère
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnNouvellePartie = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvellePartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFondEcranOcean = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFondEcranNatureSauvage = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFondEcranCasino = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFondEcranQuinto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFondEcranClassique = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReglesJeu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTopScores = new System.Windows.Forms.ToolStripMenuItem();
            this.lexiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNouvellePartie,
            this.btnOptions,
            this.btnReglesJeu,
            this.btnTopScores,
            this.lexiqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnNouvellePartie
            // 
            this.btnNouvellePartie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvellePartieToolStripMenuItem,
            this.toolStripSeparator1,
            this.btnQuitter});
            this.btnNouvellePartie.Name = "btnNouvellePartie";
            this.btnNouvellePartie.Size = new System.Drawing.Size(54, 20);
            this.btnNouvellePartie.Text = "Fichier";
            // 
            // nouvellePartieToolStripMenuItem
            // 
            this.nouvellePartieToolStripMenuItem.Name = "nouvellePartieToolStripMenuItem";
            this.nouvellePartieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouvellePartieToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.nouvellePartieToolStripMenuItem.Text = "Nouvelle Partie";
            this.nouvellePartieToolStripMenuItem.Click += new System.EventHandler(this.nouvellePartieToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.btnQuitter.Size = new System.Drawing.Size(197, 22);
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemes});
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.btnOptions.Size = new System.Drawing.Size(61, 20);
            this.btnOptions.Text = "Options";
            // 
            // btnThemes
            // 
            this.btnThemes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFondEcranOcean,
            this.btnFondEcranNatureSauvage,
            this.btnFondEcranCasino,
            this.btnFondEcranQuinto,
            this.btnFondEcranClassique});
            this.btnThemes.Name = "btnThemes";
            this.btnThemes.Size = new System.Drawing.Size(116, 22);
            this.btnThemes.Text = "Thèmes";
            // 
            // btnFondEcranOcean
            // 
            this.btnFondEcranOcean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFondEcranOcean.CheckOnClick = true;
            this.btnFondEcranOcean.Name = "btnFondEcranOcean";
            this.btnFondEcranOcean.Size = new System.Drawing.Size(157, 22);
            this.btnFondEcranOcean.Text = "Océan";
            this.btnFondEcranOcean.Click += new System.EventHandler(this.bntFondEcranOcean_Click);
            // 
            // btnFondEcranNatureSauvage
            // 
            this.btnFondEcranNatureSauvage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFondEcranNatureSauvage.CheckOnClick = true;
            this.btnFondEcranNatureSauvage.Name = "btnFondEcranNatureSauvage";
            this.btnFondEcranNatureSauvage.Size = new System.Drawing.Size(157, 22);
            this.btnFondEcranNatureSauvage.Text = "Nature Sauvage";
            this.btnFondEcranNatureSauvage.Click += new System.EventHandler(this.btnFondEcranNatureSauvage_Click);
            // 
            // btnFondEcranCasino
            // 
            this.btnFondEcranCasino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFondEcranCasino.CheckOnClick = true;
            this.btnFondEcranCasino.Name = "btnFondEcranCasino";
            this.btnFondEcranCasino.Size = new System.Drawing.Size(157, 22);
            this.btnFondEcranCasino.Text = "Casino";
            this.btnFondEcranCasino.Click += new System.EventHandler(this.btnFondEcranCasino_Click);
            // 
            // btnFondEcranQuinto
            // 
            this.btnFondEcranQuinto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFondEcranQuinto.CheckOnClick = true;
            this.btnFondEcranQuinto.Name = "btnFondEcranQuinto";
            this.btnFondEcranQuinto.Size = new System.Drawing.Size(157, 22);
            this.btnFondEcranQuinto.Text = "Quinto";
            this.btnFondEcranQuinto.Click += new System.EventHandler(this.btnFondEcranQuinto_Click);
            // 
            // btnFondEcranClassique
            // 
            this.btnFondEcranClassique.CheckOnClick = true;
            this.btnFondEcranClassique.Name = "btnFondEcranClassique";
            this.btnFondEcranClassique.Size = new System.Drawing.Size(157, 22);
            this.btnFondEcranClassique.Text = "Classique";
            this.btnFondEcranClassique.Click += new System.EventHandler(this.btnFondEcranClassique_Click);
            // 
            // btnReglesJeu
            // 
            this.btnReglesJeu.Name = "btnReglesJeu";
            this.btnReglesJeu.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.btnReglesJeu.Size = new System.Drawing.Size(89, 20);
            this.btnReglesJeu.Text = "Règles du jeu";
            this.btnReglesJeu.Click += new System.EventHandler(this.btnReglesJeu_Click);
            // 
            // btnTopScores
            // 
            this.btnTopScores.Name = "btnTopScores";
            this.btnTopScores.Size = new System.Drawing.Size(76, 20);
            this.btnTopScores.Text = "Top Scores";
            // 
            // lexiqueToolStripMenuItem
            // 
            this.lexiqueToolStripMenuItem.Name = "lexiqueToolStripMenuItem";
            this.lexiqueToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.lexiqueToolStripMenuItem.Text = "Lexique";
            this.lexiqueToolStripMenuItem.Click += new System.EventHandler(this.lexiqueToolStripMenuItem_Click);
            // 
            // MdiMère
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MdiMère";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnNouvellePartie;
        private System.Windows.Forms.ToolStripMenuItem nouvellePartieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnQuitter;
        private System.Windows.Forms.ToolStripMenuItem btnOptions;
        private System.Windows.Forms.ToolStripMenuItem btnThemes;
        private System.Windows.Forms.ToolStripMenuItem btnFondEcranOcean;
        private System.Windows.Forms.ToolStripMenuItem btnFondEcranNatureSauvage;
        private System.Windows.Forms.ToolStripMenuItem btnFondEcranCasino;
        private System.Windows.Forms.ToolStripMenuItem btnReglesJeu;
        private System.Windows.Forms.ToolStripMenuItem btnTopScores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnFondEcranQuinto;
        private System.Windows.Forms.ToolStripMenuItem btnFondEcranClassique;
        private System.Windows.Forms.ToolStripMenuItem lexiqueToolStripMenuItem;
    }
}

