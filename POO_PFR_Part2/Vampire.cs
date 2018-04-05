using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class Vampire : Monstre
    {
        // champ
        private float indiceLuminosite;

        // constructeur
        public Vampire(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation,  float indiceLuminosite)
         : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.indiceLuminosite = indiceLuminosite;
        }

        public float IndiceLuminosite
        {
            get { return indiceLuminosite; }
            set { }
        }
    }
}
