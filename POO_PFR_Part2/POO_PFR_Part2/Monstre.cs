using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class Monstre : Personnel
    {
        // champs
        private int cagnotte;
        private int minCagnotte = 50;
        private int maxCagnotte = 500;
        private Attraction affectation;

        // constrcteur
        public Monstre(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, Attraction affectation, int cagnotte)
            : base(matricule, nom, prenom, sexe, fonction)
        {
            this.cagnotte = cagnotte;
            this.affectation = affectation;

        }

        public override string ToString()
        {
            return base.ToString()
                + ", Affectation : " + affectation + ", Cagnotte : " + cagnotte; 
        }



    }
}
