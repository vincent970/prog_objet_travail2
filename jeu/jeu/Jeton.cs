using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu
{
    class Jeton : IPointable
    {
        public int valeurJeton { get; set; }
        public static Random genrateurJeton = new Random();

        public int Points {
            get { return valeurJeton; }
        }

        public virtual void GenererValeur() {
            valeurJeton = 0;
        }
    }
}
