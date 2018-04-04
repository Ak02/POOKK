using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class Demon : Monstre
    {
        // champ
        private int force;

        // constrcteur
        public Demon(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, Attraction affectation, int cagnotte, double indiceCruaute,int force)
         : base(matricule, nom, prenom, sexe, fonction, affectation, cagnotte)
        {
            this.force = force;
        }

        public int Force
        {
            get { return force; }
            set { }
        }
    }
}
