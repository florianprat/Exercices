using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boîtes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public enum Couleurs {blanc, bleu, vert, jaune, orange, rouge, marron }
    public enum Matière { carton, plastique, bois, métal}

    public class Boite
    {
        #region Champs privés
        private decimal _hauteur = 30;
        private decimal _largeur = 30;
        private decimal _longueur = 30;
        private Couleurs _couleur;
        private Matière _matière = Matière.carton;
        
        #endregion

        #region Propriétés
        public decimal LectureHauteur
        {
            get { return _hauteur; }
        }

        public decimal LectureLargeur
        {
            get { return _largeur; }
        }

        public decimal LectureLongueur
        {
            get { return _longueur; }
        }

        public Couleurs EcritureCouleur
        {
            get { return _couleur; }
            set { _couleur = value;  }
        }

        public decimal CalculVolume
        {
            get
            {
                return (_hauteur * _largeur * _longueur);
            }
        }
        #endregion

        #region Méthodes publiques
        public string Etiqueter(string destinataire)
        {
            throw new NotImplementedException();
        }

        public string Etiqueter(string destinataire, bool fragile)
        {
            throw new NotImplementedException();
        }
        #endregion

    }

}
