using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            HashSet<string> set = new HashSet<string>()
            {
                "A", "B", "C","D", "E","F"
            };
            for (int i = 0; i < 10; i++)
            {
                int index = random.Next(set.Count);
                string lettre = set.ElementAt(index);

                Console.WriteLine(lettre);
            }
            //Console.WriteLine(Tirets("Romain"));

            //static string Tirets(string mot)
            //{
            //    string resultat = "";
            //    int longueur = mot.Length;
            //    for (int i = 0; i < longueur; i++)
            //    {
            //        resultat += "_ ";
            //    }
            //    return resultat;
            //}

            //Console.WriteLine(RemplacerLettre('A', "MANON", "*****"));


            //static bool RemplacerLettre(char lettre, string motaDecouvrir, string motEnCoursDecouverte)
            //{
            //    int nbrEssais = 8;
            //    bool resultat;
            //    char[] tabChar = motEnCoursDecouverte.ToCharArray();

            //    resultat = false;
            //    for (int i = 0; i < motaDecouvrir.Length; i++)
            //    {
                   
            //        if (motaDecouvrir[i] == lettre)
            //        {
            //            resultat = true;
            //            tabChar[i] = lettre;
            //        }
 

            //    }
            //    if (resultat == true)
            //    {
            //        motEnCoursDecouverte = new string(tabChar);
            //    }
            //    else
            //    {
            //        nbrEssais--;
            //    }
            //    return resultat;

            //}


            //static bool RemplacerLettre(char lettre, string motaDecouvrir, string motEnCoursDecouverte)
            //{
            //    int nbrEssais;
            //    bool resultat;
            //    resultat = false;
            //    char[] tabChar = motaDecouvrir.ToCharArray();


            //    for (int i = 0; i < motEnCoursDecouverte.Length; i++)
            //    {

            //        if (motaDecouvrir[i] == lettre)
            //        {
            //            tabChar[i] = lettre;
            //            resultat = true;
            //        }



            //        //if (resultat == true)
            //        //{
            //        //    motaDecouvrir = tabChar.ToString();
            //        //}
            //        //else
            //        //{
            //        //    //nbrEssais--;
            //        //}

            //    }
            //    return resultat;
            //}

            //Console.WriteLine(trouverLaLettre('i', "Aristocrate"));

            //static bool trouverLaLettre(char lettre, string mot)
            //{


            //    char[] charArray = mot.ToCharArray();
            //    bool valeur = false;

            //    foreach (char c in charArray)
            //    {
            //        if (lettre == c)
            //        {
            //            return true;
            //        }

            //    }
            //    return false;
            //}
        }


       


        //for (int i = 0; i < mot.Length; i++)
        //{
        //    bool valeur = false;

        //    if (match != mot[i])
        //    {
        //        nbreEssaisRestant--;

        //    }

        //}

        //Console.WriteLine(RemplacerparTirer("Bob"));
        //static string RemplacerparTirer(string mot)
        //{
        //    string resultat = "";
        //    char[] charArray = mot.ToCharArray();

        //    foreach (char c in charArray)
        //    {
        //        resultat += "_ ";
        //    }

        //    return resultat;
        //}



    }



}
