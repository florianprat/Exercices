using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boites
{
    class Program
    {
        static void Main(string[] args)
        {
            Etiquette etqDest = new Etiquette
            {
                Couleur = Couleurs.Blanc,
                Format = Formats.L,
                Texte = "Adresse"
            };

            Etiquette etqFragile = new Etiquette
            {
                Couleur = Couleurs.Rouge,
                Format = Formats.S,
                Texte = "FRAGILE"
            };

            Boite b1 = new Boite(30, 60, 20);
            Boite b2 = new Boite(30, 40, 50, Matières.Plastique);
            b2.Etiqueter(etqDest, etqFragile);

            //Console.WriteLine("Nombre de boîtes : {0}", Boite.Compteur);

            b1.Etiqueter("M.Dupont Jean", true);
            var a1 = new Article(1, "Article 1", 540);
            var a2 = new Article(2, "Article 2", 200);
            var a3 = new Article(3, "Article 3", 600);

            b1.Articles.Add(a3.Libellé, a3);
            b1.Articles.Add(a2.Libellé, a2);
            b1.Articles.Add(a1.Libellé, a1);

            b1.Articles["Article 2"].Poids = 2154;


            //b1.Articles.Sort();

            foreach (var a in b1.Articles)
            {
                Console.WriteLine(a.Value.ToString());
                // NB/ Si on n'appelle pas ToString, Writeline l'appelle automatiquement 
            }


            //Console.WriteLine("Boite de volume {0} cm3, de couleur {1} et en {2}",
            //    b1.Volume, b1.Couleur, b1.Matière);

            Console.ReadKey();
        }
    }

}
