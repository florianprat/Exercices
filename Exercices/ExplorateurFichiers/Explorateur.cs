using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorateurFichiers
{
    // Type délégué pour l'exploration des fichiers
    public delegate void DelegueExplorateur(FileInfo fichier);

    class Explorateur
    {

        // Méthode chargée de parcourir les fichiers du répertoire spécifié
        // La méthode permet d'exécuter sur chaque fichier un délégué du type défini juste avant la classe Explorateur.
        public static void Explorer(string chemin, DelegueExplorateur delegExplo)
        {
            // On récupère la liste des fichiers à l'aide d'un objet DirectoryInfo et de la méthode EnumerateFiles.
            // Ne pas oublier la directive using System.IO
            var dossier = new DirectoryInfo(chemin);
            var listeFichier = dossier.EnumerateFiles("*", SearchOption.AllDirectories);  // On prend en compte les sous-répertoires.

            // On exécute le délégué sur chaque fichier.
            foreach (var l in listeFichier)
                delegExplo(l);
        }
    }
}
