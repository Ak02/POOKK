using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace POO_PFR_Part2
{
    class Program
    {
        //private static Sorcier.Grade pouvoirs;

        // sex = (TypeSex)Enum.Parse(TypeOf(TypeSex),temp[4]
        static void Main(string[] args)
        {

            string chemin = "..\\..\\..\\Listing.csv";
            List<Personnel> personnels = new List<Personnel>();
            List<Attraction> attractions = new List<Attraction>();
            Administration admin = new Administration(attractions, personnels);
            List<string> pourvoir = new List<string>();
            /* pourvoir.Add("disparaitre");
             Personnel sorcier = new Sorcier(90, "toto", "momo", Sorcier.TypeSexe.male, "magie",pourvoir,Sorcier.Grade.giga);
             //personnels.Add(sorcier);

             admin.AjouterPersonnel(sorcier);*/
            //admin.EvolutionGrade((Sorcier)sorcier, Sorcier.Grade.mega);

            Chargement_Personnel_Attraction(chemin);
           

            /*Console.WriteLine("TD K - PDF partie 2");
            Console.WriteLine("KIM A-Victor & KIROUCHENAMOURTHY Sebastien");
            string chemin = "C:\\Users\\Kirou\\Desktop\\Listing.csv";
            try
            {
                //menu();
                /*LectureFichier(chemin);
                Console.WriteLine();
                ChargementFichier(chemin);
                Chargement_Personnel_Attraction(chemin);
            }
            catch (Exception e) // mettre l'exception correspondante
            {
                Console.WriteLine(e.Message);
                throw e;
            }*/
            Console.ReadLine();
        }

        #region test
     
        public static void Chargement_Personnel_Attraction(string chemin)
        {

            //List<Sorcier> sorcierS = new List<Sorcier>();
            List<Personnel> personnelS = new List<Personnel>();
            List<Attraction> attractionS = new List<Attraction>();

            StreamReader monStreamR = new StreamReader(chemin);
            string ligne = monStreamR.ReadLine();

            while (ligne != null)
            {
                try
                {
                    string[] tmp = ligne.Split(';');
                    if (tmp[0] == "Sorcier")
                    {
                        string[] tmplist = tmp[7].Split('-');
                        List<string> pv = new List<string>();
                        for(int i=0; i < tmplist.Length; i++) 
                        {
                            pv.Add(tmplist[i]);
                        }
                        personnelS.Add(new Sorcier(int.Parse(tmp[1]), tmp[2], tmp[3], (Personnel.TypeSexe)Enum.Parse(typeof(Personnel.TypeSexe),tmp[4]), tmp[5],pv, (Sorcier.Grade)Enum.Parse(typeof(Sorcier.Grade),tmp[6])));
                        foreach(Personnel p in personnelS)
                        {
                            Console.WriteLine(p);
                        }
                        Console.WriteLine("ajouter un sorcier");
                    }

                    if(tmp[0] == "Monstre")
                    {
                        //personnelS.Add(new Monstre(int.Parse(tmp[1]), tmp[2], tmp[3], (Personnel.TypeSexe)Enum.Parse(typeof(Personnel.TypeSexe),tmp[4]), tmp[5], tmp[6], int.Parse(tmp[7])));
                        Console.WriteLine("ajouter un monstre");
                    }
                    if (tmp[0] == "Demon")
                    {
                        //personnelS.Add(new Demon(int.Parse(tmp[1]), tmp[2], tmp[3], (Personnel.TypeSexe)Enum.Parse(typeof(Personnel.TypeSexe),tmp[4]), tmp[5], int.Parse(tmp[6]), double.Parse(tmp[7]), int.Parse(tmp[8])) );
                        Console.WriteLine("ajouter un demon");
                    }
                    if (tmp[0] == "Fantome")
                    {
                        //personnelS.Add(new Fantome(int.Parse(tmp[1]), tmp[2], tmp[3], (Personnel.TypeSexe)Enum.Parse(typeof(Personnel.TypeSexe),tmp[4]), tmp[5], tmp[6], int.Parse(tmp[7])) );
                        Console.WriteLine("ajouter un fantome");
                    }
                    if (tmp[0] == "LoupGarou")
                    {
                        //personnelS.Add(new LoupGarou(int.Parse(tmp[1]), tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], int.Parse(tmp[7]), double.Parse(tmp[8])) );
                        Console.WriteLine("ajouter un LoupGarou");
                    }
                    if (tmp[0] == "Vampire")
                    {
                        //personnelS.Add(new Vampire(int.Parse(tmp[1]), tmp[2], tmp[3], (Personnel.TypeSexe)Enum.Parse(typeof(Personnel.TypeSexe),tmp[4]), tmp[5], tmp[6], int.Parse(tmp[7]), float.Parse(tmp[8])) );
                        Console.WriteLine("ajouter un Vampire");
                    }
                    if (tmp[0] == "Zombie")
                    {
                        //personnelS.Add(new Zombie(int.Parse(tmp[1]), tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], int.Parse(tmp[7]), int.Parse(tmp[8]), (Zombie.CouleurZ)Enum.Parse(typeof(Zombie.CouleurZ),tmp[9])));
                        Console.WriteLine("ajouter un Zombie");
                    }
                    if (tmp[0] == "Boutique")
                    {
                        //attractionS.Add(new Boutique(bool.Parse(tmp[1]), tmp[2], int.Parse(tmp[3]), bool.Parse(tmp[4]), tmp[5], tmp[6],tmp[7],tmp[8],tmp[9],tmp[10]));
                        Console.WriteLine("ajouter un attraction");
                    }
                    if (tmp[0] == "DarkRide")
                    {
                       // attractionS.Add(new Darkride(bool.Parse(tmp[1]), tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7]));
                        Console.WriteLine("ajouter un DarkRide");
                    }
                    if (tmp[0] == "RollerCoster")
                    {
                        //attractionS.Add(new Rollercoaster(bool.Parse(tmp[1]), tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7], tmp[8]));
                        Console.WriteLine("ajouter un RollerCoster");
                    }
                    if (tmp[0] == "Spectacle")
                    {
                        //attractionS.Add(new Spectacle(bool.Parse(tmp[1]), tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7], tmp[8]));
                        Console.WriteLine("ajouter un Spectacle");
                    }
                    else
                    {
                       
                    }
                    //Console.WriteLine(ligne + "\n");

                    

                }
                catch (Exception e)
                {
                    Console.WriteLine("mon catch : " + e.Message);
                }

                ligne = monStreamR.ReadLine();
            }
            monStreamR.Close();

        }

        #endregion

        #region Methodes
        public static void AfficherListe(List<object> objets) // à améliorer
        {
            foreach(object o in objets)
            {
                if (o is POO_PFR_Part2.Sorcier)
                {
                     Console.WriteLine("Sorcier\n");
                }
            }
        }
       


        #endregion
        #region Menu // pas besoin de menu
        static void menu()
        {
            string chemin = "..\\..\\..\\Listing.csv"; // chemin direct "Location.csv"
            string menu;
            do
            {
                Console.WriteLine("NB : tapez exit pour quitter le menu.\n\n");


                Console.Write("Choix : ");
                menu = Console.ReadLine();
                Console.WriteLine();
                switch (menu)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    default:
                        if (menu != "exit")
                        {
                            Console.WriteLine("Veuillez saisir de nouveau un exercice...");
                        }
                        else
                        {
                        }
                        break;
                }
                Console.Write("\nTouch any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            while (menu != "exit");
        }
        #endregion 
        #region methode
        #endregion
    }
}

/* DIVERS
    public static void LectureFichier(string nameFile)
        {
            //string file = "bloc.txt";
            StreamReader readfile = null;
            try
            {
                readfile = new StreamReader(nameFile);
                string ligne = "";
                while (readfile.Peek() > 0)
                {
                    ligne = readfile.ReadLine();
                    Console.WriteLine(ligne + "\n");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                if (readfile != null)
                {
                    readfile.Close();
                }
            }
            readfile.Close();
            
        }
        public static void ChargementFichier(string chemin)
        {
            
            StreamReader monStreamR = new StreamReader(chemin);
            string ligne = monStreamR.ReadLine();

            while (ligne != null)
            {
                try
                {
                    //string[] tmp = ligne.Split(',');
                    /*if (tmp[0] == "Fixe")
                    {
                        telephoneS.Add(new Fixe(tmp[1], tmp[2], tmp[3]));
                    }
                    else
                    {
                        telephoneS.Add(new Portable(tmp[1], tmp[2], tmp[3]));
                    }
Console.WriteLine(ligne + "\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine("mon catch : " + e.Message);
                }

                ligne = monStreamR.ReadLine();
            }
            monStreamR.Close();
            
        }



 */