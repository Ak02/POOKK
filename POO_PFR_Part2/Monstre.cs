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
        public Monstre(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation)
            : base(matricule, nom, prenom, sexe, fonction)
        {
            this.cagnotte = cagnotte;
            this.affectation = affectation;

        }

        public override string ToString()
        {
            return base.ToString()
                + ", Cagnotte : " + cagnotte
                + ", Affectation : " + affectation;
                
        }

        public Attraction Affectation
        {
            get { return affectation; }
            set { }
        }

        public int Cagnotte
        {
            get { return cagnotte; }
            set { }
        }


    }
}
