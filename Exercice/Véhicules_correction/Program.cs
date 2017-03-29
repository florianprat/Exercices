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

            int res = v1.CompareTo(v2);
            if (res < 0)
                Console.WriteLine("La {0} est plus économique que la {1)", v1.Nom, v2.Nom);
            else if(res > 0)
                Console.WriteLine("La {0} est plus économique que la {1)", v2.Nom, v1.Nom);
            else
                Console.WriteLine("{0} a le même PRK que {1)", v1.Nom, v2.Nom);

            Console.ReadKey();

            
        }
    }
}
