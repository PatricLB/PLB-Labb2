using System.Numerics;

namespace Shapes
{
    public abstract class Shape3D : Shape
    {

        public Vector3 _center;
        public float _volume;

        public override Vector3 Center
        {
            get
            {
                return _center;
            }
        }

        public abstract float Volume { get; }

    }
}
