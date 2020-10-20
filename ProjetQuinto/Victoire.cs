using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
//using static ProjetQuinto.Interface_jeux;

namespace ProjetQuinto
{
    public partial class interface_Victoire : Form
    {
        Joueur joueur;
        HashsetJoueurs listeJoueurs = new HashsetJoueurs();
        ErrorProvider ep = new ErrorProvider();

        public interface_Victoire()
        {
            InitializeComponent();
            tbScore.Text = joueur.NbPoints.ToString();
        }


        #region Singleton
        private static interface_Victoire _instance;

        public static interface_Victoire GetInstance()
        {
            if (_instance == null)
            {
                _instance = new interface_Victoire();
            }
            return _instance;
        }
        private void interface_Victoire_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        #endregion

        #region Evenements
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (IsChampsValid() == true)
            {
                Joueur joueur = new Joueur();
                joueur.Pseudo = tbPseudo.Text;
                listeJoueurs.Add(joueur);
                Serialisation.SaveJson(@"C:\Windows\Temp\Toplayers.json", listeJoueurs);
                DialogResult result = MessageBox.Show("Félicitations, vous faites désormais partie\n" +
                    "du Top 10 des meilleurs joueurs de tous les temps.\n" +
                    "Souhaitez-vous refaire une partie?", "////***Congratulations!!!***\\\\",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    tbPseudo.Clear();
                    tbScore.Clear();

                    //Faudrait faire un gestionnaire de contextes qui renvoie au menu principal du jeu
                }
                else
                {
                    this.Close();
                    interface_Victoire.ActiveForm.Close();
                }
            }
        }
        #endregion

        #region Méthode globale de vérification des champs du salarié
        private bool IsChampsValid()
        {
            ErrorProvider ep = new ErrorProvider();

            bool valid = true;

            if (!Joueur.IsPseudoValid(tbPseudo.Text))
            {
                ep.SetError(tbPseudo, "Le pseudo est incorrect");
                return false;
            }
            else
            {
                ep.SetError(tbPseudo, "");

            }
            return valid;

        }
        #endregion

        #region Méthode validating
        private void tbPseudo_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider ep = new ErrorProvider();

            if (!Joueur.IsPseudoValid(tbPseudo.Text))
            {
                ep.SetError(tbPseudo, "Le pseudo est incorrect");
                
            }
            else
            {
                ep.SetError(tbPseudo, "");

            }

        }
        #endregion
    }
}
