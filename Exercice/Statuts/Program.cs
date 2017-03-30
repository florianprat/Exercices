using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statuts
{
    class Program
    {
        static void Main(string[] args)
        {
            var liste = new List<Personne>();

            liste.Add(new Personne("TURPIN", "Abel", Statuts.CDI));
            liste.Add(new Personne("BONNEAU", "Achille", Statuts.CDD | Statuts.DP));
            liste.Add(new Personne("BLONDEL", "Adelphe", Statuts.CDI | Statuts.DP | Statuts.CHSCT | Statuts.SYND));
            liste.Add(new Personne("BLACK", "Aimé", Statuts.CDI));
            liste.Add(new Personne("PERRIER", "Aimée", Statuts.CDI));
            liste.Add(new Personne("JORDAN", "Alain", Statuts.CDD | Statuts.CHSCT));
            liste.Add(new Personne("BAUDRY", "Alban", Statuts.CDD));
            liste.Add(new Personne("ORLEANS", "Albert", Statuts.CDI | Statuts.DP | Statuts.SYND));
            liste.Add(new Personne("VALOIS", "Alexandra", Statuts.CDI | Statuts.SYND));
            liste.Add(new Personne("WEST", "Alexandre", Statuts.CDI | Statuts.DP | Statuts.CHSCT));

            // Liste des personnes qui sont à la fois en CDD et membre du CHSCT
            var list1 = new List<Personne>();
            Statuts test1 = Statuts.CDD | Statuts.CHSCT;
            foreach (var a in liste)
                if ((a.Statut & test1) == test1)
                    list1.Add(a);
            Console.WriteLine("Liste des personnes à la fois en CDD et membre du CHSCT");
            foreach (var a in list1)
                Console.WriteLine(a.ToString());

            // Liste des personnes qui sont à la fois en CDI et délégué du personnel
            var list2 = new List<Personne>();
            Statuts test2 = Statuts.CDI | Statuts.DP;
            foreach (var a in liste)
                if ((a.Statut & test2) == test2)
                    list2.Add(a);
            Console.WriteLine("\nListe des personnes à la fois en CDI et délégué du personnel");
            foreach (var a in list2)
                Console.WriteLine(a.ToString());

            // Ajout du statut de membre CHSCT aux personnes de la deuxième liste
            foreach (var a in list2)
                if ((a.Statut & Statuts.CHSCT) != Statuts.CHSCT)
                    a.Statut = a.Statut | Statuts.CHSCT;
            Console.WriteLine("\nAjout du statut CHSCT aux personnes de la deuxième liste");
            foreach (var a in list2)
                Console.WriteLine(a.ToString());




            Console.ReadKey();



        }
    }
}
