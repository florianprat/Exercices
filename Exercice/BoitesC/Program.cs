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
            Boite b1 = new Boite(30, 60, 20);
            Boite b2 = new Boite(30, 40, 50, Matières.Plastique);
            Etiquette etqDest = new Etiquette { Couleur = Couleurs.Blanc, Texte = "Adresse", Format = Formats.S };
            Etiquette etqFragile = new Etiquette { Couleur = Couleurs.Rouge, Texte = "FRAGILE", Format = Formats.S };
            b2.Etiqueter(etqDest, etqFragile);

            Console.WriteLine("Nombre de boîtes : {0}", Boite.Compteur);

            Etiquette e1 = new Etiquette { Couleur = Couleurs.bleu, Texte = "fdsfds", Format = Formats.S };

            Console.WriteLine("Boite de volume {0} cm3, de couleur {1} et en {2}",
                b1.Volume, b1.Couleur, b1.Matière);

            b1.Etiqueter("M. Dupond Jean", true);
            var a1 = new Article(1, "Article 1", 540);
            var a2 = new Article(2, "Article 2", 200);
            var a3 = new Article(3, "Article 3", 600);

            b1.Articles.Add(a3.Libellé, a3);
            b1.Articles.Add(a2.Libellé, a2);
            b1.Articles.Add(a1.Libellé, a1);

            b1.Articles["Article 2"].Poids = 2154;

            for (int i = 0; i < b1.Articles.Count; i++)
            {
               
                //b1.Articles[i].Libellé = "fdsfdsf";
                //Console.WriteLine(b1.Articles[i]);
                //if (b1.Articles[i] is Article)
                //{
                //    Article a = (Article)b1.Articles[i];
                //    a.Libellé = "sfsdqfs";
                //}
                //else
                //    throw new ArgumentException();
                
                //((Article)b1.Articles[i]).Libellé = "fdsffdsf";
            }

            //b1.Articles.Sort();

            foreach (var a in b1.Articles)
            {
                Console.WriteLine(a);
            }

            foreach (var v in b1.Articles.Values)

                Console.WriteLine("{0}", v);

            Console.ReadKey();
        }
    }
}
