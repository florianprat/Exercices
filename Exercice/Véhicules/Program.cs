using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véhicules
{
    class Program
    {
        static void Main(string[] args)
        {
            Véhicule v1 = new Voiture("Clio", Energies.Essence);

            Console.WriteLine(v1.Description);

            Console.ReadKey();
        }
    }
}
