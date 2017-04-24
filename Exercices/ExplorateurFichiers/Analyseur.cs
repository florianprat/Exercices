using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorateurFichiers
{
    class Analyseur
    {
        #region Propriétés
        public int nbTotFichiers { get; private set; }
        public int nbFichiersCs { get; private set; }
        public FileInfo fichierLong { get; private set; }
        public List<FileInfo> listeFichier { get; private set; }
        #endregion

        #region Constructeur
        public Analyseur()
        {
            nbTotFichiers = 0;
            nbFichiersCs = 0;
        }
        #endregion

        #region Méthodes
        public void AnalyserDossier(string chemin)
        {
            // Déclaration d'un délégué du type DelegueExplorateur et branchement de méthodes
            DelegueExplorateur delegExplo = null;
            delegExplo += CompterFichiers;
            delegExplo += AnalyserNom;
            delegExplo += FiltrerProjet;

            fichierLong = new FileInfo(chemin);  // Initialisation de fichierLong
            listeFichier = new List<FileInfo>();

            Explorateur.Explorer(chemin, delegExplo);
        }

        // Méthode comptant le nombre total de fichiers et le nombre de fichiers avec l'extension .cs
        // On incrémente pour cela respectivement nbTotFichiers et nbFichiersCs.
        public void CompterFichiers(FileInfo fichier)
        {
            nbTotFichiers++;
            if (fichier.Extension == ".cs")
                nbFichiersCs++;
        }

        public void AnalyserNom(FileInfo fichier)
        {
            if (fichier.Name.Length > fichierLong.Name.Length)
                fichierLong = fichier;
        }

        public void FiltrerProjet(FileInfo fichier)
        {
            if (fichier.Extension == ".csproj")
                listeFichier.Add(fichier);
        }
        #endregion
    }
}
