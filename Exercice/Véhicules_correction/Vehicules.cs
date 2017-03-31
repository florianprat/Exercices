using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véhicules
{
    public enum Energies { Aucune, Essence, Gazole, GPL, Electrique }
    public abstract class Vehicule : IComparable<Vehicule>
    {
        private string _nom;
        private int _nbRoues;
        private Energies _energie;
        private decimal _prix;

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

        public decimal Prix
        {
            get { return _prix; }
        }

        public virtual string Description
        {
            get
            {
                return string.Format("Véhicule {0} roule sur {1} roues et à l'énergie {2}", Nom, NbRoues, Energie);
            }
        }

        public abstract double PRK { get; }
        #endregion

        #region Constructeurs
        public Vehicule(string nom, int nbRoues, Energies energie)
        {
            _nom = nom;
            _nbRoues = nbRoues;
            _energie = energie;
        }

        public Vehicule(string nom, decimal prix)
        {
            _nom = nom;
            _prix = prix;
        }
        #endregion

        public abstract double CalculerConso();


        public int CompareTo(Vehicule other)
        {
            return _prix.CompareTo(other.Prix);
        }
    }
}
