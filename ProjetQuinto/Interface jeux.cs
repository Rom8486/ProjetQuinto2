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
//using System.Threading;


namespace ProjetQuinto
{
    public partial class Interface_jeux : Form
    {
       
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
        /// <summary>
        /// Fonctions
        /// </summary>
        /// 

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

        #region Gestionnaires des contextes
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
            tbMotADeviner.Text += bouton.Text;
            bouton.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CreationTimer();
            GestionnaireContextes(Contextes.GameStarted);
            btnStart.Enabled = false;
            Mots essai = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsJson.json", typeof(Mots));
            foreach (var item in essai)
            {
                tbMotADeviner.Text += $"{item.Texte} ";
            }

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
                //GestionDifficulte(NiveauDifficulte.expert);
                int manche = 5;
                textBox3.Text = manche.ToString();
            }
        }
        #endregion

    }
}
