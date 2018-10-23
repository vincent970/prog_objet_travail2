using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu
{
    class Controleur
    {
        public enum TypeObjet { De, Carte, JetonPositif, JetonNegatif }
        public string[] nomTypeObjet = { "De", "Carte", "JetonPositif", "JetonNegatif" };

        static Random generateurPoints = new Random();

        List<Joueur> lesJoueurs = new List<Joueur>();
        int tour = 0;


        public Controleur()
        {
        }

    }

}
