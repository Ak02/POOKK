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
        public Demon(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation, int force)
         : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.force = force;
        }

        public int Force
        {
            get { return force; }
            set { }
        }
        public override string ToString()
        {
            string s = base.ToString()
                + ", Force : " + force;
            return s;
        }
    }
}
