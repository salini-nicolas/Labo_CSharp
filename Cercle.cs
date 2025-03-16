using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapeLibrary
{
    class Cercle : Forme, IEstDans, MathHelpers
    {
        private int rayon;

        public int Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }

        public int Diametre
        {
            get { return rayon * 2; }
        }
        public Cercle(Coordonnee coordonnees, int rayon) : base(coordonnees)
        {
            this.rayon = rayon;
        }

        public Cercle() : base(new Coordonnee(0, 0))
        {
            this.rayon = 0;
        }

        public override string ToString()
        {
            return $"{coordonnees} Rayon: {rayon} Diamètre: {Diametre}";
        }

        public bool CoordonneeEstDans(Coordonnee p)
        {
            int dx = p._x - coordonnees._x;
            int dy = p._y - coordonnees._y;
            return (dx * dx + dy * dy) <= (rayon * rayon);
                
        }

        public static double Aire(Cercle c)
        {
            return Math.PI * (c.rayon * c.rayon);
        }

        public static double Perimetre(Cercle c)
        {
            return c.Diametre * Math.PI;
        }
    }
}
