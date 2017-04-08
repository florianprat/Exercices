using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entraînement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demo();
            AfficherPersonne("Cyril", "Seguenot");
            AfficherPersonne("Robert", "Duval");
            Console.ReadKey();
        }

        static void AfficherPersonne(string prénom, string nom)
        {
            Console.WriteLine("prénom : " + prénom + " nom : " + nom);
        }


        static void Demo()
        {
            string texte;
            string phrase;
            int nbPhrases, nbMots, nbCaractères; // plusieurs déclarations

            const double PI = 3.1415926;
            const string DEB_LISTE = " - ";

            phrase = "Le C# est un langage moderne et puissant!";
            texte = phrase;
            texte = texte + " Il est utilisé pour toutes sortes d'applications\n";
            texte += DEB_LISTE + "Application console\n"; // Concaténation condensée (texte = texte + ...)
            texte += DEB_LISTE + "Application fenêtrée Winforms et WPF\n";

            Console.WriteLine(texte);
            char lettre;
            lettre = phrase[3];
            Console.WriteLine(lettre);

            short s = 2;
            s++; // Incrémentation de 1 de manière condensée (s = s + 1 ou s += 1)
            Console.WriteLine("La valeur de s est : " + s);

            int[] tabPos = new int[5] { 3, 4, 40, 50, 60 }; // Tableau de 3 entiers
            // tabPos[0] = 3;
            // tabPos[1] = 3; On peut affecter des valeurs après la déclaration
            // tabPos[2] = 4;
            // string s = "" ou string s = string.Empty pour une chaîne de caractères vide

            Console.WriteLine(tabPos.Length); // Nombre d'éléments du tableau

            for (int i = 0; i < tabPos.Length; i++)  // Boucle (initialisation, condition de fin, incrémentation)
                                                     // dans notre cas i <= tabPos.Length-1 ou i < tabPos.Length
                                                     // i + 1 ou encore i+=2 ou encore i-- (attention dans ce cas à l'initialisation)
            {
                Console.WriteLine(tabPos[i]);
            }

            int j = 0; // Autre boucle, donne la même chose que la boucle précédente
            while (j < tabPos.Length)
            {
                Console.WriteLine(tabPos[j]);
                j++;
            }

            Console.Clear(); // Efface l'écran
            Console.WriteLine(texte);

            nbPhrases = 0; // On compte le nombre de \n pour compter le nombre de phrases
            for (int i = 0; i < texte.Length; i++)
            {
                if(texte[i] == '\n')  // il y a == pour comparer, tester (si on avait eu = il aurait tenté d'affecter une valeur)
                {
                    nbPhrases++;
                }
                        
            }
            Console.WriteLine("il y a " + nbPhrases + " lignes dans le texte");

            Console.Clear();

            nbMots = 0;
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == ' ' || phrase[i] == '\'' || phrase[i] == '\n')  // Pour écrire OU : ||
                {
                    nbMots++;
                }
            }
            nbMots++;
            Console.WriteLine("il y a " + nbMots + " mots dans la phrase");

            Console.WriteLine("Entrer un nombre :");
            string valeur = Console.ReadLine();
            int x = int.Parse(valeur); // Transformer une chaîne en entier
        }
    }
}
