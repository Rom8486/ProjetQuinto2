//using Newtonsoft.Json;
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
        Mots mots = new Mots();
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
            mot.Texte = tbMot.Text;
           
            mots.Add(mot);
            tbMot.Clear();
            Serialisation.SaveJson(@"C:\Windows\Temp\MotsJson.json", mots);
            
            




        }
    }
}
