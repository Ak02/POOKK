using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class Zombie : Monstre
    {
        public enum CouleurZ {bleuatre,grisatre };
        // champ
        private int degreDecomposition;
        private CouleurZ teint;

        public Zombie(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation, CouleurZ teint, int degreDecomposition )
         : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.degreDecomposition = degreDecomposition;
            this.teint = teint;
        }

        public int DegreDecomposition
        {
            get { return degreDecomposition; }
            set { }
        }
        public override string ToString()
        {
            return base.ToString()
                + ", Couleur : " + teint
                + ", degreDecomposition : " + degreDecomposition;

        }
    }
}
