﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu
{
    class JetonNegatif:Jeton
    {
        
        public JetonNegatif():base()
        {
            GenererValeur();
        }

        public override void GenererValeur()
        {
            valeurJeton = (genrateurJeton.Next(2) + 1)*-2;
        }
    }
}
