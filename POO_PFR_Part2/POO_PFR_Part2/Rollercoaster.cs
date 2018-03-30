using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class Rollercoaster : Attraction
    {
        public enum TypeCategorie { assise, inversee, bobsleigh };

        //champs
        private int ageMinimum;
        private TypeCategorie categorie;
        private float tailleMinimum;

        public Rollercoaster(bool besoinSpecifique, TimeSpan dureeMaintenance, List<Monstre> equipe, int identifiant, bool maintenance, string natureMaintenance, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin, int ageMinimum, TypeCategorie categorie, float tailleMinimum) :
            base(besoinSpecifique, dureeMaintenance, equipe, identifiant, maintenance, natureMaintenance, nbMinMonstre, nom, ouvert, typeDeBesoin)
        {
            this.categorie = categorie;
            this.ageMinimum = ageMinimum;
            this.tailleMinimum = tailleMinimum;
        }
    }
}
