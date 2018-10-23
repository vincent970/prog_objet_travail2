using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu
{
    //voir
    // https://openclassrooms.com/courses/apprenez-a-programmer-en-c-sur-net/les-classes-1-2
    //https://bpesquet.gitbooks.io/programmation-orientee-objet-csharp/content/
    class De : IPointable
    {
        //private par défaut
        int[] facesDe;
        int valeurDe;
        bool selectionne;

        public event EventHandler ChangementDeValeur;

        //on pourrait aussi utiliser le type String ou string qui sont équivalents

        //static: 
        //  le générateur est le même pour tous les objets de type De
        //  on parle d'un attribut de classe (appartient à la classe et non aux objets)
        static Random generateurNombre = new Random();
        //PROPRIÉTÉ: 
        //      remplace les accesseurs standards
        //      donne l'impression d'utiliser directement un attribut
        //		sans set, il s'agit d'une propriété en lecture seule
        //      on essaie d'éviter les set pour respecter le principe TELL DON'T ASK
        public int ValeurDe
        {
            get { return valeurDe; }
            //set reçoit une valeur du type de la propriété nommée value
            //set { valeurDe = value; }
        }
        
        public bool Selectionne
        {
            get { return selectionne; }
            //set { selectionne = value; }
        }

        public int Points
        { get { return valeurDe; }
        }

        public De()
        {
            facesDe = new int[] { 1, 2, 3, 4, 5, 6, };
            Brasser();
            selectionne = false;
        }
        public De(int face1, int face2, int face3,int face4, int face5, int face6)
        {
            facesDe = new int[6];
            facesDe[0] = face1;
            facesDe[1] = face2;
            facesDe[2] = face3;
            facesDe[3] = face4;
            facesDe[4] = face5;
            facesDe[5] = face6;
            Brasser();
            selectionne = false;
        }
        /*
         Retourner un code d'erreur d'une méthode n'oblige pas le développeur à le tester;
         lever une exception dans une méthode oblige le développeur à la traiter.
         (...)
         Avec le mécanisme des exceptions, l'erreur bloque l'exécution du programme si le
         développeur n'a pas prévu un traitement. 
         Apprendre la Programmation Orientée Objet avec le langage C# p.137 
         */
        public int GetFace(int indice)
        {
            if (indice < 0 || indice > 5)
            {
                throw new Exception("Dé: Indice hors limites!");
            }
            return facesDe[indice];
        }


        public void Brasser()
        {
            int faceAleatoire = generateurNombre.Next(6);
            valeurDe = facesDe[faceAleatoire];
            if (ChangementDeValeur != null)
            {
                ChangementDeValeur(this, new EventArgs());
            }

        }

        //Tell don't ask
        public void Selectionner()
        {
            selectionne = true;
        }
        public void Deselectionner()
        {
            selectionne = false;
        }
        public void InverserSelection()
        {
            selectionne = !selectionne;
        }
        //les opérateurs surchargés doivent être static
        //la méthode appartient donc à la classe, elle est partagée entre les objets
        static public int operator+(De de1, De de2)
        {
            return de1.valeurDe + de2.valeurDe;
        }
        static public int operator+(De de1, int valeurAjout)
        {
            return de1.valeurDe + valeurAjout;
        }
        static public int operator+(int valeurAjout, De de1)
        {
            return de1.valeurDe + valeurAjout;
        }


        /* 
         Toutes les classes héritent du type Object
         Celui-ci contient les méthodes .ToString() - .Equals() - .GetType() et .GetHashCode()
         Il est possible de redefinir ces méthodes pour nos classes.
         */
        //override permet de redéfinir une méthode identifiée comme virtual dans la classe de base
        //Equals agit comme opérateur==
        public override bool Equals(object obj)
        {
            bool equal = false;
            if (obj is De)
            {
                if (valeurDe == (obj as De).valeurDe)
                {
                    equal = true;
                }
            }
            return equal;
        }
        public override string ToString()
        {
            return valeurDe.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
