using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu
{
    class JetonPositif:Jeton
    {
        JetonPositif()
        {
            GenererValeur();
        }

        public override void GenererValeur()
        {

            int valeurJeton = genrateurJeton.Next(5) + 50;
        }
    }
}
