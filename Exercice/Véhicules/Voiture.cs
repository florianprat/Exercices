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

        public override string Description
        {
            get
            {
                return "Je suis une voiture\r\n" + base.Description;
            }
        }

    }
}