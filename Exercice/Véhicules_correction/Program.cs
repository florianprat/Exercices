using System;

namespace Véhicules
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilisation polymorphique des classes
            Vehicule v1 = new Voiture("Renault Clio", Energies.Gazole);
            Console.WriteLine(v1.Description);

            Vehicule v2 = new Moto("Yamaha XJR1300", Energies.Essence);
            Console.WriteLine(v2.Description);

            Console.ReadKey();
        }
    }
}
