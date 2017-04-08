using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public abstract class Décorateur : Component
    {
        public Component Comp { get; }
        //protected Component comp;
        public Décorateur(Component comp)
        {
            Comp = comp;
        }
        public override string AfficherAlerte()
        {
            return Comp.AfficherAlerte();
        }
    }

    public class Alerte : Décorateur
    {
        public Alerte(Component comp) : base(comp)
        {
        }

        public override string AfficherAlerte()
        {
            if (((CompteBancaire)Comp).SoldeCourant < 0)
                return base.AfficherAlerte() + "\nATTENTION : le solde du compte est inférieur à 0";
            else
                return "";
        }
    }
}
