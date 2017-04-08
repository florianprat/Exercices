using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véhicules
{
    public enum Energies { Aucune, Essence, Gazole, GPL, Electrique }
    public class Vehicule
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
        #endregion

        #region Constructeurs
        public Vehicule(string nom, int nbRoues, Energies energie)
        {
            _nom = nom;
            _nbRoues = nbRoues;
            _energie = energie;
        }
        #endregion
    }
}
