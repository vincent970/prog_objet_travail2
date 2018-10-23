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
        int numeroTypeObjet;

        static Random generateurPoints = new Random();

        List<Joueur> lesJoueurs = new List<Joueur>();
        int tour = 0;

        public int NumeroTypeObjet
        {
            get { return numeroTypeObjet; }
        }
        public Controleur()
        {
        }

        public void GenererUnObjet()
        {          
            Random generateurTypeObjet = new Random();
            numeroTypeObjet = generateurTypeObjet.Next(3)+0;
            
            //objetCourant = fabriqueObjet.creerObjet(typeObjet);            
            switch (numeroTypeObjet)
            {
                case 0:
                    objetCourant = new De();
                break;
                case 1:
                    objetCourant = new Carte();
                break;
                case 2:
                    objetCourant = new JetonPositif();
                break;
                case 3:
                    objetCourant = new JetonNegatif();
                    break;
                default:
                    throw new Exception("Impossible de créer ce type d'employé");
            }
        }

    }

}
