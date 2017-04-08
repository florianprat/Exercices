using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véhicules
{
    public class Voiture : Vehicule
    {
        public Voiture(string nom, Energies energie) : base(nom, 4, energie)
        {
        }

        public Voiture(string nom, decimal prix) : base(nom, prix)
        {
        }


        public override string Description
        {
            get
            {
                return "Je suis une voiture\r\n" + base.Description;
            }
        }

        public override double PRK
        {
            get
            {
                return 0.40;
            }
        }

        public override double CalculerConso()
        {
            throw new NotImplementedException();
        }
    }
}