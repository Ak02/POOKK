using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class Spectacle : Attraction
    {
        private List<DateTime> horaire;
        private int nombrePlace;
        private string nomSalle;

        public Spectacle(bool besoinSpecifique, TimeSpan dureeMaintenance, List<Monstre> equipe, int identifiant, bool maintenance, string natureMaintenance, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin, List<DateTime> horaire, int nombrePlace, string nomSalle) :
            base(besoinSpecifique, dureeMaintenance, equipe, identifiant, maintenance, natureMaintenance, nbMinMonstre, nom, ouvert, typeDeBesoin)
        {
            horaire = new List<DateTime>();
            this.nombrePlace = nombrePlace;
            this.nomSalle = nomSalle;
        }
    }
}
