using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombres_premiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien de nombre premier :");
            string valeur = Console.ReadLine();
            int N = int.Parse(valeur);

            int compt = 1;  // Compteur
            Console.WriteLine("2");
            int nbr = 3;
            Console.WriteLine(nbr);
            bool Est_premier = true;

            while (compt < N)
            {
                int divis = 3;
                Est_premier = true;

                do
                {
                    if (nbr % divis == 0)
                    {
                        Est_premier = false;
                    }
                    else
                    {
                        divis = divis + 2;
                    }
                } while (divis < nbr / 2 && Est_premier == true);

                if (Est_premier == true)
                {
                    Console.WriteLine(nbr);
                    compt++;
                }

                nbr = nbr + 2; // Nombre impair
            }

            Console.ReadKey();





        }
    }
}
