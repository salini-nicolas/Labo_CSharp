namespace MyShapeLibrary
{
    public class Coordonnee
    {
        internal int _x;
        internal int _y;

        public int x { get { return _x; } }
        public int y { get { return _y; } }

        public Coordonnee(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"{x},{y}";
        }
    }
}
