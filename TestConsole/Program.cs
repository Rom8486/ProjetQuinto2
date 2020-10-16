using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //String s = "robot";
            //char[] charArray = s.ToCharArray();

            //foreach (char c in charArray)
            //{
            //    Console.WriteLine(c);
            //}

            //}
            // Console.WriteLine(MettreTirets("romain"));
            //string texte = CheckerLettre2("tabulateur", 'u');
            //foreach (int item in tableau)
            //{
            //    Console.Write(item.ToString()+" ");
            //}

            //int [] tab=CheckerLettre("alphabet",'a');
            //foreach (int item in tab)
            //{
            //    Console.Write(item + "  ");
            //}
            //  Console.WriteLine(texte); 


            Console.WriteLine(GetMotInitialUnderScore("lapin"));
        }
        public static string MettreTirets(string mot)
        {
            string resultat = "";
            int longueur = mot.Length;
            for (int i = 0; i < longueur; i++)
            {
                resultat += "_ ";
            }
            return resultat;


        }
        public static int[] CheckerLettre(string MotADeviner, char lettre)
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
        public static string CheckerLettre2(string MotADeviner, char lettre)
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
            string NlleChaine = new string(tableau);
            return NlleChaine;
            

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
    }
}