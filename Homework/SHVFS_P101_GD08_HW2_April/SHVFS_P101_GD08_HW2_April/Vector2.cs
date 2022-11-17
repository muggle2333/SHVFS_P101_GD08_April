using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHVFS_P101_GD08_HW2_April
{
    public struct Vector2
    {
        // This is "small" inconsistency/code style
        // Mathematics libraries usually use camel instead of UpperCamel
        public int x;
        public int y;

        public Vector2(int x, int y)
        {
            // the keyword "this" means this object when an instance is instantiated using the keyword "new"
            this.x = x;
            this.y = y;
        }

        public static readonly Vector2 Up = new Vector2(0, -1);
        public static readonly Vector2 Down = new Vector2(0, 1);
        public static readonly Vector2 Left = new Vector2(-1, 0);
        public static readonly Vector2 Right = new Vector2(1, 0);

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x + v2.x, v1.y + v2.y);
        }

        public static Vector2 operator -(Vector2 v)
        {
            return new Vector2(-v.x, -v.y);
        }

        public static bool operator ==(Vector2 v1, Vector2 v2)
        {
            return (v1.x == v2.x && v1.y == v2.y);
        }

        public static bool operator !=(Vector2 v1, Vector2 v2)
        {
            return (v1.x != v2.x || v1.y != v2.y);
        }
    }
}
