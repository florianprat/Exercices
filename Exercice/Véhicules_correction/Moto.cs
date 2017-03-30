using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véhicules
{
    public class Moto : Vehicule
    {
        #region Constructeurs
        public Moto(string nom, Energies energie) : base(nom, 2, energie)
        {
        }

        public Moto(string nom, double prix) : base(nom, prix)
        {
        }
        #endregion


        public override string Description
        {
            get
            {
                return "Je suis une moto\r\n" + base.Description;
            }
        }

        public override double PRK
        {
            get
            {
                return 0.35;
            }
        }

        public override double CalculerConso()
        {
            throw new NotImplementedException();
        }
    }
}
