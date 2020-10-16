using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetQuinto
{
    class NbreEssaisRestant
    {
        //static bool TrouverLettre(char lettre, string mot)
        //{


        //    for (int i = 0; i < length; i++)
        //    {

        //    }
        //    foreach (char c in mot)
        //    {
        //        if (lettre == c)
        //        {
        //            return true;
        //        }

        //    }
        //    return false;
        //}



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
    }
}
