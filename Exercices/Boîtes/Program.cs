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
            Boite b1 = new Boite();

            Console.WriteLine("Boîte de volume {0} cm3, de couleur {1} et en {2}", b1.CalculVolume, b1.EcritureCouleur, b1.LectureMatière);

            Console.ReadKey();
        }
    }

    public enum Couleur { blanc, bleu, vert, jaune, orange, rouge, marron }
    public enum Matière { carton, plastique, bois, métal }

    public class Boite
    {
        #region Champs privés
        private decimal _hauteur;
        private decimal _largeur;
        private decimal _longueur;
        private Couleur _couleur;
        private Matière _matière;

        #endregion

        #region Constructeur
        public Boite()
        {
            _hauteur = 30.0m;
            _largeur = 30.0m;
            _longueur = 30.0m;
            _matière = Matière.carton;
        }
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

        public Matière LectureMatière
        {
            get { return _matière; }
        }

        public Couleur EcritureCouleur
        {
            get { return _couleur; }
            set { _couleur = value; }
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
