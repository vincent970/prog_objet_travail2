using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu
{
    abstract class Jeton : IPointable
    {
        public static Random genrateurJeton = new Random();
        public int valeurJeton;        

        public int Points {
            get { return valeurJeton; }
        }

        virtual public string Type {
            get { return ""; }
        }

        public virtual void GenererValeur() { }
    }
}
