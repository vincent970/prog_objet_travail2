using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu
{
    class JetonNegatif:Jeton
    {
        

        JetonNegatif()
        {
            GenererValeur();
        }

        public override void GenererValeur()
        {
            
            int valeurJeton = genrateurJeton.Next(-4) - 2;
        }
    }
}
