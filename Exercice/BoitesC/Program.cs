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


            
                

            Console.ReadKey();
        }
    }
}
