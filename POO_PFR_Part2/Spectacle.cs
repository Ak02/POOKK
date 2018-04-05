using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class Spectacle : Attraction
    {
        private List<DateTime> horaire;
        private int nb_place;
        private string nom_Salle;

        /* public Spectacle(bool besoinSpecifique, TimeSpan dureeMaintenance, List<Monstre> equipe, int identifiant, bool maintenance, string natureMaintenance, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin, List<DateTime> horaire, int nombrePlace, string nomSalle) :
             base(besoinSpecifique, dureeMaintenance, equipe, identifiant, maintenance, natureMaintenance, nbMinMonstre, nom, ouvert, typeDeBesoin)
         {
             horaire = new List<DateTime>();
             this.nombrePlace = nombrePlace;
             this.nomSalle = nomSalle;
         }*/
        public Spectacle(int identifiant, string nom, int nb_Min_Monstre, bool besoinSpecifique, string typeDeBesoin, string nom_Salle,int nb_place,List<DateTime> horaire)
           : base(identifiant, nom, nb_Min_Monstre, besoinSpecifique, typeDeBesoin)
        {
            this.nom_Salle = nom_Salle;
            this.nb_place = nb_place;
            this.horaire = horaire;
        }
    }
}
