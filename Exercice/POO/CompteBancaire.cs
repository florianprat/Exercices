using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public enum TypeCompte
    {
        Courant,
        Epargne,
        PEA,
        PEE
    }

    public class CompteBancaire
    {
        #region Champs privés
        private bool _aDécouvert;
        private DateTime _dateCréation;
        private DateTime _dateCloture;
        private decimal _soldeCourant;
        private decimal _devouvertAutorisé;
        private TypeCompte _type;
        #endregion

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

        #region Propriétés
        public bool ADécouvert
        {
            get { return _aDécouvert; }
        }

        public DateTime DateCloture
        {
            get { return _dateCloture; }
        }

        public DateTime DateCréation
        {
            get { return _dateCréation; }
        }

        public decimal SoldeCourant
        {
            get { return _soldeCourant; }
        }

        public decimal DécouvertAutorisé
        {
            get { return _devouvertAutorisé; }
            set { _devouvertAutorisé = value; }
        }
        #endregion

        #region Méthodes privées
        private int CalculerAncienneté()
        {
            return (DateTime.Today - _dateCréation).Days;
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
            if (_soldeCourant < _devouvertAutorisé)
            {
                _soldeCourant -= 5;
            }
            if (_soldeCourant < 0)
                _aDécouvert = true;
        }

        #endregion
    }
}
