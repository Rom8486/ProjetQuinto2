using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Threading;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
//using System.Threading;


namespace ProjetQuinto
{
    public partial class Interface_jeux : Form
    {
        Mot mot = new Mot();
        Joueur joueur = new Joueur();
        Timer timer = new Timer();
        int duree = 0;


        //Hahstset d'essai pour charger mot en debut de manche
      //  HashSet<string> HashSetEssai = new HashSet<string>() { "table", "ribambelle", "jardinier", "pepite", "arbre", "vignoble", "heureux" };
        

        #region Singleton
        private static Interface_jeux _instance;
        public static Interface_jeux GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Interface_jeux();
            }
            return _instance;
        }
        private void Interface_jeux_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        #endregion

        

        enum Contextes
        {
            Initial = 0,
            StartGame = 1,
            GameStarted = 2,
            Between2Games = 3
        }
        
        
       
        public Interface_jeux()
        {
            InitializeComponent();
            GestionnaireContextes(Contextes.Initial);

        }

        #region Timer

        public void CreationTimer()
        {
            
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            timer.Start();

        }
        //public DateTime TempsDebut()
        //{
        //    DateTime TpsDebut = DateTime.Now;
        //    return TpsDebut;
        //}
        //public DateTime TempsFin()
        //{
        //    DateTime TpsFin = DateTime.Now;
        //    return TpsFin;
        //}
        //public int CalculerTemps(DateTime tpsDebut, DateTime tpsFin)
        //{
        //    TimeSpan span = (tpsFin - tpsDebut);
        //    int resultat = (int)span.TotalSeconds;
        //    return resultat;
        //}
        private void timer_Tick(object sender, EventArgs e)
        {
            duree++;
            tbTimer.Text = duree.ToString();
        }
        #endregion

        #region Gestionnaire Contextes

        void GestionnaireContextes(Contextes contexte)
        {
            switch (contexte)
            {
                case Contextes.Initial:
                    gbDifficulté.Enabled = true;
                    gbInformations.Enabled = false;
                    btnStart.Enabled = false;
                    lbTimer.Enabled = false;
                    tbTimer.Enabled = false;
                    lbNbreEssais.Enabled = false;
                    tbNbrEssais.Enabled = false;
                    tbMotADeviner.Enabled = false;
                    pnlClavier.Enabled = false;
                    textBox2.Text = "0";
                    break;
                case Contextes.StartGame:
                    gbDifficulté.Enabled = true;
                    gbInformations.Enabled = true;
                    btnStart.Enabled = true;
                    lbTimer.Enabled = true;
                    tbTimer.Enabled = true;
                    lbNbreEssais.Enabled = true;
                    tbNbrEssais.Enabled = true;
                    tbMotADeviner.Enabled = true;
                    pnlClavier.Enabled = true;
                    textBox2.Text = "0";
                    //textBox2.Clear();
                    break;
                case Contextes.GameStarted:
                    gbDifficulté.Enabled = false;
                    gbInformations.Enabled = true;
                    btnStart.Enabled = false;
                    lbTimer.Enabled = true;
                    tbTimer.Enabled = true;
                    lbNbreEssais.Enabled = true;
                    tbNbrEssais.Enabled = true;
                    pnlClavier.Enabled = true;
                    ReinitialiserClavier();
                    break;
                case Contextes.Between2Games:
                    gbDifficulté.Enabled = false;
                    gbInformations.Enabled = true;
                    btnStart.Enabled = true;
                    lbTimer.Enabled = true;
                    tbTimer.Enabled = true;
                    lbNbreEssais.Enabled = true;
                    tbNbrEssais.Enabled = true;
                    pnlClavier.Enabled = true;
                    textBox2.Text = joueur.NbManchesRemportees.ToString();
                    pnlClavier.Enabled = false;
                    ReinitialiserClavier();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Evenements

        private void bouton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            char lettre = button.Text[0];
            bool MauvauseProposition = false;

            for (int i = 0; i < mot.MotInitial.Length; i++)
            {
                
                char[] tab = mot.MotInitial.ToUpper().ToCharArray();
                if (tab[i]== lettre)
                {
                    tbMotADeviner.Text = tbMotADeviner.Text.Remove(i, 1).Insert(i, lettre.ToString());
                    MauvauseProposition = true;
                }

            }
            if (MauvauseProposition == false)
            {
                joueur.NbEssaiRestant--;
                joueur.NbErreurs++;
            }          
            tbNbrEssais.Text = joueur.NbEssaiRestant.ToString();

            if (!tbMotADeviner.Text.Contains('*'))
            {
                timer.Stop();
                timer.Dispose();
                duree = 0;
                MessageBox.Show("Gagné!!");
                joueur.NbManchesRemportees++;
                
                textBox2.Text = joueur.NbManchesRemportees.ToString();
                joueur.TpsParManche = int.Parse(tbTimer.Text);
                joueur.NbPoints = joueur.NbPoints + (int)joueur.CalculNbPointsParMancheSimplifie(joueur.TpsParManche, joueur.NbErreurs);
                textBox4.Text = joueur.NbPoints.ToString();
                GestionnaireContextes(Contextes.Between2Games);
                tbMotADeviner.Clear();
                tbNbrEssais.Clear();
                tbTimer.Text = "0";
                tbNbrEssais.Clear();
                
                
            }
                //if (joueur.NbManchesRemportees==joueur.NbManche)
                //{
                //    MessageBox.Show("Vous avez remporté toutes les manches!\n Felicitation!!!");
                //}
            

            tbNbrEssais.Text = joueur.NbEssaiRestant.ToString();
            if (joueur.NbEssaiRestant == 0)
            {
                DialogResult dia = MessageBox.Show("Vous avez perdu! Voulez vous rejouer?", "Perdu!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dia == DialogResult.Yes)
                {
                    GestionnaireContextes(Contextes.Initial);
                    tbMotADeviner.Clear();
                    textBox2.Clear();
                    tbTimer.Clear();
                    tbNbrEssais.Clear();
                    timer.Stop();
                }
                else if (dia == DialogResult.No)
                {
                    this.Close();
                }
            }
            button.Enabled = false;

            if (joueur.NbManchesRemportees == joueur.NbManche)
            {
                textBox2.Text = "0";
                interface_Victoire victoire = interface_Victoire.GetInstance();
                victoire.Show();

                // Si Formulaire trop compliqué, on peut se contenter d'une MessageBox
                //DialogResult resultat = MessageBox.Show("Félicitations!! Vous avez remporté la partie.\n" +
                //"Souhaitez-vous commencer une nouvelle partie?", "VICTOIRE",
                //MessageBoxButtons.YesNo);

                //if (resultat == DialogResult.Yes)
                //{
                //    textBox2.Text = string.Empty;
                //    GestionnaireContextes(Contextes.Initial);
                //}
                //else
                //{
                //    this.Close();
                //}
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                Mots mots = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsFacileJson.json", typeof(Mots));
               
                mot =Mots.ChargerMot(mots);
            }
            else if (radioButton2.Checked)
            {
                Mots mots = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsDifficileJson.json", typeof(Mots));
               
                mot = Mots.ChargerMot(mots);
            }
            else if (radioButton3.Checked)
            {
                Mots mots = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsExpertJson.json", typeof(Mots));
                
                
                mot =Mots.ChargerMot(mots);
            }
           
            
            
            CreationTimer();
            textBox2.Text = joueur.NbManchesRemportees.ToString();
            GestionnaireContextes(Contextes.GameStarted);
            //DateTime TpsDebut = TempsDebut();
            btnStart.Enabled = false;

            joueur.NbEssaiRestant = 7;
            tbNbrEssais.Text = joueur.NbEssaiRestant.ToString();
           
            
            //essai pour charger mot aleatoire à partir du hashset d'essai
           // Random aleatoire = new Random();
           // int index=aleatoire.Next(0, 5);
           // string LeMot = HashSetEssai.ElementAt(index);
           // mot.MotInitial = LeMot.ToUpper();
           tbMotADeviner.Text = mot.MettreTirets(mot.MotInitial);
            
            //FinEssai

        }
        #endregion

        #region Méthode Réinitilisation du clavier
        private void ReinitialiserClavier()
        {
            foreach (Control button in pnlClavier.Controls)
            {
                button.Enabled = true;
            }
        }
        #endregion

        #region Thème
        private void Interface_jeux_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Parent.BackgroundImage;
          
            //motsDifficile = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsDifficileJson.json", typeof(Mots));
            //foreach (var mot in motsDifficile)
            //{
            //    lbMots.Items.Add(mot.MotInitial);
            //}
            //motsExpert = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsExpertJson.json", typeof(Mots));
            //foreach (var mot in motsExpert)
            //{
            //    lbMots.Items.Add(mot.MotInitial);
            //}
           
        }
        #endregion

        #region Radio Buttons
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                GestionnaireContextes(Contextes.StartGame);
                //GestionDifficulte(NiveauDifficulte.facile);
                joueur.NbManche = 3;
                textBox3.Text = joueur.NbManche.ToString();

            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
               GestionnaireContextes(Contextes.StartGame);
                //GestionDifficulte(NiveauDifficulte.difficile);
                joueur.NbManche = 4;
                textBox3.Text = joueur.NbManche.ToString();

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                GestionnaireContextes(Contextes.StartGame);
                //Joueur.GestionDifficulte(NiveauDifficulte.expert);
                joueur.NbManche= 5;
                textBox3.Text = joueur.NbManche.ToString();
                //Mots essai = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsExpertJson.json", typeof(Mots));
                //foreach (var item in essai)
                //{
                //    tbMotADeviner.Text += $"{item.Texte} ";
                //}
            }
        }


        #endregion

        #region Brouillon

        //static bool RemplacerLettre(char lettre, string motaDecouvrir, string motEnCoursDecouverte)
        //{
        //    int nbrEssais;
        //    bool resultat;
        //    char[] tabChar = motaDecouvrir.ToCharArray();

        //    resultat = false;

        //    for (int i = 0; i < motEnCoursDecouverte.Length; i++)
        //    {
        //        if (motEnCoursDecouverte[i] == lettre)
        //        {
        //            return true;
        //            tabChar[i] = lettre;

        //            if (resultat == true)
        //            {
        //                motaDecouvrir = tabChar.ToString();
        //            }
        //            else
        //            {
        //                nbrEssais--;
        //            }
        //        }
        //    }
        //    return resultat;
        //}
        //private void btnA_Click(object sender, EventArgs e)
        //{
        //    Button bouton = sender as Button;
        //    char lettre = bouton.Text[0];
        //    bool MauvauseProposition = false;

        //    for (int i = 0; i < mot.MotInitial.Length; i++)
        //    {

        //        char[] tab = mot.MotInitial.ToCharArray();
        //        if (tab[i]== lettre)
        //        {
        //            tbMotADeviner.Text= tbMotADeviner.Text.Remove(i, 1).Insert(i, lettre.ToString());
        //            MauvauseProposition = true;
        //        }

        //    }
        //    if (!tbMotADeviner.Text.Contains('*'))
        //    {

        //        nbrManches++;
        //        textBox2.Text = nbrManches.ToString();
        //        timer.Stop();
        //        MessageBox.Show("Gagné!!");
        //        bouton.Enabled = true;
        //        GestionnaireContextes(Contextes.Between2Games);
        //        tbMotADeviner.Clear();
        //        tbNbrEssais.Clear();
        //        tbTimer.Clear();
        //        tbNbrEssais.Clear();

        //    }
        //    if (MauvauseProposition==false)
        //    {
        //        joueur.NbEssaiRestant--;
        //    }

        //    tbNbrEssais.Text = joueur.NbEssaiRestant.ToString();
        //    if (joueur.NbEssaiRestant==0)
        //    {
        //       DialogResult dia= MessageBox.Show("Vous avez perdu! Voulez vous rejouer?", "Perdu!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        //        if (dia==DialogResult.Yes)
        //        {
        //            GestionnaireContextes(Contextes.Initial);
        //            tbMotADeviner.Clear();
        //            textBox2.Clear();
        //            tbTimer.Clear();
        //            tbNbrEssais.Clear();
        //            timer.Stop();

        //        }
        //        else if (dia == DialogResult.No)
        //        {
        //            this.Close();
        //        }
        //    }

        //    bouton.Enabled = false;
        //}
        #endregion
    }
}
