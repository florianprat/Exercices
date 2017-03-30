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
        private static int _compteur = 0;
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
            get { return _hauteur * _largeur * _longueur; }
        }

        public Couleurs Couleur { get; set; }

        public Matières Matière { get; private set; }

        public static int Compteur
        {
            get { return _compteur; }
        }

        #endregion

        #region Constructeurs
        public Boite()
        {
            _compteur++;
            Articles = new SortedDictionary<string, Article>();
        }

        public Boite(double haut, double large, double lgr) : this()
        {
            _hauteur = haut;
            _largeur = large;
            _longueur = lgr;
        }

        public Boite(double haut, double large, double lgr, Matières mat) : this(haut, large, lgr)
        {
            Matière = mat;
        }
        #endregion

        #region Méthodes publiques
        public void Etiqueter(string destinataire)
        {
            _etiquetteDest = new Etiquette { Couleur = Couleurs.Blanc, Texte = "destinataire", Format = Formats.L};
            //throw new NotImplementedException();
        }

        public void Etiqueter(string destinataire, bool fragile) 
        {
            Etiqueter(destinataire);
            if (fragile)
            {
                _etiquetteFragile = new Etiquette { Couleur = Couleurs.Rouge, Texte = "FRAGILE", Format = Formats.S };
            }
            
            //throw new NotImplementedException();
        }

        public void Etiqueter(Etiquette etqDest, Etiquette etqFragile)
        {
            _etiquetteDest = etqDest;
            _etiquetteFragile = etqFragile;
        }


        public bool Compare(Boite autreBoite)
        {
            // Ou if() return true else return false
            return (this.Hauteur == autreBoite.Hauteur && this.Largeur == autreBoite.Largeur &&
                this.Longueur == autreBoite.Longueur && this.Matière == autreBoite.Matière);
        }
        

        #endregion
    }

    
}
