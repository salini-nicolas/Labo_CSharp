using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapeLibrary
{
    class Rectangle : Forme, IEstDans, iPolygone, MathHelpers
    {
        private int longueur;
        private int largeur;

        // Properties
        public int Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        public int Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }

        // Constructor with initialization
        public Rectangle(Coordonnee coordonnees, int longueur, int largeur) : base(coordonnees)
        {
            this.longueur = longueur;
            this.largeur = largeur;
        }

        // Default constructor
        public Rectangle() : base(new Coordonnee(0, 0))
        {
            this.longueur = 0;
            this.largeur = 0;
        }

        // Overriding ToString()
        public override string ToString()
        {
            return $"{coordonnees}  Longueur: {longueur} Largeur: {largeur}";
        }
        public bool CoordonneeEstDans(Coordonnee p)
        {
            return p._x >= coordonnees._x && p._x <= coordonnees._x + largeur &&
                   p._y >= coordonnees._y && p._y <= coordonnees._y + longueur;
        }

        public int nbSommets => 4;

        public static double Aire(Rectangle r)
        {
            return r.Longueur * r.Largeur;
        }

        public static double Perimetre(Rectangle r)
        {
            return (r.Largeur * 2) + (r.longueur * 2);
        }
    }
}
