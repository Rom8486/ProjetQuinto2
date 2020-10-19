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
using System.Security.Cryptography;
//using System.Threading;


namespace ProjetQuinto
{
    public partial class Interface_jeux : Form
    {
        Mot mot = new Mot();
        Joueur joueur = new Joueur();
        
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

        int duree = 0;
        
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
       

        public void CreationTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            timer.Start();
            //Penser à stopper timer à la fin de la manche
        }
        

        public DateTime TempsDebut()
        {
            DateTime TpsDebut = DateTime.Now;
            return TpsDebut;
        }
        public DateTime TempsFin()
        {
            DateTime TpsFin = DateTime.Now;
            return TpsFin;
        }
        public int CalculerTemps(DateTime tpsDebut, DateTime tpsFin)
        {
            TimeSpan span = (tpsFin - tpsDebut);
            int resultat = (int)span.TotalSeconds;
            return resultat;
        }


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
                    pnlClavier.Enabled = false;
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
                    break;
                case Contextes.Between2Games:
                    GestionnaireContextes(Contextes.Initial); //Redondant mais pour se souvenir que Between2Games est le même contexte que Contextes.Initial
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Evenements
        private void btnA_Click(object sender, EventArgs e)
        {
            Button bouton = sender as Button;
            char lettre =bouton.Text[0];
            bool MauvauseProposition = false;

            for (int i = 0; i < mot.MotInitial.Length; i++)
            {
                
                char[] tab = mot.MotInitial.ToUpper().ToCharArray();
                if (tab[i]== lettre)
                {
                    tbMotADeviner.Text= tbMotADeviner.Text.Remove(i, 1).Insert(i, lettre.ToString());
                    MauvauseProposition = true;
                }
               
            }
            if (!tbMotADeviner.Text.Contains('*'))
            {
                MessageBox.Show("Gagné!!");
                joueur.NbManchesRemportees++;
                textBox2.Text = joueur.NbManchesRemportees.ToString();
            }
            if (MauvauseProposition==false)
            {
                joueur.NbEssaiRestant--;
            }
            tbNbrEssais.Text = joueur.NbEssaiRestant.ToString();
            if (joueur.NbEssaiRestant==0)
            {
               DialogResult dia= MessageBox.Show("Vous avez perdu! Voulez vous rejouer?", "Perdu!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dia==DialogResult.Yes)
                {
                    GestionnaireContextes(Contextes.Initial);
                }
                else if (dia == DialogResult.No)
                {
                    this.Close();
                }


            }

            
          

            bouton.Enabled = false;
           
        }

        static bool RemplacerLettre(char lettre, string motaDecouvrir, string motEnCoursDecouverte)
        {
            int nbrEssais;
            bool resultat;
            char[] tabChar = motaDecouvrir.ToCharArray();

            resultat = false;

            for (int i = 0; i < motEnCoursDecouverte.Length; i++)
            {
                if (motEnCoursDecouverte[i] == lettre)
                {
                    return true;
                    tabChar[i] = lettre;

                    if (resultat == true)
                    {
                        motaDecouvrir = tabChar.ToString();
                    }
                    else
                    {
                        nbrEssais--;
                    }
                }
            }
            return resultat;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                Mots mots = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsFacileJson.json", typeof(Mots));
                foreach (var mot in mots)
                {
                    tbEssai2.Text += mot.MotInitial + " ";
                    
                }
                mot =Mots.ChargerMot(mots);
            }
            else if (radioButton2.Checked)
            {
                Mots mots = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsDifficileJson.json", typeof(Mots));
                foreach (var mot in mots)
                {
                    tbEssai2.Text += mot.MotInitial + " ";
                   
                }
                mot = Mots.ChargerMot(mots);
            }
            else if (radioButton3.Checked)
            {
                Mots mots = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsExpertJson.json", typeof(Mots));
                foreach (var mot in mots)
                {
                    tbEssai2.Text += mot.MotInitial + " ";
                    
                }
                mot =Mots.ChargerMot(mots);
            }
           
            
            tbEssai2.Text = mot.MotInitial.ToUpper();
            CreationTimer();
            GestionnaireContextes(Contextes.GameStarted);
            btnStart.Enabled = false;

            joueur.NbEssaiRestant = 7;
            tbNbrEssais.Text = joueur.NbEssaiRestant.ToString();
           
            
            tbMotADeviner.Text = mot.MettreTirets(mot.MotInitial);



        }
        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            duree++;
            tbTimer.Text = duree.ToString();   
        }

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

        #region Radio Buttons
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                GestionnaireContextes(Contextes.StartGame);
                //GestionDifficulte(NiveauDifficulte.facile);
                int manche = 3;
                textBox3.Text = manche.ToString();
                
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
               GestionnaireContextes(Contextes.StartGame);
               //GestionDifficulte(NiveauDifficulte.difficile);
                int manche = 4;
                textBox3.Text = manche.ToString();

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                GestionnaireContextes(Contextes.StartGame);
                //Joueur.GestionDifficulte(NiveauDifficulte.expert);
                int manche = 5;
                textBox3.Text = manche.ToString();
                //Mots essai = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsExpertJson.json", typeof(Mots));
                //foreach (var item in essai)
                //{
                //    tbMotADeviner.Text += $"{item.Texte} ";
                //}
            }
        }
       
        

        #endregion

        private void tbMotADeviner_TextChanged(object sender, EventArgs e)
        {
            //RemplacerparTirer();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int manche = 1;
            textBox2.Text = manche.ToString();

        }

    }
}
