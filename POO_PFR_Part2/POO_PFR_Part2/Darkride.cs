using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class Darkride : Attraction
    {
        private TimeSpan duree;
        private bool vehicule;

        public Darkride(bool besoinSpecifique, TimeSpan dureeMaintenance, List<Monstre> equipe, int identifiant, bool maintenance, string natureMaintenance, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin, TimeSpan duree, bool vehicule) :
            base(besoinSpecifique, dureeMaintenance, equipe, identifiant, maintenance, natureMaintenance, nbMinMonstre, nom, ouvert, typeDeBesoin)
        {
            duree = new TimeSpan();
            this.vehicule = vehicule;
        }
    }
}
