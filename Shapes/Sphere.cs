using System.Numerics;

namespace Shapes
{
    public class Sphere : Shape3D
    {

        private float _radius;
        public override float Volume
        {
            get
            {
                return _volume = ((float)((4 * (Math.PI * Math.Pow(_radius, 3))) / 3));
            }
        }

        public override float Area
        {
            get
            {
                return ((float)(4 * Math.PI * Math.Pow(_radius, 2)));
            }
        }

        public Sphere(Vector3 center, float radius)
        {
            _center = center;
            _radius = radius;

        }
        public override string ToString()
        {
            return $"sphere @({_center:f2}): r = {_radius:f2}"; ;
        }

    }
}
