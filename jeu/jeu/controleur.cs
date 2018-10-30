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
        public IPointable objetCourant;
        int indexTypeObjetCourant;

        static Random generateurPoints = new Random();

        public List<Joueur> lesJoueurs = new List<Joueur>();
        int tour = 0;

        public Joueur JoueurCourant;

        public int IndexTypeObjetCourant
        {
            get { return indexTypeObjetCourant; }
        }

        public Controleur()
        {
            ajouterJoueurs();
            JoueurCourant = lesJoueurs[tour];
        }

        public void genererUnObjet()
        {
            Array values = Enum.GetValues(typeof(TypeObjet));
            Random random = new Random();
            TypeObjet randomTypeObjet = (TypeObjet)values.GetValue(random.Next(values.Length));          
            {
                objetCourant = null;
                switch (randomTypeObjet)
                {
                    case TypeObjet.De:
                        objetCourant = new De();
                        break;
                    case TypeObjet.Carte:
                        objetCourant = new Carte();
                        break;
                    case TypeObjet.JetonPositif:
                        objetCourant = new JetonPositif();
                        break;
                    case TypeObjet.JetonNegatif:
                        objetCourant = new JetonNegatif();
                        break;
                    default:
                        throw new Exception("Impossible de créer ce type d'employé");
                }
            }
        }

        public void ajouterPointsAuJoueurCourant()
        {
            JoueurCourant.ajouterPoints(objetCourant.Points);
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
