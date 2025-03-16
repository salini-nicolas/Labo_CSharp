using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapeLibrary
{
    public abstract class Forme
    {
        protected Coordonnee coordonnees;
        

        public Forme(Coordonnee coordonnees)
        {
            this.coordonnees = coordonnees;
        }
    }
}
