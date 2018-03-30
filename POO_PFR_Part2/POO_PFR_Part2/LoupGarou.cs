using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class LoupGarou : Monstre
    {
        // champ
        private double indiceCruaute;
        // constrcuteur
        public LoupGarou(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, Attraction affectation, int cagnotte, double indiceCruaute)
         : base(matricule, nom, prenom, sexe, fonction, affectation, cagnotte)
        {
            this.indiceCruaute = indiceCruaute;
        }

    }
}
