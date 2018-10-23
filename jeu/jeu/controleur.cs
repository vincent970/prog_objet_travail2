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

        public Joueur JoueurCourant;

        public Controleur()
        {
            ajouterJoueurs();
            JoueurCourant = lesJoueurs[tour];
        }

        private void ajouterJoueurs()
        {
            lesJoueurs.Add(new Joueur("Jessy"));
            lesJoueurs.Add(new Joueur("Vincent"));
        }

        public Joueur ObtenirJoueur(int index)
        {
            return lesJoueurs[index - 1];
        }

        public void prochainJoueur()
        {
            tour = (tour + 1) % lesJoueurs.Count();
            JoueurCourant = lesJoueurs[tour];
        }

    }

}
