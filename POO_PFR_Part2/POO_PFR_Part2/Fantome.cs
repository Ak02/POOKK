﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class Fantome : Monstre
    {
        // champ
        // constrcteur
        public Fantome(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, Attraction affectation, int cagnotte)
         : base(matricule, nom, prenom, sexe, fonction, affectation, cagnotte)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
