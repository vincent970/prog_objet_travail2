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
        List<IPointable> objets = new List<IPointable>();
        public int PointsCumulatifs
        {
            get { return pointsCumulatifs; }
        }
        public List<IPointable> Objets
        {
            get { return objets; }
        }

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

        public void ajouterPoints(int points) {
            pointsCumulatifs += points;
        }

        public void ajouterObjet(IPointable objetAAjouter)
        {
            objets.Add(objetAAjouter);
        }
    }
}
