using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer un nombre p :");  // Défintion du nombre p
            string valeur_1 = Console.ReadLine();
            int p = int.Parse(valeur_1);

            Console.WriteLine("Entrer un nombre q :");  // Défintion du nombre q
            string valeur_2 = Console.ReadLine();
            int q = int.Parse(valeur_2);

            while (p != q)
            {
                if (p > q)
                {
                    p = p - q;
                }
                else
                {
                    q = q - p;
                }
                
            }

            Console.WriteLine(" PGCD = " + p);
            Console.ReadKey();
        }
    }
}
