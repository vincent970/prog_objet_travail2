using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu
{
    class fabriqueObjet
    {
        static public IPointable creerObjet(string typeObjet)
        {
            IPointable objet = null;
            switch (typeObjet)
            {
                case "De":
                    objet = new De();
                    break;
                case "Carte":
                    objet = new Carte();
                    break;
                case "JetonPositif":
                    objet = new JetonPositif();
                    break;
                case "JetonNegatif":
                    objet = new JetonNegatif();
                    break;
                default:
                    throw new Exception("Impossible de créer ce type d'employé");
            }
            return objet;
        }
    }
}
