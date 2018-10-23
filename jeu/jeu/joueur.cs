using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu
{
    class Joueur
    {
        public String Nom { get; protected set; }
        int pointsCumulatifs;

        

        public Joueur()
        {
            Nom = "";
            pointsCumulatifs = 0;
        }

        public Joueur(string nom)
        {
            Nom = nom;
            pointsCumulatifs = 0;
        }
    }
}
