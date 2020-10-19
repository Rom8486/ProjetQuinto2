using System;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace ProjetQuinto
{
    public class Mot
    {
        private int _longueur;
        private string _MotInitial;
        private string _MotEncours;
        private int _lettresDecouvetes;
        private int _motinitialeunderscore;
        

        public string MotInitial { get => _MotInitial; set => _MotInitial = value; }
        public string MotEncours { get => _MotEncours; set => _MotEncours = value; }
        public int LettresDecouvetes { get => _lettresDecouvetes; set => _lettresDecouvetes = value; }
        public int Motinitialeunderscore { get => _motinitialeunderscore; set => _motinitialeunderscore = value; }

        public Mot()
        {
        }
        
       



        public string MettreTirets(string mot)
        {
            string resultat = "";
            int longueur = mot.Length;
            for (int i = 0; i < longueur; i++)
            {
                resultat += "*";
            }
            return resultat;
        }

        public static int[] CheckerLettreTableauEntier(string MotADeviner, char lettre)
        {
            int longueur = MotADeviner.Length;
            int[] tableau = new int[longueur];

            for (int i = 0; i < longueur; i++)
            {
                if (MotADeviner[i] == lettre)
                {
                    tableau[i] = 1;
                }
                else
                {
                    tableau[i] = 0;
                }
            }
            return tableau;
        }
        public static string AssemblageChaines(string chaine1, string chaine2)
        {
            int longueur = chaine1.Length;
            char[] tab = new char[longueur];
            for (int i = 0; i < longueur; i++)
            {
                if (chaine1[i]!='_')
                {
                    tab[i] = chaine1[i];
                }
                else if (chaine2[i]!='_')
                {
                    tab[i] = chaine2[i];
                }
                else
                {
                    tab[i] = '_';
                }
            }
            string ChaineAssemble = new string(tab);
            return ChaineAssemble;
        }

        public static string GetMotInitialUnderScore(string MotInitial)
        {
            int longueur = MotInitial.Length;
            char[] tab = new char[longueur];
            for (int i = 0; i < longueur; i++)
            {
                tab[i] = '_';
            }
            string ChaineUnderScore = new string(tab);
            return ChaineUnderScore;
        }



        public static string CheckerLettre2(string MotADeviner, char lettre/*, params int[] tabInt*/)
        {
            int longueur = MotADeviner.Length;
            char[] tableau = new char[longueur];



            for (int i = 0; i < longueur; i++)
            {
                if (MotADeviner[i] == lettre)
                {
                    tableau[i] = MotADeviner[i];
                }
                else
                {
                    if (MotADeviner[i] != '_')
                    {
                        tableau[i] = MotADeviner[i];
                    }
                    else
                    {
                        tableau[i] = '_';
                    }
                    
                }
            }
            string NlleChaine = new string(tableau);
            return NlleChaine;
        }

        public static char[] CheckerLettreRetourTableau(string MotADeviner, char lettre/*, params int[] tabInt*/)
        {
            int longueur = MotADeviner.Length;
            char[] tableau = new char[longueur];



            for (int i = 0; i < longueur; i++)
            {
                if (MotADeviner[i] == lettre)
                {
                    tableau[i] = MotADeviner[i];
                }
                else
                {
                    tableau[i] = '_';
                }
            }
            return tableau;
        }
        public static bool IsMotValideFacile(string value)
        {
            if (value == null || value.Trim().Length < 5 || value.Trim().Length > 8) return false;

            foreach (char caractere in value)
            {
                if (!char.IsLetter(caractere)) return false;
            }
            return true;
        }
        public static bool IsMotValideDifficile(string value)
        {
            if (value == null || value.Trim().Length < 8 || value.Trim().Length > 10) return false;

            foreach (char caractere in value)
            {
                if (!char.IsLetter(caractere)) return false;
            }
            return true;
        }
        public static bool IsMotValideExpert (string value)
        {
            if (value == null || value.Trim().Length < 10) return false;

            foreach (char caractere in value)
            {
                if (!char.IsLetter(caractere)) return false;
            }
            return true;
        }


    }
}