using System.Numerics;

namespace Shapes
{
    public class Rectangle : Shape2D
    {

        private Vector2 _size;
        public bool isSquare = false;
        private string returnObjectString;

        public override float Circumference
        {

            get { return 2 * (_size.X + _size.Y); }

        }

        public override float Area
        {
            get
            {
                return _size.X * _size.Y;
            }
        }

        public Rectangle(Vector2 center, Vector2 sida)
        {
            Vector3 vector2till3 = new Vector3();
            vector2till3.X = center.X;
            vector2till3.Y = center.Y;
            vector2till3.Z = 0.0f;
            _center = vector2till3;

            _size = sida;

            if (_size.X.Equals(_size.Y))
            {
                this.isSquare = true;
            }
        }
        public Rectangle(Vector2 center, float width) : this(center, new Vector2(width)) { }

        public override string ToString()
        {
            returnObjectString = $"@({_center.X:f2}, {_center.Y:f2}): w = {this._size.X:f2} h = {this._size.Y:f2}";

            returnObjectString = isSquare ? "square " + returnObjectString : "rectangle  " + returnObjectString;

            return returnObjectString;

        }

    }
}
