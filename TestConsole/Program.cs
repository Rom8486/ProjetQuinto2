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
            Console.WriteLine("Appuyer sur S pour commencer le chronometre");
            if (Console.ReadLine()=="S")
            {
                TempsDebut();
                DateTime TpsDebut = TempsDebut();
                Console.WriteLine("Appuyer sur F pour arreter le chronometre");
                if (Console.ReadLine() == "F")
                {
                    TempsFin();
                    DateTime TpsFin= TempsFin();
                    int TempsEcoule=CalculerTemps(TpsDebut, TpsFin);
                    Console.WriteLine("Le temps ecoulé est de : "+ TempsEcoule);
                }
            }
            Console.Read();
        }
        public static DateTime TempsDebut()
        {
            DateTime TpsDebut = DateTime.Now;
            return TpsDebut;
        }
        public static DateTime TempsFin()
        {
            DateTime TpsFin = DateTime.Now;
            return TpsFin;
        }
        public static int CalculerTemps(DateTime tpsDebut, DateTime tpsFin)
        {
            TimeSpan span = (tpsFin - tpsDebut);
            int resultat = (int)span.TotalSeconds;
            return resultat;
        }


    }
}