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

            int res = v1.CompareTo(v2);
            if (res < 0)
                Console.WriteLine("{0} est plus économique que {1}", v1.Nom, v2.Nom);
            else if (res > 0)
                Console.WriteLine("{0} est plus économique que {1}", v2.Nom, v1.Nom);
            else
                Console.WriteLine("{0} a le même PRK que {1}", v1.Nom, v2.Nom);

            Vehicule mégane = new Voiture("Mégane", 19000);
            Vehicule intruder = new Voiture("Intruder", 13000);
            Vehicule enzo = new Voiture("Enzo", 380000);
            Vehicule yamaha = new Voiture("Yamaha XJR1300", 11000);

            // Ajout des véhicules dans un dictionnaire non trié
            var dico = new Dictionary<string, Vehicule>();
            dico.Add(mégane.Nom, mégane);
            dico.Add(intruder.Nom, intruder);
            dico.Add(enzo.Nom, enzo);
            dico.Add(yamaha.Nom, yamaha);

            foreach (var kvp in dico)
            {
                // Les éléments s'affichent dans l'ordre dans lequel on les a
                // ajoutés au dictionnaire
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value.Prix);
            }

            // Copie du contenu du dictionnaire dans une liste triée
            var lst = new SortedList<string, Vehicule>();
            foreach (var kvp in dico)
                lst.Add(kvp.Key, kvp.Value);
            // Autre possibilité plus simple :
            //var lst = new SortedList<string, Vehicule>(dico);

            // Pour vider le dictionnaire :
            // dico.Clear();
            Console.WriteLine();

            // Affichage du contenu de la liste triée
            // Les éléments s'affichent dans l'ordre de la clé
            // c'est à dire par ordre alphabétique du nom
            foreach (var kvp in lst)
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value.Prix);

            // Copie du contenu du dictionnaire dans une liste triée
            // en permutant la clé et la valeur
            var lst2 = new SortedList<Vehicule, string>();
            foreach (var kvp in dico)
                lst2.Add(kvp.Value, kvp.Key);

            // Affichage du contenu de la liste triée
            // Les éléments s'affichent dans l'ordre de la clé
            // c'est à dire ici selon le critère de comparaison des véhicules (le prix)
            Console.WriteLine();
            foreach (var kvp in lst2)
                Console.WriteLine("{0} : {1}", kvp.Key.Nom, kvp.Key.Prix);

            Console.WriteLine();
            string[] tab = new string[] { "Clio", "Mégane", "Golf", "Enzo", "Polo" };
            // recherche des éléments du tableau ci-dessu dans le dictionnaire
            foreach (var s in tab)
            {
                Vehicule v;
                if (dico.TryGetValue(s, out v))
                    Console.WriteLine("{0} : {1}", v.Nom, v.Prix);
            }

            Console.ReadKey();
        }
    }
}
