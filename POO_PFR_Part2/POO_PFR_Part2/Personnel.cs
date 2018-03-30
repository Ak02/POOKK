using System;
using System.Collections.Generic;
using System.Text;

// groupe 10
namespace POO_PFR_Part2
{
    abstract class Personnel
    {
        public enum TypeSexe { male,femelle,autre};
        #region champs
        protected string fonction;
        protected int matricule;
        protected string nom;
        protected string prenom;
        protected TypeSexe sexe;

        public Personnel(int matricule,string nom,string prenom,TypeSexe sexe, string fonction)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.fonction = fonction;
        }


        #endregion
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
