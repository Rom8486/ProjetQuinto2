using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetQuinto
{
    public class Joueur
    {

        private int _nbPointsParManche;
        private int _nbPointsTotal;
        private int _nbManchesRemportees;
        private int _nbPropositions;
        private int _nbErreurs;
        string _alias;


        #region Get/Set
        public int NbPoints 
        { get { return _nbPointsParManche; }
            set { _nbPointsParManche = value; }
        }

        public int NbManchesRemportees
        {
            get { return _nbManchesRemportees; }
            set { _nbManchesRemportees = value; }
        }

        public int NbPropositions
        {
            get { return _nbPropositions; }
            set { _nbPropositions = value; }
        }

        public int NbErreurs
        {
            get { return _nbErreurs; }
            set { _nbErreurs = value; }
        }

        public string Alias
        {
            get { return _alias; }
            set { _alias = value; }
        }

        #endregion

        enum NiveauDifficulte
        {
            facile=0,
            difficile=1,
            expert=2
        }

        #region Méthodes Difficulté
        static void GestionDifficulte(NiveauDifficulte niveauDifficulte)
        {
            switch (niveauDifficulte)
            {
                case NiveauDifficulte.facile:
                    int _nbEssaisMax = 8;
                    double malusTps = 2;
                    double MalusErr = 2;
                    //Constantes à redefinir
                    break;
                case NiveauDifficulte.difficile:
                    _nbEssaisMax = 7;
                    malusTps = 1.8;
                    MalusErr = 1.8;
                    break;
                case NiveauDifficulte.expert:
                    _nbEssaisMax = 6;
                    malusTps = 1.6;
                    MalusErr = 1.6;
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region FonctionPerdu
        private void Perdu()
        {
           DialogResult Dia= MessageBox.Show("Dommage Vous avez perdu!!\n :(\n Voulez vous rejouer?", "Perdu", MessageBoxButtons.YesNo);
            if (Dia== DialogResult.Yes)
            {
                //GestionnaireContextes(Contextes.Initial);
            }
            else
            {
                Interface_jeux.ActiveForm.Close();
                //????
            }
        }
        #endregion

        #region Gagne
        private void Gagne()
        {
            DialogResult Dia = MessageBox.Show("Bravo vous avez gagné!!\n :)))\n Voulez vous rejouer?", "Gagné", MessageBoxButtons.YesNo);
            if (Dia == DialogResult.Yes)
            {
                //Interface_jeux.GestionnaireContextes(Contextes.Initial);
            }
            else
            {
                Interface_jeux.ActiveForm.Close();
                //????
            }

        }
        #endregion

        #region Calcul PointParManche
        private double CalculNbPointsParManche(TimeSpan tps, int NbErreurs, NiveauDifficulte niveauDifficulte )
        {

            switch (niveauDifficulte)
            {
                case NiveauDifficulte.facile:
                    int _nbEssaisMax = 8;
                    double malusTps = 2;
                    double MalusErr = 2;
                    //A redefinir
                    int TotalSecond = (int)tps.TotalSeconds;   /*en seconde*/
                    double Points = TotalSecond * malusTps + NbErreurs * MalusErr;
                    if (NbErreurs >= _nbEssaisMax)
                    {
                        Perdu();
                        return 0;

                    }
                    return Points;

                case NiveauDifficulte.difficile:
                    _nbEssaisMax = 7;
                    malusTps = 1.8;
                    MalusErr = 1.8;
                    //a redefinir
                    TotalSecond = (int)tps.TotalSeconds;   /*en seconde*/
                    Points = TotalSecond * malusTps + NbErreurs * MalusErr;
                    if (NbErreurs >= _nbEssaisMax)
                    {
                        Perdu();
                        return 0;

                    }
                    return Points;
                    
                case NiveauDifficulte.expert:
                    _nbEssaisMax = 6;
                    malusTps = 1.6;
                    MalusErr = 1.6;
                    //a redefinir
                    TotalSecond = (int)tps.TotalSeconds;   /*en seconde*/
                    Points = TotalSecond * malusTps + NbErreurs * MalusErr;
                    if (NbErreurs >= _nbEssaisMax)
                    {
                        Perdu();
                        return 0;



                    }
                    return Points;

                default:return 0;
                    
            }


            
        }
        #endregion

    }
}
