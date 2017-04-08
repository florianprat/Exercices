using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptage_voyelles_consonnes
{
    class Program
    {
        static void Main(string[] args)
        {
            int voyelle;
            int consonne;

            Console.WriteLine("Saisir un mot :");
            string motSaisi = Console.ReadLine();

            Comptage(motSaisi, out voyelle, out consonne);
            Console.WriteLine("\"{0}\" comprend {1} consonnes et {2} voyelles", motSaisi, consonne, voyelle);
            Console.ReadKey();
        }

        // Fonction de comptage des voyelles et des consonnes
        static void Comptage(string motCompté, out int nbVoyelles, out int nbConsonnes)
        {
            nbVoyelles = 0;
            nbConsonnes = 0;

            for (int i = 0; i < motCompté.Length; i++)
            {
                if (motCompté[i] == 'a' || motCompté[i] == 'e' || motCompté[i] == 'i' || motCompté[i] == 'o' || motCompté[i] == 'u' || motCompté[i] == 'y')
                {
                    nbVoyelles++;
                }
            }
            nbConsonnes = motCompté.Length - nbVoyelles;
        }

    }
}
