using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape2D : Shape
    {

        public Vector3 _center;
        public override Vector3 Center { get { return _center; } }

        public abstract float Circumference { get; }

    }
}
