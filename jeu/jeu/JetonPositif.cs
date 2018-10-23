using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu
{
    class JetonPositif:Jeton
    {
        
        public JetonPositif():base()
        {
            GenererValeur();
        }

        public override void GenererValeur()
        {
            valeurJeton = genrateurJeton.Next(50) + 5;
        }
    }
}
