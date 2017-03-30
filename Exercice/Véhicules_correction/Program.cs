using System;
using System.Collections.Generic;

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

            object o = new object();

            try
            {
                int res = v1.CompareTo(o);
                if (res < 0)
                    Console.WriteLine("{0} est plus économique que {1}", v1.Nom, v2.Nom);
                else if (res > 0)
                    Console.WriteLine("{0} est plus économique que {1}", v2.Nom, v1.Nom);
                else
                    Console.WriteLine("{0} a le même PRK que {1}", v1.Nom, v2.Nom);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Comparaison impossible");
            }

            var v3 = new Voiture("Mégane", 19000);
            var v4 = new Moto("Intruder", 13000);
            var v5 = new Voiture("Enzo", 380000);
            var v6 = new Moto("Yamaha XJR1300", 11000);

            var dico = new Dictionary<string, Vehicule>();

            dico.Add(v3.Nom, v3);
            dico.Add(v4.Nom, v4);
            dico.Add(v5.Nom, v5);
            dico.Add(v6.Nom, v6);

            Console.Clear();

            foreach (var a in dico)
                Console.WriteLine("{0} : {1}", a.Key, a.Value.Prix);

            //var liste = new SortedList<string, Vehicule>();

            //// Transfert du contenu du dictionnaire
            //foreach (var a in dico)
            //    liste.Add(a.Key, a.Value);

            //dico.Clear();

            //foreach (var a in liste)
            //    Console.WriteLine("{0} : {1}", a.Key, a.Value.Prix);

            var liste = new SortedList<Vehicule, string>();

            foreach (var a in dico)
                liste.Add(a.Value, a.Key);

            //dico.Clear();

            foreach (var a in liste)
                Console.WriteLine("{0} : {1}", a.Key.Prix, a.Value);

            string[] tab = new string[5];
            tab[0] = "Clio";
            tab[1] = "Mégane";
            tab[2] = "Golf";
            tab[3] = "Enzo";
            tab[4] = "Polo";

            foreach (var a in dico)
                for (int i = 0; i < tab.Length; i++)
                {
                    int res = tab[i].CompareTo(a.Key);
                    if (res == 0)
                        Console.WriteLine("{0} : {1}", a.Key, a.Value.Prix);
                }
                    



            Console.ReadKey();
        }
    }
}
