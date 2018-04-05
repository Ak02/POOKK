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
        public Sorcier(int matricule, string nom, string prenom, TypeSexe sexe, string fonction, Grade tatouage, List<string> pouvoirs)
         : base(matricule, nom, prenom, sexe, fonction)
        {
            this.pouvoirs = pouvoirs;
            this.tatouage = tatouage;
        }
        public List<string> Pouvoirs
        {
            get { return pouvoirs; }
        }
        public Grade Tatouage
        {
            get { return tatouage; }
            set { }
        }
        public override string ToString()
        {
          
            string s = base.ToString();
            s += ", Pouvoir(s) : ";
            foreach(string p in pouvoirs)
            {
                s += ", " + p;     
            }
       
            s += ", Tatoauge : " + tatouage;
            return s;

        }

    }
}
