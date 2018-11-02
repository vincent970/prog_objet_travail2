using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu
{
    class Carte : IPointable
    {
        const char pique = '\u2664'; //ou '\u2660'
        const char trefle = '\u2667'; //ou '\u2663'
        const char coeur = '\u2661'; //ou '\u2665'
        const char carreau = '\u2662'; //ou '\u2666'
        char[] lesAtouts = new char[4] { pique, trefle, coeur, carreau };

        static Random generateurCarte = new Random();

        int valeurCarte;
        char atoutCarte;

        public string ValeurCarte
        {
            get { return valeurCarte.ToString() + " " + atoutCarte; }
        }

        public int ValeurChiffreCarte
        {
            get { return valeurCarte; }
        }

        public int Points
        {
            get { return valeurCarte; }
        }

        virtual public string Type
        {
            get { return "Carte"; }
        }

        public Carte()
        {
            GenererCarte();
        }

        public void GenererCarte()
        {
            valeurCarte = generateurCarte.Next(13) + 1;
            atoutCarte = GenererAtout();
        }

        char GenererAtout()
        {
            int indice = generateurCarte.Next(4);
            return lesAtouts[indice];
        }
         
        public static bool operator >(Carte Carte1, Carte Carte2)
        {
            return (Carte1.valeurCarte > Carte2.valeurCarte);
        }

        public static bool operator <(Carte Carte1, Carte Carte2)
        {
            return (Carte1.valeurCarte < Carte2.valeurCarte);
        }
    }

}
