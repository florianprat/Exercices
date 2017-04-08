using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boites
{
    public enum Couleurs { Blanc, bleu, Vert, Jaune, Orange, Rouge, Marron}
    public enum Matières { Carton, Plastique, Bois, Métal }



    public class Boite
    {
        #region Champs privés
        private double _hauteur, _largeur, _longueur;
        private static int _compteur;
        private Etiquette _etiquetteDest, _etiquetteFragile;

        #endregion

        #region Propriétés
        public SortedDictionary<string, Article> Articles { get; }

        public double Hauteur
        {
            get { return _hauteur; }
        }

        public double Largeur
        {
            get { return _largeur; }
        }

        public double Longueur
        {
            get { return _longueur; }
        }

        public double Volume
        {
            get { return Hauteur * _largeur * _longueur; }
        }

        public Couleurs Couleur { get; set; }

        public Matières Matière { get; private set; }

        public static int Compteur
        {
            get
            {
                return _compteur;
            }
        }

        #endregion

        #region Constructeurs
        public Boite()
        {
            _compteur++;
            Articles = new SortedDictionary<string, Article>();
        }
        public Boite(double haut, double larg, double longr) : this()
        {
            _hauteur = haut;
            _largeur = larg;
            _longueur = longr;
        }

        public Boite(double haut, double larg, double longr, Matières mat) :
            this(haut, larg, longr)
        {
            Matière = mat;
        }

        #endregion

        #region Méthodes publiques
        public void Etiqueter(string destinataire)
        {
            _etiquetteDest = new Etiquette
            {
                Couleur = Couleurs.Blanc,
                Format = Formats.L,
                Texte = destinataire
            };
        }

        public void Etiqueter(string destinataire, bool fragile)
        {
            Etiqueter(destinataire);
            if (fragile)
            {
                _etiquetteFragile = new Etiquette
                {
                    Couleur = Couleurs.Rouge,
                    Format = Formats.S,
                    Texte = "FRAGILE"
                };
            }
        }

        public void Etiqueter(Etiquette etqDest, Etiquette etqFragile)
        {
            _etiquetteDest = etqDest;
            _etiquetteFragile = etqFragile;
        }

        public bool Compare(Boite autreBoite)
        {
            if (this.Hauteur == autreBoite.Hauteur && this.Largeur == autreBoite.Largeur &&
                this.Longueur == autreBoite.Longueur && this.Matière == autreBoite.Matière)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
