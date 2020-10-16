using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetQuinto
{
    public partial class MdiMère : Form
    {
        Interface_jeux interface_jeux = new Interface_jeux();

        public MdiMère()
        {
            
            InitializeComponent();
            
            btnQuitter.Click += btnQuitter_Click;
        }

        #region Singletons Nouvelle Partie & Lexique
        private void nouvellePartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interface_jeux interface_jeux = Interface_jeux.GetInstance();
            interface_jeux.MdiParent = this;
            interface_jeux.Show();
        }

        private void lexiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lexique lexique = Lexique.GetInstance();
            lexique.MdiParent = this;
            lexique.Show();
        }
        #endregion

        #region Thèmes
        private void bntFondEcranOcean_Click(object sender, EventArgs e)
        {
            
            Image monImage = new Bitmap(@"C:\Users\CDA\source\repos\ProjetQuinto2\Fonds écran\Océan.jpg");
            this.BackgroundImage = monImage;

            if (btnFondEcranOcean.Checked)
            {
                btnFondEcranNatureSauvage.Checked = false;
                btnFondEcranCasino.Checked = false;
                btnFondEcranQuinto.Checked = false;
                btnFondEcranClassique.Checked = false;
            }
        }
        private void btnFondEcranNatureSauvage_Click(object sender, EventArgs e)
        {
            Image monImage = new Bitmap(@"C:\Users\CDA\source\repos\ProjetQuinto2\Fonds écran\Nature Sauvage.jpg");
            this.BackgroundImage = monImage;

            if (btnFondEcranNatureSauvage.Checked)
            {
                btnFondEcranOcean.Checked = false;
                btnFondEcranCasino.Checked = false;
                btnFondEcranQuinto.Checked = false;
                btnFondEcranClassique.Checked = false;
            }
        }
        private void btnFondEcranCasino_Click(object sender, EventArgs e)
        {
            Image monImage = new Bitmap(@"C:\Users\CDA\source\repos\ProjetQuinto2\Fonds écran\Casino.jpg");
            this.BackgroundImage = monImage;
           
            if (btnFondEcranCasino.Checked)
            {
                btnFondEcranOcean.Checked = false;
                btnFondEcranNatureSauvage.Checked = false;
                btnFondEcranQuinto.Checked = false;
                btnFondEcranClassique.Checked = false;
            }
        }
        private void btnFondEcranQuinto_Click(object sender, EventArgs e)
        {
            if (btnFondEcranQuinto.Checked)
            {
                btnFondEcranOcean.Checked = false;
                btnFondEcranNatureSauvage.Checked = false;
                btnFondEcranCasino.Checked = false;
                btnFondEcranClassique.Checked = false;   
            }

            Image monImage = new Bitmap(@"C:\Users\CDA\source\repos\ProjetQuinto2\Fonds écran\Quinto.jpg");
            this.BackgroundImage = monImage;
        }
        private void btnFondEcranClassique_Click(object sender, EventArgs e)
        {
            if (btnFondEcranClassique.Checked)
            {
                btnFondEcranOcean.Checked = false;
                btnFondEcranNatureSauvage.Checked = false;
                btnFondEcranCasino.Checked = false;
                btnFondEcranQuinto.Checked = false;
            }
           
            BackColor = MdiMère.DefaultBackColor; // Ne marche pas; à revoir.
           

        }
        #endregion

        #region Règles du jeu
        private void btnReglesJeu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("                                                   Le Quinto\n" + 
                "\nLe quinto est un jeu d'origine péruvienne qui se joue en 2 à 5 manches." +
                "Le but du quinto est simple, il s'agit de découvrir les mots cachés." +
                "Pour de plus amples informations, nous vous renvoyons" +
                "sur le très complet article de Wikipédia que vous trouverez à l'adresse suivante:\n" +
                "https://fr.wikipedia.org/wiki/Le_Pendu_(jeu)", 
                "Règles du jeu", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        #endregion

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
