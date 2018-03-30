using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace POO_PFR_Part2
{
    class Program
    {
        // sex = (TypeSex)Enum.Parse(TypeOf(TypeSex),temp[4]
        static void Main(string[] args)
        {
            
            Console.WriteLine("TD K - PDF partie 2");
            Console.WriteLine("KIM A-Victor & KIROUCHENAMOURTHY Sebastien");
            string chemin = "..\\..\\..\\Listing.csv";
            try
            {
                //menu();
                /*LectureFichier(chemin);
                Console.WriteLine();
                ChargementFichier(chemin);*/
                Chargement_Personnel_Attraction(chemin);
            }
            catch (Exception e) // mettre l'exception correspondante
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            Console.ReadLine();
        }
        #region test
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
                    }*/
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
                        // personnelS.Add(new Sorcier(tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7]);
                        Console.WriteLine("ajouter un sorcier");
                    }

                    if(tmp[0] == "Monstre")
                    {
                        //personnelS.Add(new Monstre(tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7]));
                        Console.WriteLine("ajouter un monstre");
                    }
                    if (tmp[0] == "Demon")
                    {
                        //personnelS.Add(new Demon(tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7], tmp[8]));
                        Console.WriteLine("ajouter un demon");
                    }
                    if (tmp[0] == "Fantome")
                    {
                        //personnelS.Add(new Fantome(tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7]));
                        Console.WriteLine("ajouter un fantome");
                    }
                    if (tmp[0] == "LoupGarou")
                    {
                        //personnelS.Add(new LoupGarou(tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7], tmp[8]));
                        Console.WriteLine("ajouter un LoupGarou");
                    }
                    if (tmp[0] == "Vampire")
                    {
                        //personnelS.Add(new Vampire(tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7], tmp[8]));
                        Console.WriteLine("ajouter un Vampire");
                    }
                    if (tmp[0] == "Zombie")
                    {
                        //personnelS.Add(new Zombie(tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7], tmp[8], tmp[9]));
                        Console.WriteLine("ajouter un Zombie");
                    }
                    if (tmp[0] == "Boutique")
                    {
                        //attractionS.Add(new Boutique(tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6]));
                        Console.WriteLine("ajouter un attraction");
                    }
                    if (tmp[0] == "DarkRide")
                    {
                        //attractionS.Add(new DarkRide(tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7]));
                        Console.WriteLine("ajouter un DarkRide");
                    }
                    if (tmp[0] == "RollerCoster")
                    {
                        //attractionS.Add(new RollerCoster(tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7], tmp[8]));
                        Console.WriteLine("ajouter un RollerCoster");
                    }
                    if (tmp[0] == "Spectacle")
                    {
                        //attractionS.Add(new Spectacle(tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7], tmp[8]));
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
        public static void AfficherListe(List<object> objets)
        {
            foreach(object o in objets)
            {
                if (o is Sorcier)
                {
                     Console.WriteLine("Sorcier\n");
                }
            }
        }
        #endregion
        #region Menu
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
