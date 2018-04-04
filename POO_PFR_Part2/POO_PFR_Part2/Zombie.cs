using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class Zombie : Monstre
    {
        public enum CouleurZ { };
        // champ
        private int degreDecomposition;
        private CouleurZ teint;

        public Zombie(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, Attraction affectation, int cagnotte, int degreDecomposition, CouleurZ teint)
         : base(matricule, nom, prenom, sexe, fonction, affectation, cagnotte)
        {
            this.degreDecomposition = degreDecomposition;
            this.teint = teint;
        }

        public int DegreDecomposition
        {
            get { return degreDecomposition; }
            set { }
        }
    }
}
