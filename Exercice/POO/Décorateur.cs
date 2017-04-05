using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public interface IComposable
    {
        CompteBancaire cptBan { get; }
        void AfficherMessage();
        
    }

    public abstract class Décorateur : IComposable
    {
        override
    }

    public class Alerte : Décorateur
    {

    }
}
