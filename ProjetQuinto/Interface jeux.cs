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
        public void CreationTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            timer.Start();
            //Penser à stopper timer à la fin de la manche

        }
      
        //public void LoadTexte()
        //{
        //    string path = @"c:\Windows\temp\Lexique.txt";
        //    using (StreamReader sr = File.OpenText(path))
        //    {
        //        string s = "";
        //        while ((s = sr.ReadLine()) != null)
        //        {
        //            string[] result = s.Split(';');
        //            for (int i = 0; i < result.Length; i++)
        //            {
        //                TbMotADeviner.Text += result[i];
        //            }


        //        }

        //    }
        //}


        public Interface_jeux()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            Button bouton = sender as Button;
            TbMotADeviner.Text += bouton.Text;
        }

        private void TbMotADeviner_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           // LoadTexte();
            CreationTimer();
            Mots essai=(Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsJson.json", typeof(Mots));
            foreach (var item in essai)
            {
                TbMotADeviner.Text += $"{item.Texte} " ²;
            }
           


        }
        private void timer_Tick(object sender, EventArgs e)
        {
            duree++;
            tbTimer.Text = duree.ToString();
            
        }




        private void Interface_jeux_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = BackgroundImage.
        }



        #region Radio Button
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {

            }
        }
        #endregion
    }
}
