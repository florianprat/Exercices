using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri_tableau
{
    class Program
    {
        static void Main(string[] args)
        {

            // Déclaration des variables
            string[] Tableau = new string[4];
            Tableau[0] = "tableau";
            Tableau[1] = "chaise";
            Tableau[2] = "bureau";
            Tableau[3] = "porte";

            // Appel de la fonction d'affichage du tableau avant tri
            AfficherTableau(Tableau);

            // Appel de la fonction de tri du tableau
            TriTableau(Tableau);

            // Appel de la fonction d'affichage du tableau après tri
            Console.WriteLine("");
            AfficherTableau(Tableau);

            Console.ReadKey();

        }

        //
        // Fonction d'affichage du tableau
        //
        static void AfficherTableau(string[] TabAffiche)
        {
            for (int i = 0; i < TabAffiche.Length; i++)
            {
                Console.Write(TabAffiche[i] + " ");
            }
        }

        //
        // Fonction de tri du tableau
        //
        static void TriTableau(string[] TabTri)
        {
            // Déclaration d'une valeur tampon pour les permutations
            string valeur;

            for (int i = 0; i < TabTri.Length - 1; i++)
            {
                if (TabTri[i].CompareTo(TabTri[i + 1]) > 0)
                {
                    valeur = TabTri[i + 1];
                    TabTri[i + 1] = TabTri[i];
                    TabTri[i] = valeur;
                    i = -1;
                }
            }
        }


    }
}
