using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class Sorcier : Personnel
    {
        public enum Grade { novice, mega, giga, strata };
        // champs
        private List<string> pouvoirs;
        private Grade tatouage;

        // cosntructeur 
        public Sorcier(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, List<string> pouvoirs, Grade tatouage)
         : base(matricule, nom, prenom, sexe, fonction)
        {

        }
        public override string ToString()
        {
            return base.ToString()
                + ", Pouvoir : " + pouvoirs + ", Tatouage : " + tatouage; 
        }
    }
}
