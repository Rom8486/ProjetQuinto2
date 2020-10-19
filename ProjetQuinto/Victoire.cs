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

namespace ProjetQuinto
{
    public partial class interface_Victoire : Form
    {
        Joueur joueur;



        Mots pseudo = new Mots();
        ErrorProvider ep = new ErrorProvider();
        //Mots score = new Mots(); Score n'est pas un mot

        public interface_Victoire()
        {
            InitializeComponent();
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
        //private void btnValider_Click(object sender, EventArgs e)
        //{

        //    Mot mot = new Mot();
        //    //A explorer
        //    //if (tbPseudo.Text!=null)
        //    //{

        //    //    joueur.Pseudo = tbPseudo.Text;
        //    //    pseudo.Add(mot);
        //    //    tbPseudo.Clear();

        //    //}
        //    Serialisation.SaveJson(@"C:\Windows\Temp\Toplayers.json", pseudo);

        //}

        //private void Victoire_Load(object sender, EventArgs e)
        //{
        //    pseudo = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\Toplayers.json", typeof(Mots));
        //    foreach (var item in pseudo)
        //    {
        //        tbPseudo.Items.Add(item.Texte);
        //    }
        //}

        private void btnOuiVictoire_Click(object sender, EventArgs e)
        {
            this.Close();
            //GestionnaireContextes(Contextes.Initial); Comment faire pour que le gestionnaire de contexte puisse être pris en compte ici?
        }

        private void btnNonVictoire_Click(object sender, EventArgs e)
        {

            this.Close();
            Interface_jeux.ActiveForm.Close(); // Problème: Ferme tout l'application
        }
        #endregion

        #region Méthodes Vérification
        private void tbPseudo_Validating(object sender, CancelEventArgs e)
        {
            Mot mot = new Mot();

            mot.MotInitial = tbPseudo.Text;
            //if (!IsPseudoValid(tbPseudo.Text))
            //{
            //    ep.SetError(btnValider, "Pseudo invalide");
            //}
            //else
            //{
            //    ep.SetError(btnValider, string.Empty);
            //}
        }

      
        #endregion
    }
}
