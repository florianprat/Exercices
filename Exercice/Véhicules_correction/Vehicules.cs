using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véhicules
{
    public enum Energies { Aucune, Essence, Gazole, GPL, Electrique }
    public abstract class Vehicule : IComparable
    {
        private string _nom;
        private int _nbRoues;
        private Energies _energie;

        #region propriétés
        public string Nom
        {
            get { return _nom; }
        }

        public int NbRoues
        {
            get { return _nbRoues; }
        }
        public Energies Energie
        {
            get { return _energie; }
        }

        public virtual string Description
        {
            get
            {
                return string.Format("Véhicule {0} roule sur {1} roues et à l'énergie {2}", Nom, NbRoues, Energie);
            }
        }

        public abstract double PRK { get; }
        public double Prix { get; }

        #endregion

        #region Constructeurs
        public Vehicule(string nom, int nbRoues, Energies energie)
        {
            _nom = nom;
            _nbRoues = nbRoues;
            _energie = energie;
        }

        public Vehicule(string nom, double prix)
        {
            _nom = nom;
            Prix = prix;
        }
        #endregion

        public abstract double CalculerConso();

        public int CompareTo(object obj)
        {
            if (obj is Vehicule)
            {
                Vehicule v = (Vehicule)obj;
                if (Prix < v.Prix) return -1;
                else if (Prix > v.Prix) return 1;
                else return 0;
            }
            else
                throw new ArgumentException();
        }
    }
}
