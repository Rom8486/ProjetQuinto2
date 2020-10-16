using System;
using System.Windows.Forms;

namespace ProjetQuinto
{
    public class Mot
    {
        int longueur = 0;
        string texte = "";

        public string Texte { get => texte; set => texte = value; }

        public Mot()
        {
        }

        
        public static bool IsMotValideFacile (string value) 
        {
            value.ToUpper();
            if (value == null || value.Trim().Length < 5 || value.Trim().Length > 8) return false;
            foreach (char carac in value)
            {
                
                if (!char.IsLetter(carac)) return false;
            }
            
            return true;
        }
        public static bool IsMotValideDifficile (string value) 
        {
            value.ToUpper();
            if (value == null ||value.Trim().Length< 8 || value.Trim().Length > 10) return false;
            foreach (char carac in value)
            {
                
                if (!char.IsLetter(carac)) return false;
            }
            return true;
        }
        public static bool IsMotValideExpert(string value)
        {
            value.ToUpper();
            if (value == null || value.Trim().Length < 10) return false;
            foreach (char carac in value)
            {
                
                if (!char.IsLetter(carac)) return false;
            }
            return true;
        }
    }
    
}