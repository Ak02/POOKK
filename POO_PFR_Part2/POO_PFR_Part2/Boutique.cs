using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class Boutique : Attraction
    {
        public enum typeBoutique { souvenir, barbeAPapa, nourriture };
        // champ
        private typeBoutique type;

        public Boutique(bool besoinSpecifique, TimeSpan dureeMaintenance, List<Monstre> equipe, int identifiant, bool maintenance, string natureMaintenance, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin, typeBoutique type)
            : base(besoinSpecifique, dureeMaintenance, equipe, identifiant, maintenance, natureMaintenance, nbMinMonstre, nom, ouvert, typeDeBesoin)
        {
            this.type = type;
        }
    }
}
