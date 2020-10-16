using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetQuinto
{
    class MotADeviner
    {

        static void NbreEssais(object sender, EventArgs e)
        {
            //if (bouton != /*MotAléatoire*/)
            //{
            //    tbNbrEssais--;
            //}
            //else
            //{
            //    tbNreEssais = same
            //}
            //Si la touche cliquée = mauvaise touche.NreEssais = NbreEssais - 1;
        }

        static void RévélationDesMots()
        {

            // Méthode pour splitter une string en chaÎne de caractères
            // On aura une string de mot 
            String s = "robot";
            char[] charArray = s.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }

            // Il faut décompoer la string de mots en lettres individuelles
            // Peur être mettre en paramètres de la texte box --> PasswordChar = true;
            // Pour chaque lettre individuelle qui correspond à la touche que l'on a tapé, on la découvre du mot indice.
            // For each caractère dans la texte box, mettre une barre en-dessous du caractère.
            // Pour chaque mot qui se trouve dans la texte box, chque lettre de chaque mot  est remplacée par un "underscore"
            // Dès que l'on trouve la ou les bonne(s) letttre(s) du mot recherché, on la dévoile et supprime le "underscore"
        }

        static void NbrEssaisRestant()
        {
            //NbrEssaisRestant = le nombre d'essais en début de partie - le nombre d'erreur


        }
    }
}
