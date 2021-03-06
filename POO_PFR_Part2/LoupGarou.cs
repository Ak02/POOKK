﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class LoupGarou : Monstre
    {
        // champ
        private double indiceCruaute;
        // constrcuteur
        public LoupGarou(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, int cagnotte, Attraction affectation, double indiceCruaute)
         : base(matricule, nom, prenom, sexe, fonction, cagnotte, affectation)
        {
            this.indiceCruaute = indiceCruaute;
        }

        public override string ToString()
        {
            return base.ToString()
                + ", Indice Cruauté : " + indiceCruaute; 
        }

        public double IndiceCruaute
        {
            get { return indiceCruaute; }
            set { }
        }
    }
}
