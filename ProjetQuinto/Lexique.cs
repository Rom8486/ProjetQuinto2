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
            mot.Texte= tbMot.Text;
            SaveJson(mot);
            tbMot.Clear();



        }
        public void SaveJson(Mot mot)
        {
            string filepath = @"c:\Windows\temp\MotsJson.json";
            JsonSerializer j = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(filepath, true))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                j.Serialize(writer, mot);
            }

        }

    }
}
