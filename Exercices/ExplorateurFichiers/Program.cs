using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorateurFichiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez le chemin du dossier à explorer :");
            string chemin = Console.ReadLine();
            Analyseur ana = new Analyseur();
            ana.AnalyserDossier(chemin);

            Console.WriteLine("{0} fichiers, dont {1} fichiers .cs", ana.nbTotFichiers, ana.nbFichiersCs);
            Console.WriteLine("Nom de fichier le plus long : {0}", ana.fichierLong.Name);

            foreach (var f in ana.listeFichier)
                Console.WriteLine(f.Name);

            Console.ReadKey();
        }
    }
}
