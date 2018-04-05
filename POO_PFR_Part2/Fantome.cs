using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class Fantome : Monstre
    {
        // champ
        // constrcteur
        public Fantome(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation )
         : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
