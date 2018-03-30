using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
   abstract class Attraction
    {
        #region Champs
        protected bool besoinSpecifique;
        protected TimeSpan dureeMaintenance;
        protected List<Monstre> equipe;
        protected int identifiant;
        protected bool maintenance;
        protected string natureMaintenance;
        protected int nbMinMonstre;
        protected string nom;
        protected bool ouvert;
        protected string typeDeBesoin;
        #endregion

        #region Constructeur
        public Attraction(bool besoinSpecifique, TimeSpan dureeMaintenance, List<Monstre> equipe, int identifiant, bool maintenance, string natureMaintenance, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin)
        {
            this.besoinSpecifique = besoinSpecifique;
            dureeMaintenance = new TimeSpan();
            equipe = new List<Monstre>();
            this.identifiant = identifiant;
            this.maintenance = maintenance;
            this.natureMaintenance = natureMaintenance;
            this.nbMinMonstre = nbMinMonstre;
            this.nom = nom;
            this.ouvert = ouvert;
            this.typeDeBesoin = typeDeBesoin;
        }
        #endregion

    }
}
