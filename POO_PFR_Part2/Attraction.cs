using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
   abstract class Attraction
    {
        
        #region Champs
        private bool besoinSpecifique;
        private TimeSpan dureeMaintenance;
        private List<Monstre> equipe;
        private int identifiant;
        private bool maintenance;
        private string natureMaintenance;
        private int nb_Min_Monstre;
        private string nom;
        private bool ouvert;
        private string typeDeBesoin;
        
        #endregion

        #region Constructeur
        /*public Attraction(bool besoinSpecifique, TimeSpan dureeMaintenance, List<Monstre> equipe, int identifiant, bool maintenance, string natureMaintenance, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin)
        {
            this.besoinSpecifique = besoinSpecifique;
            this.dureeMaintenance = dureeMaintenance;
            this.equipe = equipe;
            this.identifiant = identifiant;
            this.maintenance = maintenance;
            this.natureMaintenance = natureMaintenance;
            this.nbMinMonstre = nbMinMonstre;
            this.nom = nom;
            this.ouvert = ouvert;
            this.typeDeBesoin = typeDeBesoin;
        }*/
        public Attraction(int identifiant,string nom, int nb_Min_Monstre,bool besoinSpecifique,string typeDeBesoin)
        {
            this.identifiant = identifiant;
            this.nom = nom;
            this.nb_Min_Monstre = nb_Min_Monstre;
            this.besoinSpecifique = besoinSpecifique;
            this.typeDeBesoin = typeDeBesoin;
        }
        #endregion

    }
}
