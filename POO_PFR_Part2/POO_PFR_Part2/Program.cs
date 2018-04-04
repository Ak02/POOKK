using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace POO_TD5_LocationVoiture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TD K - PDF partie 2");
            Console.WriteLine("KIM A-Victor & KIROUCHENAMOURTHY Sebastien");
            menu();
           
        }
        #region test
        static void test_voiture()
        {

        }
        #endregion
        #region Menu
        static void menu()
        {
            string chemin = "C:\\users\\Kirou\\Desktop\\listing.csv";
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
