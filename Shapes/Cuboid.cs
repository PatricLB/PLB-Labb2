using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cuboid : Shape3D
    {

        private readonly bool isCube = false;
        private Vector3 _side;
        private string returnObjectString;

        public override float Volume

        {
            get 
            { 
                return _volume = _side.X * _side.Y * _side.Z;
            }

        }
        public override float Area
        {
            get
            { 
                return (_side.X.Equals(_side.Y) && _side.Y.Equals(_side.Z)) 
                    ? 4 * _side.X 
                    : 2 * ((_side.X * _side.Z) + (_side.X * _side.Y) + (_side.Z * _side.Y));
            }
        }

        public Cuboid(Vector3 center, Vector3 size)
        {
            _center = center;
            _side = size;

            if (_side.X.Equals(_side.Y) && _side.Y.Equals(_side.Z))
            {
                this.isCube = true;
            }
        }
        public Cuboid(Vector3 center, float width) : this(center, new Vector3(width)){}

        public override string ToString()
        {
            returnObjectString = $"@({_center:f2}): w = {_side.X:f2}, H = {_side.Y:f2}, l = {_side.Z:f2}";

            returnObjectString = isCube ? "cube " + returnObjectString : "cubiod " + returnObjectString;

            return returnObjectString;
        }

    }
}
