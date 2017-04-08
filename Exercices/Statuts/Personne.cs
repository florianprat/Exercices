using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statuts
{
    #region Enumérations
    [Flags]
    public enum Statuts
    {
        Aucun = 0,
        CDI = 1,
        CDD = 2,
        DP = 4,
        CHSCT = 8,
        SYND = 16
    }
    #endregion

    public class Personne
    {
        #region Propriétés
        public string Nom { get; }
        public string Prénom { get; }
        public Statuts Statut { get; set; }
        #endregion

        #region Constructeurs
        public Personne(string nom, string prénom, Statuts statut)
        {
            Nom = nom;
            Prénom = prénom;
            Statut = statut;
        }
        #endregion

        #region Méthodes
        public override string ToString()
        {
            return string.Format("Nom : {0}, Prénom : {1}, Statut : {2}", Nom, Prénom, Statut);
        }
        #endregion
    }
}
