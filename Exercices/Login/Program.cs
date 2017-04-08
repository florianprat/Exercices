using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demander à l'utilisateur de saisir un login
            bool loginOK = false;

            while (loginOK == false)
            {
                try
                {
                    Console.WriteLine("login :");
                    string login = Console.ReadLine();
                    VerifLogin(login);
                    loginOK = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    loginOK = false;
                }
            }

            // Demander à l'utilisateur de saisir un mot de passe
            bool mdpOK = false;

            while (mdpOK == false)
            {
                try
                {
                    Console.WriteLine("mot de passe :");
                    string mdp = Console.ReadLine();
                    VerifMdp(mdp);
                    mdpOK = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    mdpOK = false;
                }
            }

            // Confirmation de la création du compte
            Console.WriteLine("Votre compte a bien été créé. Un message vient de vous être envoyé.");

            Console.ReadKey();
        }

        //
        // Vérification du login
        //
        static void VerifLogin(string log)
        {
            if (log.Length < 5)
            {
                throw new FormatException("Le login doit comporter au moins 5 caractères");
            }
        }

        //
        // Vérification du mot de passe
        //
        static void VerifMdp(string mdpasse)
        {
            if (mdpasse.Length < 6 || mdpasse.Length > 12 || mdpasse[0] == ' ' || mdpasse[mdpasse.Length - 1] == ' ')
            {
                throw new FormatException("Le mot de passe doit comporter au moins 6 caractères, au plus 12, et ne doit pas commencer ni finir par un espace");
            }
        }

    }
}
