using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHVFS_P101_GD08_C2_Apri_Snakel
{
    public struct Vector2
    {
        //this is "small" inconsistency/code style
        //Mathematics libraries usually use camel instead of UpperCamer
        public int x;
        public int y;

        public Vector2(int x, int y)
        {
            //the keyword "this" means this object when an instance is instantiated using the keyword "new"
            this.x = x; //can't be the same so use "this"
            this.y = y;
        }
    }
}
