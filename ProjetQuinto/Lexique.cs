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
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            Mot mot = new Mot();
           
            if (Mot.IsMotValideFacile(tbMot.Text))
            {

                mot.Texte = tbMot.Text;
                motsFacile.Add(mot);
                tbMot.Clear();
               
            }
            
            else if (Mot.IsMotValideDifficile(tbMot.Text))
            {
                mot.Texte = tbMot.Text;
                motsDifficile.Add(mot);
                tbMot.Clear();
              
            }
           
            
           else if (Mot.IsMotValideExpert(tbMot.Text))
            {
                mot.Texte = tbMot.Text;
                motsExpert.Add(mot);
                tbMot.Clear();
           
            }
            else
            {
                MessageBox.Show("Mot entré dans le lexique incorrect", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

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
            SerializeAll();
        }

        private void Lexique_Load(object sender, EventArgs e)
        {
            motsFacile = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsFacileJson.json", typeof(Mots));
            foreach (var item in motsFacile)
            {
                lbMots.Items.Add(item.Texte);
            }
            motsDifficile=(Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsDifficileJson.json", typeof(Mots));
            foreach (var item in motsDifficile)
            {
                lbMots.Items.Add(item.Texte);
            }
            motsExpert = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsExpertJson.json", typeof(Mots));
            foreach (var item in motsExpert)
            {
                lbMots.Items.Add(item.Texte);
            }
        }
    }
    //public void DeserializeAll()
    //{

    //    Mots mots = (Mots)Serialisation.LoadJson(@"C:\Windows\Temp\MotsFacileJson.json", typeof(Mots));
    //    foreach (var item in mots)
    //    {
          
    //    }
    //    //Serialisation.LoadJson(@"C:\Windows\Temp\MotsDifficileJson.json", typeof(Mots));
    //    //Serialisation.LoadJson(@"C:\Windows\Temp\MotsExpertJson.json", typeof(Mots));

    //}
}

