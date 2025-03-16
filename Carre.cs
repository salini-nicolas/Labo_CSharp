using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapeLibrary
{
    public class Carre : Forme, IEstDans, iPolygone, MathHelpers
    {
        private int _tailleCote;

        public int tailleCote { get { return tailleCote; } }
        public Carre(Coordonnee coordonnees, int tailleCote) : base(coordonnees)
        {
            
           _tailleCote = tailleCote;
        }

        public Carre() : base(new Coordonnee(0,0))
        {
            _tailleCote = 0;
        }
        public override string ToString()
        {
            return $"{coordonnees}{tailleCote}";
        }

        public bool CoordonneeEstDans(Coordonnee p)
        {
            return p._x >= coordonnees._x && p._x <= coordonnees._x + tailleCote &&
                   p._y >= coordonnees._y && p._y <= coordonnees._y + tailleCote;
        }

        public int nbSommets => 4;

        public static double Aire(Carre c)
        {
            return c.tailleCote * c.tailleCote;
        }

        public static double Perimetre(Carre c)
        {
            return 4 * c.tailleCote;
        }

    }
}
