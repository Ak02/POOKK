using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class Darkride : Attraction
    {
        private TimeSpan duree;
        private bool vehicule;

        /*public Darkride(bool besoinSpecifique, TimeSpan dureeMaintenance, List<Monstre> equipe, int identifiant, bool maintenance, string natureMaintenance, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin, TimeSpan duree, bool vehicule) :
            base(besoinSpecifique, dureeMaintenance, equipe, identifiant, maintenance, natureMaintenance, nbMinMonstre, nom, ouvert, typeDeBesoin)
        {
            duree = new TimeSpan();
            this.vehicule = vehicule;
        }*/
        public Darkride(int identifiant, string nom, int nb_Min_Monstre, bool besoinSpecifique,string typeDeBesoin, TimeSpan duree, bool vehicule)
             : base(identifiant, nom, nb_Min_Monstre, besoinSpecifique, typeDeBesoin)
        {
            this.duree = duree;
            this.vehicule = vehicule;
        }
    }
}
