using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHVFS_P101_GD08_HW2_April
{
    public class Player
    {
        // Speed
        public Vector2 Position;
        // 
        public Vector2 Direction;
        public int Score;
        #region Data structures
        public Dictionary<ConsoleKey, Vector2> InputDirections;
        #endregion
    }
}
