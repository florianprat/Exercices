using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_bancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2017, 02, 25);
            CompteBancaire cb = new CompteBancaire(TypeCompte.Courant);

            cb.DécouvertAutorisé = -700;
            cb.Créditer(1000);
            Console.WriteLine("Solde courant : {0}", cb.SoldeCourant);

            cb.Débiter(600);
            Console.WriteLine("Solde courant : {0}", cb.SoldeCourant);

            cb.Débiter(2000);
            Console.WriteLine("Solde courant : {0}", cb.SoldeCourant);

            CompteBancaire ce = new CompteBancaire(TypeCompte.Epargne);
            CompteBancaire[] tabComptes = new CompteBancaire[3];
            tabComptes[0] = new CompteBancaire(TypeCompte.Courant);
            tabComptes[1] = new CompteBancaire(DateTime.Today, 500);
            tabComptes[2] = new CompteBancaire(TypeCompte.PEE);

            Console.ReadKey();
        }
    }

    public enum TypeCompte { Courant, Epargne, PEA , PEE }

    public class CompteBancaire
    {
        #region Champs privés
        private bool _aDécouvert;
        private DateTime _dateCréation;
        private DateTime _dateCloture;
        private decimal _soldeCourant;
        private decimal _decouvertAutorisé;
        private TypeCompte _type;
        #endregion

        /// <summary>
        /// Création d'un compte avec date de création
        /// </summary>
        public CompteBancaire()
        {
            _dateCréation = DateTime.Today;
        }

        /// <summary>
        /// Création d'un compte avec date de création
        /// </summary>
        /// <param name="dateCréa">Date de création</param>
        public CompteBancaire(TypeCompte type)
        {
            _dateCréation = DateTime.Today;
            _type = type;
        }
        /// <summary>
        /// Création d'un compte avec date de création et solde
        /// </summary>
        /// <param name="dateCréa">Date de création</param>
        /// <param name="solde">Solde initial</param>
        public CompteBancaire(DateTime dateCréa, decimal solde)
        {
            _dateCréation = dateCréa;
            _soldeCourant = solde;
        }


        #region Méthodes privées
        private int CalculerAncienneté()
        {
            return (DateTime.Today - _dateCréation).Days;
            //int anc = (DateTime.Today - _dateCréation).Days;
            //return anc;
        }

        private decimal CalculerIntérêts()
        {
            return 0;
        }

        private decimal CalculerSolde()
        {
            return _soldeCourant + CalculerIntérêts();
        }
        #endregion

        #region Méthodes publiques
        public void Cloturer()
        {
            _dateCloture = DateTime.Today;
            CalculerSolde();
        }

        public void Créditer(decimal montant)
        {
            _soldeCourant += montant;
        }

        public void Débiter(decimal montant)
        {
            _soldeCourant -= montant;
            if(_soldeCourant < _decouvertAutorisé)
            {
                _soldeCourant -= 5;
            }
            if (_soldeCourant < 0) _aDécouvert = true;
        }

        #endregion
    }

}
