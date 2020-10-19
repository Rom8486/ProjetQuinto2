using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetQuinto
{
    public partial class Lexique : Form
    {


        Mots motsFacile = new Mots();
        Mots motsDifficile = new Mots();
        Mots motsExpert = new Mots();

        public Lexique()
        {
            InitializeComponent();
           DeserializeAll();
            

            
        }
        private static Lexique _instance;

     

        public static Lexique GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Lexique();
            }
            return _instance;
        }

      

        private void Lexique_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            SerializeAll();
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            Mot mot = new Mot();

            if (Mot.IsMotValideFacile(tbMot.Text))
            {

                mot.MotInitial = tbMot.Text;
                motsFacile.Add(mot);
                tbMot.Clear();

            }

            else if (Mot.IsMotValideDifficile(tbMot.Text))
            {
                mot.MotInitial = tbMot.Text;
                motsDifficile.Add(mot);
                tbMot.Clear();

            }


            else if (Mot.IsMotValideExpert(tbMot.Text))
            {
                mot.MotInitial = tbMot.Text;
                motsExpert.Add(mot);
                tbMot.Clear();


            }
        }
            //    else
            //    {
            //        MessageBox.Show("Mot entré dans le lexique incorrect", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }



            //}

            //private void tbMot_Validating(object sender, CancelEventArgs e)
            //{
            //    mot.Texte = tbMot.Text;
            //    if (!Mot.IsMotValideFacile(tbMot.Text))
            //    {
            //        epLexique.SetError(btnValider, "Mot invalide");
            //    }
            //    else
            //    {
            //        epLexique.SetError(btnValider, string.Empty);
            //    }

            //}
            public void SerializeAll()
        {
            Serialisation.SaveJson(@"C:\Windows\Temp\MotsFacileJson.json", motsFacile);
            Serialisation.SaveJson(@"C:\Windows\Temp\MotsDifficileJson.json", motsDifficile);
            Serialisation.SaveJson(@"C:\Windows\Temp\MotsExpertJson.json", motsExpert);
            
        }

        private void Lexique_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Lexique_Load(object sender, EventArgs e)
        {
            
        }
        //public static void ChargerMots()
        //{
        //    Random rand = new Random();
        //    if (joueur.Niveaudifficulte == "Facile")
        //    {

        //        int index = rand.Next(motsFacile.Count);
        //        Mot mot = motsFacile.ElementAt(index);
        //       // tbEssai.Text = mot.MotInitial;
        //    }
        //    else if (joueur.Niveaudifficulte == "Difficile")
        //    {

        //        int index = rand.Next(motsDifficile.Count);
        //        Mot mot = motsDifficile.ElementAt(index);
        //      //  tbEssai.Text = mot.MotInitial;
        //    }
        //    else if (joueur.Niveaudifficulte == "Expert")
        //    {
        //        int index = rand.Next(motsExpert.Count);
        //        Mot mot = motsExpert.ElementAt(index);
        //      //  tbEssai.Text = mot.MotInitial;
        //    }


        //}   
        public void DeserializeAll()
        {

            motsFacile = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsFacileJson.json", typeof(Mots));
            motsDifficile = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsDifficileJson.json", typeof(Mots));
            motsExpert = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsExpertJson.json", typeof(Mots));

        }
    }
    
}

