using System;
using System.Collections.Generic;

namespace POO_PFR_Part2
{
    class Administration
    {
        // champ
        private List<Attraction> attractions;
        private List<Personnel> toutLePersonnel;

        public Administration(List<Attraction> attractions, List<Personnel> toutLePersonnel)
        {
            this.attractions = attractions;
            this.toutLePersonnel = new List<Personnel>();
        }

        public List<Personnel> Personnel
        {
            get { return toutLePersonnel; }
        }

        public void AjouterPersonnel(Personnel pers)
        {

            if (pers is Sorcier)
            {
                toutLePersonnel.Add(pers as Sorcier); //ajout du personnel en tant que sorcier
            }

            if(pers is Monstre)
            {
                toutLePersonnel.Add(pers as Monstre);
            }

            /*if (pers is Demon)
            {
                toutLePersonnel.Add(pers as Demon);
            }

            if (pers is Fantome)
            {
                toutLePersonnel.Add(pers as Fantome);
            }

            if (pers is Vampire)
            {
                toutLePersonnel.Add(pers as Vampire);
            }

            if (pers is Zombie)
            {
                toutLePersonnel.Add(pers as Zombie);
            }

            if (pers is LoupGarou)
            {
                toutLePersonnel.Add(pers as LoupGarou);
            }*/

        }
        public void AjouterAttraction(Attraction attra)
        {
            if (attra is Boutique)
            {
                attractions.Add(attra as Boutique);
            }

            if (attra is Darkride)
            {
                attractions.Add(attra as Darkride);
            }

            if (attra is Rollercoaster)
            {
                attractions.Add(attra as Rollercoaster);
            }

            if (attra is Spectacle)
            {
                attractions.Add(attra as Spectacle);
            }
        }
        public void EvolutionGrade(Sorcier sorcier, Sorcier.Grade g)
        {
            if (g.Equals(sorcier.Tatouage) == true) //si c'est le grade actuel du personnel
            {
                Console.WriteLine("Impossible de modifier, le grade entré est le grade actuel du personnel");
            }

            else
            {
                if ((g == Sorcier.Grade.mega && sorcier.Tatouage == Sorcier.Grade.giga) || (g == Sorcier.Grade.giga && sorcier.Tatouage == Sorcier.Grade.strata) || (g == Sorcier.Grade.novice && sorcier.Tatouage == Sorcier.Grade.mega))
                {
                    Console.WriteLine("Impossible de modifier, ce n'est pas une évolution");
                }

                else
                {
                    sorcier.Tatouage = g;
                    Console.WriteLine("Evolution de grade effectuée");
                }

            }

        }
        public void EvolutionForce(Demon demon, int force)
        {
            if (force >= 1 && force <= 10) //la force est comprise entre 1 et 10
            {
                if (force > demon.Force) //obligé superieur pour une evolution
                {
                    demon.Force = force;
                }

                else 
                {
                    Console.WriteLine("Impossible de modifier, ce n'est pas une evolution");
                }
            }

            else
            {
                Console.WriteLine("Impossible : la force d'un demon est comprise entre 1 et 10");
            }


        }
        public void EvolutionDegreDecomposition(Zombie zombie, int degre)
        {
            if (degre >= 1 && degre <= 10) //le degre de decomposition est comprise entre 1 et 10
            {
                if (degre > zombie.DegreDecomposition) //obligé superieur pour une evolution
                {
                    zombie.DegreDecomposition = degre;
                }

                else
                {
                    Console.WriteLine("Impossible de modifier, ce n'est pas une evolution");
                }
            }

            else
            {
                Console.WriteLine("Impossible : le degre de decomposition d'un zombie est comprise entre 1 et 10");
            }
        }
        public void EvolutionIndiceCruauté(LoupGarou loupGarou, double indice)
        {
            if(indice >= 0 && indice <= 4) //indice de cruaute compris entre 0 et 4
            {
                if(indice > loupGarou.IndiceCruaute) //obligé superieur pour evolution
                {
                    loupGarou.IndiceCruaute = indice;
                }

                else
                {
                    Console.WriteLine("Impossible de modifier, ce n'est pas une evolution");
                }
            }

            else
            {
                Console.WriteLine("Impossible de modifier, l indice de decomposition est compris entre 0 et 4");
            }
        }
        public void EvolutionIndiceLuminosite(Vampire vampire, float indice)
        {
            if (indice >= 0 && indice <= 4) //indice de luminosite compris entre 0 et 3
            {
                if (indice < vampire.IndiceLuminosite) //obligé inferieur pour evolution car un vampire moins brillant est plus performant
                {
                    vampire.IndiceLuminosite = indice;
                }

                else
                {
                    Console.WriteLine("Impossible de modifier, ce n'est pas une evolution");
                }
            }

            else
            {
                Console.WriteLine("Impossible de modifier, l indice de luminosite est compris entre 0 et 3");
            }
        }
        public void ChamgementAffectation(Monstre monstre, Attraction attraction)
        {
            if(monstre.Affectation != attraction)
            {
                monstre.Affectation = attraction;
            }

            else
            {
                Console.WriteLine("Impossible de modifier, il est dèja affecter a cette attractin ");
            }
        }
        //public void ModifierPouvoir() //ambiguité -> poser question à KIMG
        public void trieMonstre (List<Monstre> monstre)
        {
            
        }
        public void IncrementerCagnotte(Monstre monstre, int point)
        {
            int cagnotte = monstre.Cagnotte + point;
            if (cagnotte < 50)
            {
                //exemple
                Attraction boutique = new Boutique(true, TimeSpan.FromMinutes(56), null, 45, false, null, 45, "pour les nul", true, "besoin de sucre", Boutique.typeBoutique.barbeAPapa);
                monstre.Affectation = boutique;
            }

            if(monstre is Zombie || monstre is Demon)
            {
                if(cagnotte > 500)
                {
                    monstre.Affectation = null;
                }
            }

        }
        public void DesincrementerCagnotte(Monstre monstre, int point)
        {
            int cagnotte = monstre.Cagnotte - point;
            if (cagnotte < 50)
            {
                //exemple
                Attraction boutique = new Boutique(true, TimeSpan.FromMinutes(56), null, 45, false, null, 45, "pour les nul", true, "besoin de sucre", Boutique.typeBoutique.barbeAPapa);
                monstre.Affectation = boutique;
            }

            if (monstre is Zombie || monstre is Demon)
            {
                if (cagnotte > 500)
                {
                    monstre.Affectation = null;
                }
            }

        }

    }
    }

