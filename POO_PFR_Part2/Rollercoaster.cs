using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class Rollercoaster : Attraction
    {
        public enum TypeCategorie { assise, inversee, bobsleigh };

        //champs
        private int age_Min;
        private TypeCategorie categorie;
        private float taille_Min;

        /*public Rollercoaster(bool besoinSpecifique, TimeSpan dureeMaintenance, List<Monstre> equipe, int identifiant, bool maintenance, string natureMaintenance, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin, int ageMinimum, TypeCategorie categorie, float tailleMinimum) :
            base(besoinSpecifique, dureeMaintenance, equipe, identifiant, maintenance, natureMaintenance, nbMinMonstre, nom, ouvert, typeDeBesoin)
        {
            this.categorie = categorie;
            this.ageMinimum = ageMinimum;
            this.tailleMinimum = tailleMinimum;
        }*/
        public Rollercoaster(int identifiant, string nom, int nb_Min_Monstre, bool besoinSpecifique, string typeDeBesoin,TypeCategorie categorie,int age_Min,float taille_Min)
             : base(identifiant, nom, nb_Min_Monstre, besoinSpecifique, typeDeBesoin)
        {
            this.categorie = categorie;
            this.age_Min = age_Min;
            this.taille_Min = taille_Min;
        }
    }
}
